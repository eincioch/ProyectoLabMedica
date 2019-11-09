using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.FichaAtencion;
using Integration.BE.CtasCtesMedica;
using Integration.DAService.DA_CtasCtesMedica;
using Integration.DAService.DA_FichaAtencion;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Transactions;

namespace Integration.BL.BL_CtasCtesMedica
{
    public class BL_CuentaCorriente
    {
        public string Get_NewCorrelativoRecCtaCteItem(string cPerJuridica)
        {
            BE_ReqCtaCteNumeracion ReqNumeracion = new BE_ReqCtaCteNumeracion();
            DA_CtaCteNumeracion ObjNumeracion = new DA_CtaCteNumeracion();
            ReqNumeracion.cPerJuridica = cPerJuridica;

            return ObjNumeracion.Get_NroRecibo_By_cPerJuridica_NewId(ReqNumeracion);
        }

        #region Insert CuentaCorriente
        public bool Insert_CuentaCorriente(BE_ReqCuentaCorriente cuentacorriente)
        {
            DA_CuentaCorriente cuentaCorrienteDAO = new DA_CuentaCorriente();
            return cuentaCorrienteDAO.Ins_CuentaCorriente(cuentacorriente);
        }
        #endregion
        

        #region Registrar programacion de Recibo

        //----------------------------------------------------------------------------
        // Insert PerCuenta / CuentaCorriente / Ins_CtaCteDetalle / Upd-FichaAtencion
        //----------------------------------------------------------------------------
        public bool Ins_CuentaCorriente_ProgracionPago(string cPerCodigo, string cPerJurCodigo, string nSolAdmNumero, int nAdmSolEstado, int nPerCtaTipo, int nIntClase, int nCtaCteCuota, double fCtaCteImporte, DateTime dCtaCteFecVence, DateTime dCtaCteFecEmis, string cGlosa, int nPrdCodigo, int nMonCodigo, List<BE_ReqCtaCteDetalle> ReqCCDetalle, string cPerCodigoAut)
        {
            bool exito = false;

            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    string cNroRecibo = "";
                    int nPerCtaCodigo = 0;
                    int vnCtaCteTipo = 0;

                    //Get PerCuenta
                    BL_PerCuenta ObjPerCta = new BL_PerCuenta();
                    DataTable dt = new DataTable();
                    dt = ObjPerCta.Get_PerCuenta(cPerCodigo, cPerJurCodigo);

                    if (dt.Rows.Count > 0)
                    {
                        nPerCtaCodigo = Convert.ToInt32(dt.Rows[0]["nPerCtaCodigo"]);
                        vnCtaCteTipo = Convert.ToInt32(dt.Rows[0]["nPerCtaTipo"]);
                    }
                    else
                    {
                        //Creando PerCuenta
                        if (!ObjPerCta.Ins_PerCuenta(cPerCodigo, nPerCtaTipo, cPerJurCodigo))
                        {
                            throw new ApplicationException("Se encontraron errores al Crear Cuenta Persona. [Ins_PerCuenta].!");
                        }
                        else
                        {
                            dt = ObjPerCta.Get_PerCuenta(cPerCodigo, cPerJurCodigo);
                            if (dt.Rows.Count > 0)
                            {
                                nPerCtaCodigo = Convert.ToInt32(dt.Rows[0]["nPerCtaCodigo"]);
                                vnCtaCteTipo = Convert.ToInt32(dt.Rows[0]["nPerCtaTipo"]);
                            }
                            else
                            {
                                throw new ApplicationException("Se encontro Cuenta Registra Persona. [Get_PerCuenta].!");
                            }
                        }
                    }


                    //Generar New Id Recibo
                    cNroRecibo = Get_NewCorrelativoRecCtaCteItem(cPerJurCodigo);

                    //para CuentaCorriente
                    BE_ReqCuentaCorriente ReqCtaCte = new BE_ReqCuentaCorriente();
                    DA_CuentaCorriente ObjCtaCte = new DA_CuentaCorriente();
                    
                    ReqCtaCte.cCtaCteRecibo = cNroRecibo;
                    ReqCtaCte.nPerCtaCodigo = nPerCtaCodigo;
                    ReqCtaCte.nCtaCteTipo = vnCtaCteTipo; 
                    ReqCtaCte.fCtaCteImporte = fCtaCteImporte;
                    ReqCtaCte.nCtaCteCuota = nCtaCteCuota;
                    ReqCtaCte.nCtaCteEstado = 1;
                    ReqCtaCte.dCtaCteFecVence = dCtaCteFecVence;
                    //ReqCtaCte.dCtaCteFecPago = dCtaCteFecPago; //Para actualizar campo cuando realiza el pago.
                    ReqCtaCte.dCtaCteFecEmis = dCtaCteFecEmis;
                    ReqCtaCte.cCtaCteGlosa = cGlosa;  //"Programación Pago Ficha Atención"; 
                    ReqCtaCte.nPrdCodigo = nPrdCodigo;
                    ReqCtaCte.nMonCodigo = nMonCodigo;  //Periodo actual
                    ReqCtaCte.fCtaCteIgv = 0; //fCtaCteIgv;
                    ReqCtaCte.dCtaCteFecProg = dCtaCteFecEmis; //dCtaCteFecProg;
                    ReqCtaCte.cSerDescripcion = ""; //cSerDescripcion;
                    ReqCtaCte.fCtaCteSaldo = 0; //fCtaCteSaldo;

                    if (!ObjCtaCte.Ins_CuentaCorriente(ReqCtaCte))
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: BL-Ins_CuentaCorriente.!");
                    }
                    else exito = true;

                    //------------------------------------------------
                    //Insert Ins_CtaCteDetalle: recorre todo la "List"
                    //------------------------------------------------
                    DA_CtaCteDetalle daCCDet = new DA_CtaCteDetalle();
                    foreach (BE_ReqCtaCteDetalle Item in ReqCCDetalle)
                    {
                        Item.cCtaCteRecibo = cNroRecibo; //Id. Recibo
                        exito = daCCDet.Ins_CtaCteDetalle(Item);
                        if (!exito)
                        {
                            break;
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCteDetalle].!");
                        }
                    }

                    //-------------------------------------------------------------------------------------
                    //Insert CtaCteIntDetalle .- se aplica cambio para realizar pagos multiples en la Ficha
                    //Update 2016-04-06(eincio) - Ins_CtaCteIntDetalle <nIntCodigo>=1 pagos normales
                    //-------------------------------------------------------------------------------------
                    BLCtaCteIntDetalle Servicio = new BLCtaCteIntDetalle();

                    if (!Servicio.Ins_CtaCteIntDetalle(cNroRecibo,1,nIntClase,"",nSolAdmNumero))
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: BL-Ins_CtaCteIntDetalle.!");
                    }

                    //-------------------------------------------
                    //Actualizando AdmSolAtencion (cCtaCteRecibo) 
                    //-------------------------------------------
                    BL_FichaAtencion.BL_FichaAtencion Obj_UpdFichaAtencion = new BL_FichaAtencion.BL_FichaAtencion();

                    if (!Obj_UpdFichaAtencion.Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero(cPerJurCodigo, nSolAdmNumero, cNroRecibo, nAdmSolEstado, cPerCodigoAut)) {
                        throw new ApplicationException("Se encontraron errores en la transaccion: BL-Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero.!");
                    }

                    tx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        #region Programar Pago en Bloque Lab/Empresas

        //----------------------------------------------------------------------------
        // Insert PerCuenta / CuentaCorriente / Ins_CtaCteDetalle / Upd-FichaAtencion
        //----------------------------------------------------------------------------
        public bool Ins_CuentaCorriente_ProgracionPagoBloque(string cPerCodigo, string cPerJurCodigo, int nPerCtaTipo, int nCtaCteCuota, double fCtaCteImporte, DateTime dCtaCteFecVence, DateTime dCtaCteFecEmis, string cGlosa, int nPrdCodigo, int nMonCodigo, List<BE_ReqCtaCteDetalle> ReqCCDetalle, List<ReqCtaCteIntDetalle> ObjCtaCteIntDetalle,List<BE_ReqSolAtencion> ObjAdmSolAtencion)
        {
            bool exito = false;

            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    string cNroRecibo = "";
                    int nPerCtaCodigo = 0;
                    int vnCtaCteTipo = 0;

                    //Get PerCuenta
                    BL_PerCuenta ObjPerCta = new BL_PerCuenta();
                    DataTable dt = new DataTable();
                    dt = ObjPerCta.Get_PerCuenta(cPerCodigo, cPerJurCodigo);

                    if (dt.Rows.Count > 0)
                    {
                        nPerCtaCodigo = Convert.ToInt32(dt.Rows[0]["nPerCtaCodigo"]);
                        vnCtaCteTipo = Convert.ToInt32(dt.Rows[0]["nPerCtaTipo"]);
                    }
                    else
                    {
                        //Creando PerCuenta
                        if (!ObjPerCta.Ins_PerCuenta(cPerCodigo, nPerCtaTipo, cPerJurCodigo))
                        {
                            throw new ApplicationException("Se encontraron errores al Crear Cuenta Persona. [Ins_PerCuenta].!");
                        }
                        else
                        {
                            dt = ObjPerCta.Get_PerCuenta(cPerCodigo, cPerJurCodigo);
                            if (dt.Rows.Count > 0)
                            {
                                nPerCtaCodigo = Convert.ToInt32(dt.Rows[0]["nPerCtaCodigo"]);
                                vnCtaCteTipo = Convert.ToInt32(dt.Rows[0]["nPerCtaTipo"]);
                            }
                            else
                            {
                                throw new ApplicationException("Se encontro Cuenta Registra Persona. [Get_PerCuenta].!");
                            }
                        }
                    }
                    
                    //Generar New Id Recibo
                    cNroRecibo = Get_NewCorrelativoRecCtaCteItem(cPerJurCodigo);

                    //para CuentaCorriente
                    BE_ReqCuentaCorriente ReqCtaCte = new BE_ReqCuentaCorriente();
                    DA_CuentaCorriente ObjCtaCte = new DA_CuentaCorriente();

                    ReqCtaCte.cCtaCteRecibo = cNroRecibo;
                    ReqCtaCte.nPerCtaCodigo = nPerCtaCodigo;
                    ReqCtaCte.nCtaCteTipo = vnCtaCteTipo;
                    ReqCtaCte.fCtaCteImporte = fCtaCteImporte;
                    ReqCtaCte.nCtaCteCuota = nCtaCteCuota;
                    ReqCtaCte.nCtaCteEstado = 1; //Activo
                    ReqCtaCte.dCtaCteFecVence = dCtaCteFecVence;
                    //ReqCtaCte.dCtaCteFecPago = dCtaCteFecPago; //Para actualizar campo cuando realiza el pago.
                    ReqCtaCte.dCtaCteFecEmis = dCtaCteFecEmis;
                    ReqCtaCte.cCtaCteGlosa = cGlosa;  //"Programación Pago Ficha Atención"; 
                    ReqCtaCte.nPrdCodigo = nPrdCodigo;
                    ReqCtaCte.nMonCodigo = nMonCodigo;  //Periodo actual
                    ReqCtaCte.fCtaCteIgv = 0.18; //fCtaCteIgv;
                    ReqCtaCte.dCtaCteFecProg = dCtaCteFecEmis; //dCtaCteFecProg;
                    ReqCtaCte.cSerDescripcion = ""; //cSerDescripcion;
                    ReqCtaCte.fCtaCteSaldo = 0; //fCtaCteSaldo;

                    if (!ObjCtaCte.Ins_CuentaCorriente(ReqCtaCte))
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: BL-Ins_CuentaCorriente.!");
                    }
                    else exito = true;

                    //------------------------------------------------
                    //Insert Ins_CtaCteDetalle: recorre todo la "List"
                    //------------------------------------------------
                    DA_CtaCteDetalle daCCDet = new DA_CtaCteDetalle();
                    foreach (BE_ReqCtaCteDetalle Item in ReqCCDetalle)
                    {
                        Item.cCtaCteRecibo = cNroRecibo; //Id. Recibo
                        exito = daCCDet.Ins_CtaCteDetalle(Item);
                        if (!exito)
                        {
                            break;
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCteDetalle].!");
                        }
                    }

                    //--------------------------------------------------------------------------------------
                    //Insert CtaCteIntDetalle .- Se aplica cambio para realizar pagos multiples en la Ficha.
                    //--------------------------------------------------------------------------------------
                    DACtaCteIntDetalle daCtaCteIntDetalle = new DACtaCteIntDetalle();
                    foreach (ReqCtaCteIntDetalle Item1 in ObjCtaCteIntDetalle)
                    {
                        Item1.cCtaCteRecibo = cNroRecibo; //Id. Recibo
                        exito = daCtaCteIntDetalle.Ins_CtaCteIntDetalle(Item1);
                        if (!exito)
                        {
                            break;
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCteIntDetalle].!");
                        }
                    }

                    //BLCtaCteIntDetalle Servicio = new BLCtaCteIntDetalle();

                    //if (!Servicio.Ins_CtaCteIntDetalle(cNroRecibo, 0, nIntClase, "", nSolAdmNumero))
                    //{
                    //    throw new ApplicationException("Se encontraron errores en la transaccion: BL-Ins_CtaCteIntDetalle.!");
                    //}

                    //------------------------------------------------
                    //Insert Upd_AdmSolAtencion_by_nSolAdmNumero_nIntCodigo_cPerCodigoTerceros: recorre todo la "List"
                    //------------------------------------------------
                    DA_AdmSolAtencion daUpdAdmSolAtencion = new DA_AdmSolAtencion();

                    foreach (BE_ReqSolAtencion Item2 in ObjAdmSolAtencion)
                    {
                        Item2.cCtaCteRecibo = cNroRecibo; //Id. Recibo
                        exito = daUpdAdmSolAtencion.Upd_AdmSolAtencion_by_nSolAdmNumero_nIntCodigo_cPerCodigoTerceros(Item2);
                        if (!exito)
                        {
                            break;
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Upd_AdmSolAtencion_by_nSolAdmNumero_nIntCodigo_cPerCodigoTerceros].!");
                        }
                    }

                    //-------------------------------------------
                    //Actualizando AdmSolAtencion (cCtaCteRecibo) 
                    //-------------------------------------------
                    //BL_FichaAtencion.BL_FichaAtencion Obj_UpdFichaAtencion = new BL_FichaAtencion.BL_FichaAtencion();

                    //if (!Obj_UpdFichaAtencion.Upd_AdmSolAtencion_by_nSolAdmNumero_nIntCodigo_cPerCodigoTerceros(nSolAdmNumero, nIntCodigo, cPerCodigoTerceros, cNroRecibo, nAdmSolEstado, cPerCodigoAut))
                    //{
                    //    throw new ApplicationException("Se encontraron errores en la transaccion: BL-Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero.!");
                    //}

                    tx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        //-------------------
        // Insert PerCuenta
        //-------------------
        public bool Upd_CuentaCorriente(string cCtaCteRecibo, DateTime dCtaCteFecPago, int nTipoOperacion = 1)
        {
            BE_ReqCuentaCorriente Request = new BE_ReqCuentaCorriente();
            DA_CuentaCorriente Obj = new DA_CuentaCorriente();

            Request.cCtaCteRecibo = cCtaCteRecibo;
            Request.dCtaCteFecPago = dCtaCteFecPago;
            Request.nTipoOperacion = nTipoOperacion; 
           
            return Obj.Upd_CuentaCorriente(Request);
        }

        //-------------------
        // UPdate CuentaCorriente y AdmSolAtencion
        //-------------------
        public bool Upd_CuentaCorriente_And_AdmSolAtencion(string cCtaCteRecibo)
        {
            BE_ReqCuentaCorriente Request = new BE_ReqCuentaCorriente();
            DA_CuentaCorriente Obj = new DA_CuentaCorriente();

            Request.cCtaCteRecibo = cCtaCteRecibo;

            return Obj.Upd_CuentaCorriente_And_AdmSolAtencion(Request);
        }
    }
}
