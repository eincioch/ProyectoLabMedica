using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Web.Services.Protocols;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using Integration.BL;
using Integration.BL.GestionarAdmSolPerTokenServicio;
using Integration.BL.BL_Reportes;
using Integration.BL.BL_Android;

using Integration.BE.Android;
using Integration.BE.PerUsuario;

using Integration.BE.AdmSolPerToken ;
using Integration.Conection;
using Integration.DataIntegration;
using ServiceWebAplicacion.bean;


namespace ServiceWebAplicacion
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://medica.net/SecureWebService/SecureWebService")]

    //[WebService(Namespace = "http://tempuri.org/SecureWebService/SecureWebService")] 

    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSMedicaApp :  ServicioSeguro  //System.Web.Services.WebService
    {             

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public string HelloWorld()
        {
            if (VerificarPermisos(CredencialAutenticacion))
            {
                return "Bienvenidos soy un WebService Médica.";
            }
            else
            {
                return "Credenciales no validas";
            }
        }

        //Acceso a WS
        public static Boolean VerificarPermisos(Autenticacion value)
        {
            CredencialWS credencial = new CredencialWS();

            if (value == null)
            {
                return false;
            }
            else
            {
                //Verifica los permiso Ej. Consulta a BD 
                if (value.UsuarioNombre == credencial.UsuarioNombre  && value.UsuarioClave == credencial.UsuarioClave )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public String GenerarKeyToken(string cPerUsuCodigo, string cPerJurCodigo, string nTipo, string fPorcentaje)
        {
            string cKeyToken = "";

            if (VerificarPermisos(CredencialAutenticacion))
            {
                AdmSolPerToken objeto = new AdmSolPerToken();
                GestionarAdmSolPerTokenServicio Servicio = new GestionarAdmSolPerTokenServicio();

                objeto.cPerUsuCodigo = cPerUsuCodigo;
                objeto.cPerJurCodigo = cPerJurCodigo;
                objeto.nTipo = Convert.ToInt32(nTipo);
                if (fPorcentaje == "")
                    objeto.fPorcentaje = 0;
                else
                    objeto.fPorcentaje = Convert.ToDouble(fPorcentaje);
                objeto.nFlag = 0; //default sin utilizar token

                cKeyToken = Servicio.Android_ADMISION_SET_TOKEN_DCTOS_OR_CORTESIA(objeto);
            }
            else
            {
                cKeyToken = "Credenciales no validas.";
            }
            return cKeyToken;

        }

        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Bienvenidos soy un WebService Médica.";
        //}

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        //public String LoginUsuario(String user, String password)
        public Login[] LoginUsuario(String user, String password)
        {
            //string msje = "";

            List<Login> login = new List<Login>();
            //Autenticacion auten = new Autenticacion();

            //auten.UsuarioNombre = UsuarioNombre;
            //auten.UsuarioClave = UsuarioClave;

            if (VerificarPermisos(CredencialAutenticacion))
            {
                
                clsCrypt ObjEncrypt = new clsCrypt();

                BE_ReqSearhUsuario objeto = new BE_ReqSearhUsuario();
                BL_PerUsuario BLPer = new BL_PerUsuario();

                //primero de convierte a mayusculas
                string Usuario = user.ToUpper();
                string SrtPass = ObjEncrypt.EncryptByCode(Usuario, password);

                //luego se quitan los espacios
                objeto.PerCodigo = Usuario.Trim();
                objeto.cPerUsuClave = SrtPass;
                objeto.cModulo = "27"; //27-> Modulo Android

                DataTable dt = new DataTable();

                //dt = BLPer.Get_Persona_By_Usuario(objeto);

                dt = BLPer.Android_Get_Persona_By_Usuario(objeto);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    if (row["cClave"].ToString() == SrtPass)
                        //Si todo va bien 
                        login.Add(new Login(
                                Convert.ToString(row[0]), 
                                Convert.ToString(row[1]), 
                                Convert.ToString(row[2]),
                                Convert.ToString(row[3]),
                                Convert.ToDouble(row[4])
                        ));
                    else
                        //msje = "Error, Usuario no existe o datos incorrectos";
                        login.Add(new Login("Contraseña incorrecta.", "", "","",0.0));
                    
                }
                else
                    //msje = "Error, Usuario no existe o datos incorrectos";
                    login.Add(new Login("Usuario no registrado.", "", "", "", 0.0));
            }
            else
            {
                login.Add(new Login("Credenciales no validas.", "", "", "", 0.0));
                //msje = "Credenciales no validas.";
            }
            //return msje;
            return login.ToArray();
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public Login[] LoginUsuarioRequest(BE_ReqCredencialesAndroid Object)
        {
            //string msje = "";

            List<Login> login = new List<Login>();

            if (VerificarPermisos(CredencialAutenticacion)){

                clsCrypt ObjEncrypt = new clsCrypt();

                BE_ReqSearhUsuario objeto = new BE_ReqSearhUsuario();
                BL_PerUsuario BLPer = new BL_PerUsuario();

                //primero de convierte a mayusculas
                string Usuario = Object.PerCodigo.ToUpper(); //user.ToUpper();
                string Password = Object.cPerUsuClave;
                string SrtPass = ObjEncrypt.EncryptByCode(Usuario, Password);

                //luego se quitan los espacios
                objeto.PerCodigo = Usuario.Trim();
                objeto.cPerUsuClave = SrtPass;
                objeto.cModulo = "27"; //27-> Modulo Android

                DataTable dt = new DataTable();

                //dt = BLPer.Get_Persona_By_Usuario(objeto);

                dt = BLPer.Android_Get_Persona_By_Usuario(objeto);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    if (row["cClave"].ToString() == SrtPass)
                        //Si todo va bien 
                        login.Add(new Login(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToString(row[2]),
                                Convert.ToString(row[3]),
                                Convert.ToDouble(row[4])
                        ));
                    else
                        //msje = "Error, Usuario no existe o datos incorrectos";
                        login.Add(new Login("Contraseña incorrecta.", "", "", "", 0.0));

                }
                else
                    //msje = "Error, Usuario no existe o datos incorrectos";
                    login.Add(new Login("Usuario no registrado.", "", "", "", 0.0));
            }
            else
            {
                login.Add(new Login("Credenciales no válidas.", "", "", "", 0.0));
                //msje = "Credenciales no validas.";
            }

            //return msje;
            return login.ToArray();
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public Ventas[] VerVentas(string cPerJuridica, string FecIni, string FecFin)
        {
            try
            {
                List<Ventas> lista = new List<Ventas>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLRptMaster Servicio = new BLRptMaster();
                    DataTable dt = new DataTable();

                    dt = Servicio.Get_Venta_by_cPerJurCodigo_and_fecini_fecfin_01(cPerJuridica, FecIni, FecFin); // "2015/12/10'", "2015/12/10'");

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new Ventas(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToInt32(row[2]),
                                Convert.ToInt32(row[3]),
                                Convert.ToDouble(row[4]),
                                Convert.ToDouble(row[5]),
                                Convert.ToString(row[6]),
                                Convert.ToDouble(row[7]),
                                Convert.ToDouble(row[8]),
                                Convert.ToDouble(row[9]),
                                Convert.ToDouble(row[10]),
                                Convert.ToDouble(row[11]),
                                Convert.ToDouble(row[12]),
                                Convert.ToDouble(row[13]),
                                Convert.ToDouble(row[14]),
                                Convert.ToDouble(row[15]) //Update 2016-04-13
                            ));
                    }
                }
                else
                {
                    return null;
                }
                return lista.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no validas.",   
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public DetVentaTipoAtencion[] VerDetalleVentaTipoAtencion(string paramcPerJuridica, string paramFecIni, string paramFecFin, string paramnflagFiltro, string paramnFlag)
        {
            try
            {
                List<DetVentaTipoAtencion> listaVentaTipoAtencion = new List<DetVentaTipoAtencion>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLRptMaster Servicio = new BLRptMaster();
                    DataTable dt = new DataTable();

                    dt = Servicio.Get_Android_Detalle_Saldo_Venta_by_fecini_fecfin_Group_cPerCodigo(paramcPerJuridica, paramFecIni, paramFecFin, paramnflagFiltro, paramnFlag); 

                    foreach (DataRow row in dt.Rows)
                    {
                        listaVentaTipoAtencion.Add(new DetVentaTipoAtencion(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToInt32(row[2]),
                                Convert.ToString(row[3]),
                                Convert.ToInt32(row[4]),
                                Convert.ToDouble(row[5]),
                                Convert.ToDouble(row[6])
                            ));
                    }
                }
                else
                {
                    return null;
                }
                return listaVentaTipoAtencion.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no validas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public DetVentaLaboratorioConvenio[] VerDetalleVentaLaboratorioConvenio(string paramcPerJuridica, string paramFecIni, string paramFecFin, string paramnflagFiltro, string paramnFlag)
        {
            try
            {
                List<DetVentaLaboratorioConvenio> listaVentaLabConv = new List<DetVentaLaboratorioConvenio>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLRptMaster Servicio = new BLRptMaster();
                    DataTable dt = new DataTable();

                    dt = Servicio.Get_Android_Detalle_Saldo_Venta_by_fecini_fecfin_Group_cPerCodigo(paramcPerJuridica, paramFecIni, paramFecFin, paramnflagFiltro, paramnFlag);

                    foreach (DataRow row in dt.Rows)
                    {
                        listaVentaLabConv.Add(new DetVentaLaboratorioConvenio(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToInt32(row[2]),
                                Convert.ToString(row[3]),
                                Convert.ToString(row[4]),
                                Convert.ToString(row[5]),
                                Convert.ToInt32(row[6]),
                                Convert.ToDouble(row[7]),
                                Convert.ToDouble(row[8])
                            ));
                    }
                }
                else
                {
                    return null;
                }
                return listaVentaLabConv.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no validas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public  DetVentaPendientePorCobrar[] VerDetalleVentaPendientePorCobrar(string paramcPerJuridica, string paramFecIni, string paramFecFin, string paramnflagFiltro, string paramnFlag)
        {
            try
            {
                List<DetVentaPendientePorCobrar> listaVentaPendientes = new List<DetVentaPendientePorCobrar>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLRptMaster Servicio = new BLRptMaster();
                    DataTable dt = new DataTable();

                    dt = Servicio.Get_Android_Detalle_Saldo_Venta_by_fecini_fecfin_Group_cPerCodigo(paramcPerJuridica, paramFecIni, paramFecFin, paramnflagFiltro, paramnFlag);

                    foreach (DataRow row in dt.Rows)
                    {
                        listaVentaPendientes.Add(new DetVentaPendientePorCobrar(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToString(row[2]),
                                Convert.ToString(row[3]),
                                Convert.ToDouble(row[4]),
                                Convert.ToDouble(row[5]),
                                Convert.ToDouble(row[6])
                            ));
                    }
                }
                else
                {
                    //return null;
                    listaVentaPendientes.Add(new DetVentaPendientePorCobrar("Credenciales no validas", "Credenciales no validas", "", "", 0, 0, 0));
                }
                return listaVentaPendientes.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no validas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public ComisionDoctor[] VerComisionMedico(string FecIni, string FecFin, string cPerUsuCodigo, string nFlagTodos="0", string cTipo="R", string cPerCodMedico="")
        {
            try
            {
                List<ComisionDoctor> listaComisionMedico = new List<ComisionDoctor>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLRptMaster Servicio = new BLRptMaster();
                    DataTable dt = new DataTable();

                    dt = Servicio.Android_Comisiones_By_Promotor(FecIni, FecFin, cPerUsuCodigo, Convert.ToInt32(nFlagTodos), cTipo, cPerCodMedico); 

                    foreach (DataRow row in dt.Rows)
                    {
                        listaComisionMedico.Add(new ComisionDoctor(
                                                Convert.ToString(row[0]),
                                                Convert.ToString(row[1]),
                                                Convert.ToInt32(row[2]),
                                                Convert.ToInt32(row[3]),
                                                Convert.ToDouble(row[4]),
                                                Convert.ToInt32(row[5])
                            ));
                    }   
                }
                else
                {
                    listaComisionMedico.Add(new ComisionDoctor("Credenciales no validas", "Credenciales no validas", 0, 0, 0.0,0));
                }

                return listaComisionMedico.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Ha ocurrido un error!.",
                     SoapException.ServerFaultCode, "Error:", ex );
            }
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public Medico[] VerHistorialMedico(string ApeDoctor, string FecIni, string FecFin)
        {
            try
            {
                List<Medico> listMedico = new List<Medico>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLRptMaster Servicio = new BLRptMaster();
                    DataTable dt = new DataTable();

                    dt = Servicio.Android_Get_Medico_and_comision(ApeDoctor,FecIni, FecFin);

                    foreach (DataRow row in dt.Rows)
                    {
                        listMedico.Add(new Medico(
                                                Convert.ToString(row[0]),
                                                Convert.ToString(row[1]),
                                                Convert.ToDouble(row[2])
                            ));
                    }
                }
                else
                {
                    listMedico.Add(new Medico("Credenciales no validas", "Credenciales no validas", 0));
                }

                return listMedico.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Ha ocurrido un error!.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public DetalleHistorialComision[] VerHistorialMedicoDetalle(string cPerCodigo, string FecIni, string FecFin)
        {
            try
            {
                List<DetalleHistorialComision> listMedico = new List<DetalleHistorialComision>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLRptMaster Servicio = new BLRptMaster();
                    DataTable dt = new DataTable();

                    dt = Servicio.Android_Get_Medico_and_comision_Detalle(cPerCodigo, FecIni, FecFin);

                    foreach (DataRow row in dt.Rows)
                    {
                        listMedico.Add(new DetalleHistorialComision(
                                                Convert.ToInt32(row[0]),
                                                Convert.ToString(row[1]),
                                                Convert.ToString(row[2]),
                                                Convert.ToDouble(row[3])
                            ));
                    }
                }
                else
                {
                    listMedico.Add(new DetalleHistorialComision(0,"Credenciales no validas", "Credenciales no validas", 0.0));
                }

                return listMedico.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Ha ocurrido un error!.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public DetalleComisionMedico[] VerDetalleComisionMedico(string FecIni, string FecFin, string cPerUsuCodigo, string nFlagTodos = "0", string cTipo = "D", string cPerCodMedico = "", string nFlagComision = "1")
        {
            try
            {
                List<DetalleComisionMedico> detalleComisionMedicos = new List<DetalleComisionMedico>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLRptMaster Servicio = new BLRptMaster();
                    DataTable dt = new DataTable();

                    dt = Servicio.Android_Comisiones_By_Promotor(FecIni, FecFin, cPerUsuCodigo, Convert.ToInt32(nFlagTodos), cTipo, cPerCodMedico, Convert.ToInt32(nFlagComision));

                    foreach (DataRow row in dt.Rows)
                    {
                        detalleComisionMedicos.Add(new DetalleComisionMedico(
                                                Convert.ToString(row[0]),
                                                Convert.ToString(row[1]),
                                                Convert.ToDouble(row[2]),
                                                Convert.ToInt32(row[3])
                            ));
                    }
                }
                else
                {
                    detalleComisionMedicos.Add(new DetalleComisionMedico("Credenciales no validas", "Credenciales no validas", 0.0,0));
                }

                return detalleComisionMedicos.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Ha ocurrido un error!.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }
        
        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public Promotor[] ListarPromotor(string cOpcion = "")
        {
            try
            {
                List<Promotor> promotors = new List<Promotor>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BL_Promotor Servicio = new BL_Promotor();
                    DataTable dt = new DataTable();

                    dt = Servicio.Android_Get_Promotor(cOpcion);

                    foreach (DataRow row in dt.Rows)
                    {
                        promotors.Add(new Promotor(
                                                Convert.ToString(row[0]),
                                                Convert.ToString(row[1])
                            ));
                    }
                }
                else
                {
                    promotors.Add(new Promotor("Credenciales no validas", "Credenciales no validas"));
                }

                return promotors.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Ha ocurrido un error!.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public String RegistraEncuestaMovilVta(string cPerJurCodigo, string cPerPromotorCodigo, string cPerAsigCodigo, string cMedicoNoRegistra,
                                                string nRespuesta01, string nRespuesta02, string nRespuesta03, string nRespuesta04, string nRespuesta05,
                                                string nObservacion, string cUserReg,
                                                string platitub, string plongitub)
        {

            string mensaje = "";
            Boolean exito;

            if (VerificarPermisos(CredencialAutenticacion))
            {
                //Insert
                tb_encuesta_movil objeto = new tb_encuesta_movil();
                BL_EncuestaMovil servicio = new BL_EncuestaMovil();

                objeto.cPerJurCodigo = cPerJurCodigo;
                objeto.cPerPromotorCodigo = cPerPromotorCodigo;

                objeto.cPerAsigCodigo = cPerAsigCodigo;
                objeto.cMedicoNoRegistra = cMedicoNoRegistra;

                objeto.nRespuesta01 = Convert.ToInt16(nRespuesta01);
                objeto.nRespuesta02 = Convert.ToInt16(nRespuesta02);
                objeto.nRespuesta03 = Convert.ToInt16(nRespuesta03);
                objeto.nRespuesta04 = Convert.ToInt16(nRespuesta04);
                objeto.nRespuesta05 = Convert.ToInt16(nRespuesta05);
                objeto.nObservacion = nObservacion;
                objeto.cUserReg = cUserReg;
                objeto.platitub = Convert.ToDouble(platitub);
                objeto.plongitub = Convert.ToDouble(plongitub);


                exito = servicio.Android_Insert_EncuestaMovil(objeto);

                if (!exito)
                {
                    mensaje = "Ha ocurrido un error.";
                }
                else
                {
                    mensaje = "Encuesta ha sido enviada con éxito.!";
                }
            }
            else
            {
                mensaje = "Credenciales no validas.";
            }

            return mensaje;
        }
        
        //----------------------------------------
        // Android: Opciones Venta Según Atención
        //----------------------------------------
        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public VentaNeta[] VerVentasNeta(string cPerJuridica, string FecIni, string FecFin)
        {
            try
            {
                List<VentaNeta> lista = new List<VentaNeta>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLRptMaster Servicio = new BLRptMaster();
                    DataTable dt = new DataTable();

                    dt = Servicio.Get_Android_Venta_Neta_by_cPerJurCodigo_and_fecini_fecfin(cPerJuridica, FecIni, FecFin);

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new VentaNeta(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToDouble(row[2]),
                                Convert.ToDouble(row[3])
                            ));
                    }
                }
                else
                {
                    //return null;
                    lista.Add(new VentaNeta("", "Credenciales no validas", 0, 0));
                }
                return lista.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no validas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public VentaSucursalTurno[] GetVentaSucursalTurno(string cPerJuridica, string cFechaIni, string cFechaFin)
        {
            try
            {
                List<VentaSucursalTurno> ventaSucursalTurno = new List<VentaSucursalTurno>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLRptMaster Servicio = new BLRptMaster();
                    DataTable dt = new DataTable();

                    dt = Servicio.Get_Ventas_Group_cPerJur_Turno_TipoAtencion_by_Fechas(cPerJuridica, cFechaIni, cFechaFin);

                    foreach (DataRow row in dt.Rows)
                    {
                        ventaSucursalTurno.Add(new VentaSucursalTurno(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToString(row[2]),
                                Convert.ToDouble(row[3]),
                                Convert.ToDouble(row[4]),
                                Convert.ToDouble(row[5])
                            ));
                    }
                }
                else
                {
                    //return null;
                    ventaSucursalTurno.Add(new VentaSucursalTurno("", "Credenciales no validas", "", 0.0,0.0, 0.0));
                }
                return ventaSucursalTurno.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no validas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }



        //----------------------------------------
        // Android: Opciones Venta por Promotor
        //----------------------------------------
        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public VentaPromotor[] VerVentasPromotor(string cFlag, string cFecIni, string cFecFin, string cPerPromCodigo)
        {
            try
            {
                List<VentaPromotor> lista = new List<VentaPromotor>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLRptMaster Servicio = new BLRptMaster();
                    DataTable dt = new DataTable();

                    dt = Servicio.Get_Android_MetaPromotor_Avance_By_Promotor(cFlag, cFecIni, cFecFin, cPerPromCodigo);

                    foreach (DataRow row in dt.Rows)
                    {
                            lista.Add(new VentaPromotor(
                                    Convert.ToString(row[10]),    
                                    Convert.ToString(row[1]),
                                    Convert.ToDouble(row[4]),
                                    Convert.ToDouble(row[5]),
                                    Convert.ToDouble(row[8]),
                                    Convert.ToDouble(row[9]),
                                    Convert.ToString(row[11]),
                                    Convert.ToString(row[0]),
                                    Convert.ToInt32(row[12]),
                                    Convert.ToString(row[13])
                                ));
                    }
                }
                else
                {
                    //return null;
                    lista.Add(new VentaPromotor("", "Credenciales no validas", 0, 0, 0, 0, "", "", 0, ""));
                }
                return lista.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no validas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }


    }
}
