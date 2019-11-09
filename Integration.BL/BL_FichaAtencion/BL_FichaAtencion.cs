using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.FichaAtencion;
using Integration.DAService;
using Integration.DAService.DA_FichaAtencion;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.BL_FichaAtencion
{
    public class BL_FichaAtencion
    {
        //-----------------------
        // Insert AdmSolAtencion
        //-----------------------
        public bool Ins_AdmSolAtencion(BE_ReqSolAtencion Request)
        {

            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();
            return Obj.Ins_AdmSolAtencion(Request);
        }

        //-----------------------
        // Update AdmSolAtencion
        //-----------------------
        public bool Upd_AdmSolAtencion(BE_ReqSolAtencion Request)
        {

            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();
            return Obj.Upd_AdmSolAtencion(Request);
        }

        //---------------------------
        // Insert DetAdmSolAtencion
        //---------------------------
        public bool Ins_DetAdmSolAtencion(BE_ReqSolAtencion Request)
        {

            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();
            return Obj.Ins_DetAdmSolAtencion(Request);
        }

        //---------------------------
        // Delete DetAdmSolAtencion
        //---------------------------
        public bool Del_DetAdmSolAtencion(string cPerJuridica, int nIntCodigo, string nSolAdmNumero, int nCtaCteSerCodigo){
            bool Resultado = false;

            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.nCtaCteSerCodigo = nCtaCteSerCodigo;

            if (Obj.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero_nCtaCteSerCodigo(Request).Rows.Count  > 0) { 
                Resultado = Obj.Del_DetAdmSolAtencion(Request);
            }

            return Resultado;
        }

        //---------------------------
        // Insert AdmSolDerivacion
        //---------------------------
        public bool Ins_AdmSolDerivacion(BE_ReqSolAtencion Request)
        {

            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();
            return Obj.Ins_AdmSolDerivacion(Request);
        }

        //--------------------
        //Get AdmSolDerivacion
        //--------------------
        public DataTable Get_AdmSolDerivacion(string cPerJuridica, string nSolAdmNumero){
            //Recuperando registros 
            BE_ReqSolAtencion Objeto = new BE_ReqSolAtencion();
            DA_AdmSolAtencion da = new DA_AdmSolAtencion();

            Objeto.cPerJuridica = cPerJuridica;
            Objeto.nSolAdmNumero = nSolAdmNumero;

            return da.Get_AdmSolDerivacion(Objeto);

        }

        //---------------------------
        // Insert AdmSolAtenAutoriza
        //---------------------------
        public bool Ins_AdmSolAtenAutoriza(string cPerJuridica, int nIntCodigo, string nSolAdmNumero, string cPerCodigoAut){
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cPerCodigoAut = cPerCodigoAut;

            return Obj.Ins_AdmSolAtenAutoriza(Request);
        }

        //-----------------------------------------------
        //Obtener Nuevo Id correlativo for AddSolAtencion
        //-----------------------------------------------
        public string Get_NewId_AdmSolAtencion()
        {
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            return Obj.Get_NewId_AdmSolAtencion();

        }

        //-------------------------
        //Get List AdmSolAtencion
        //------------------------
        public DataTable Get_List_AdmSolAtencion(string Flag, string nSolAdmNumero, string cPerIdeNumero, string cPerApellidos, string dFecIni, string dFecFin, string cPerJuridica, string IncluirAnulado, int pnIntCodigo = 0)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.Flag = Flag;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cPerIdeNumero = cPerIdeNumero;
            Request.cPerApellidos= cPerApellidos;
            Request.dFecIni= dFecIni; 
            Request.dFecFin= dFecFin;
            Request.cPerJuridica = cPerJuridica;
            Request.IncluirAnulado = IncluirAnulado;
            Request.nIntCodigo = pnIntCodigo;

            return Obj.Get_List_AdmSolAtencion(Request);

        }

        //-------------------------
        //Get CER
        //------------------------
        public DataTable Get_CER(string dFecIni, string dFecFin)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.dFecIni = dFecIni;
            Request.dFecFin = dFecFin;

            return Obj.Get_CER(Request);
        }

        //-------------------------
        //Get DetAdmSolAtencion
        //------------------------
        public DataTable Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero(string cPerJuridica, string nSolAdmNumero)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nSolAdmNumero = nSolAdmNumero;

            return Obj.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero(Request);

        }

        //--------------------------------------
        //Get List DetAdmSolAtencion - (TICKET)
        //-------------------------------------
        public DataTable Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero_Ticket(string cPerJuridica, string nSolAdmNumero, string cCtaCteRecibo)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cCtaCteRecibo = cCtaCteRecibo;

            return Obj.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero_Ticket(Request);

        }

        //---------------------------
        // Update AdmSolAtencion
        //---------------------------
        public bool Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero(string cPerJuridica, string nSolAdmNumero, string cCtaCteRecibo, int nAdmSolEstado, string cPerCodigoAut)
        {
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cCtaCteRecibo = cCtaCteRecibo;
            Request.nAdmSolEstado = nAdmSolEstado;
            Request.cPerCodigoAut = cPerCodigoAut;

            return Obj.Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero(Request);
        }

        //-----------------------------------------------------------------------------
        // Update Adm Solicitud by_nSolAdmNumero_nIntCodigo_cPerCodigoTerceros (Bloque)
        //-----------------------------------------------------------------------------
        public bool Upd_AdmSolAtencion_by_nSolAdmNumero_nIntCodigo_cPerCodigoTerceros(string nSolAdmNumero, int nIntCodigo, string cPerCodigoTerceros, string cCtaCteRecibo, int nAdmSolEstado, string cPerCodigoAut)
        {
            BE_ReqSolAtencion Objeto = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Objeto.nSolAdmNumero = nSolAdmNumero;
            Objeto.nIntCodigo = nIntCodigo;
            Objeto.cPerCodigoTerceros = cPerCodigoTerceros;
            Objeto.cCtaCteRecibo = cCtaCteRecibo;
            Objeto.nAdmSolEstado = nAdmSolEstado;
            Objeto.cPerCodigoAut = cPerCodigoAut;

            return Obj.Upd_AdmSolAtencion_by_nSolAdmNumero_nIntCodigo_cPerCodigoTerceros(Objeto);
        }


        //--------------------------------------------------------------------------------------------------------------
        // Update Adm Solicitud AdmSolAtencion_by_cPerJuridica_nSolAdmNumero_nAdmSolEstado (Grabar comprobante de Venta)
        //--------------------------------------------------------------------------------------------------------------
        public bool Upd_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero_nAdmSolEstado(string cPerJuridica, string nSolAdmNumero, string cPerCodigoAut)
        {
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cPerCodigoAut = cPerCodigoAut;

            return Obj.Upd_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero_nAdmSolEstado(Request);
        }

        //-----------------------------------------------
        //Obtener cPerCodigo de "AdmSolAtenAutoriza"
        //-----------------------------------------------
        public string Get_AdmSolAtenAutoriza(string cPerJuridica, int nIntCodigo, string nSolAdmNumero)
        {
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.nSolAdmNumero = nSolAdmNumero;

            return Obj.Get_AdmSolAtenAutoriza(Request);

        }

        //-------------------------
        // Insert AdmSolDiagnostico
        //-------------------------
        public bool Ins_AdmSolDiagnostico(string cPerJuridica, int nIntCodigo, string nSolAdmNumero, string cDiagCodigo)
        {
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cDiagCodigo = cDiagCodigo;

            return Obj.Ins_AdmSolDiagnostico(Request);
        }

        //-------------------------
        // Delete AdmSolDiagnostico
        //-------------------------
        public bool Del_AdmSolDiagnostico(string cPerJuridica, int nIntCodigo, string nSolAdmNumero, string cDiagCodigo)
        {
            bool Resultado = false;

            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cDiagCodigo = cDiagCodigo;

            if (Obj.Get_AdmSolDiagnostico_for_cPerJuridica_nSolAdmNumero_cDiagCodigo(Request).Rows.Count > 0)
            {
                Resultado = Obj.Del_AdmSolDiagnostico(Request);
            }
            return Resultado;
        }

        //-------------------------
        //Get DetAdmSolAtencion
        //------------------------
        public DataTable Get_AdmSolDiagnostico_for_cPerJuridica_nIntCodigo_nSolAdmNumero(string cPerJuridica, int nIntCodigo, string nSolAdmNumero)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.nSolAdmNumero = nSolAdmNumero;

            return Obj.Get_AdmSolDiagnostico_for_cPerJuridica_nIntCodigo_nSolAdmNumero(Request);

        }

        //---------------------------
        // Insert AdmSolListaEmpleado
        //---------------------------
        public bool Ins_Upd_AdmSolListaEmpleado(string cPerJuridica, int nIntCodigo, string cPerCodigoTerceros, string nSolAdmNumero, string cPerCodigo)
        {
            bool Resultado = false;

            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.cPerCodigoTerceros = cPerCodigoTerceros;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cPerCodigo = cPerCodigo;

            if (!Obj.Ins_Upd_AdmSolListaEmpleado(Request))
            {
                throw new ApplicationException("Se encontraron errores en la transaccion: [Insert/Update: AdmSolListaEmpleado].!");
            }
            else {
                Resultado = true; 
            }

            return Resultado;
        }

        //---------------------------
        // Delete AdmSolListaEmpleado
        //---------------------------
        public bool Del_AdmSolListaEmpleado(string cPerJuridica, int nIntCodigo, string cPerCodigoTerceros, string nSolAdmNumero, string cPerCodigo)
        {
            bool Resultado = false;

            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.cPerCodigoTerceros = cPerCodigoTerceros;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cPerCodigo = cPerCodigo;

            if (Obj.Get_AdmSolListaEmpleado_by_cPerJuridica_nIntCodigo_cPerCodigoTerceros_nSolAdmNumero(Request).Rows.Count > 0)
            {
                Resultado = Obj.Del_AdmSolListaEmpleado(Request);
            }

            return Resultado;
        }

        //--------------------------------------------------------------------------------------------
        //Get List AdmSolListaEmpleado for cPerJuridica, nIntCodigo, cPerCodigoTerceros, nSolAdmNumero
        //--------------------------------------------------------------------------------------------
        public DataTable Get_AdmSolListaEmpleado_by_cPerJuridica_nIntCodigo_cPerCodigoTerceros_nSolAdmNumero(string cPerJuridica, int nIntCodigo, string cPerCodigoTerceros, string nSolAdmNumero)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.cPerCodigoTerceros = cPerCodigoTerceros;
            Request.nSolAdmNumero = nSolAdmNumero;

            return Obj.Get_AdmSolListaEmpleado_by_cPerJuridica_nIntCodigo_cPerCodigoTerceros_nSolAdmNumero(Request);

        }

        //-----------------------------------------------------------------------
        //Get List AdmSolAtencion by cPerJuridica, nSolAdmNumero y cPercodigo
        //-----------------------------------------------------------------------
        public DataTable Get_Cab_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero_cPerCodigo(string cPerJuridica, string nSolAdmNumero, string cPerCodigo)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cPerCodigo = cPerCodigo;

            return Obj.Get_Cab_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero_cPerCodigo(Request);

        }

        //-----------------------------------------------------------
        //Get Detalle AdmSolAtencion by cPerJuridica y nSolAdmNumero 
        //-----------------------------------------------------------
        public DataTable Get_Det_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero(string cPerJuridica, string nSolAdmNumero)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nSolAdmNumero = nSolAdmNumero;

            return Obj.Get_Det_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero(Request);

        }


        //--------------------------------
        // Insert Adm Solicitud Auditoria
        //--------------------------------
        public bool Ins_AdmSolAtenAuditoria(BE_ReqSolAtencion Objeto)
        {
            bool Resultado = false;
            DA_AdmSolAtencion Servicio = new DA_AdmSolAtencion();

            if (!Servicio.Ins_AdmSolAtenAuditoria(Objeto))
            {
                throw new ApplicationException("Se encontraron errores en la transaccion: [Insert/Update: AdmSolListaEmpleado].!");
            }
            else
            {
                Resultado = true;
            }

            return Resultado;
        }


        //-------------------------------------------------------------
        //Lista Muestras agrupado por Fichas (Lab. Externo / Convenios)
        //-------------------------------------------------------------
        public DataTable Get_AdmSolAtencion_by_nIntCodigo_and_cPerCodigoTerceros_and_fecha(int nIntCodigo, string cPerCodigoTerceros, DateTime FecIni, DateTime FecFin, string Flag="F")
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.nIntCodigo = nIntCodigo;
            Request.cPerCodigoTerceros = cPerCodigoTerceros;
            Request.FecIni = FecIni;
            Request.FecFin = FecFin;
            Request.Flag  = Flag;

            return Obj.Get_AdmSolAtencion_by_nIntCodigo_and_cPerCodigoTerceros_and_fecha(Request);

        }


        public DataTable Get_Estructura_Export_LIS(string nSolAdmNumero)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.nSolAdmNumero = nSolAdmNumero;

            return Obj.Get_Estructura_Export_LIS(Request);

        }

        //-----------------------------------------------
        // Update AdmSolAtencion cuando se Migra OK a LIS
        //-----------------------------------------------
        public bool Upd_AdmSolAtencion_Export_LIS(BE_ReqSolAtencion Request)
        {

            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();
            return Obj.Upd_AdmSolAtencion_Export_LIS(Request);
        }

        //Implementacion 2016-07-18
        //Obtener Datos Facturación por AdmSolAtencion (cPerCodigoTerceros)
        public DataTable Get_Datos_Facturacion_Laboratorio_Or_Convenio_by_nSolAdmNumero(string nSolAdmNumero)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Objeto = new BE_ReqSolAtencion();
            DA_AdmSolAtencion da_AdmSolAtencion = new DA_AdmSolAtencion();

            Objeto.nSolAdmNumero = nSolAdmNumero;

            return da_AdmSolAtencion.Get_Datos_Facturacion_Laboratorio_Or_Convenio_by_nSolAdmNumero(Objeto);

        }

        //-------------------------------------------------------------
        // Update AdmSolAtencion al Emitir "Nota Credito" por Anulación
        //-------------------------------------------------------------
        public bool Update_AdmSolAtencion_By_NotaCreditoAnulacion(string cCtaCteRecibo) {
            DA_AdmSolAtencion admSolAtencionDAO = new DA_AdmSolAtencion();
            return admSolAtencionDAO.Update_AdmSolAtencion_By_NotaCreditoAnulacion(cCtaCteRecibo);
        }

        //-----------------------
        // Update AdmSolAtencion - CER- Control Entrega Resultados
        //-----------------------
        public bool Update_AdmSolAtencion_CER(string nSolAdmNumero, string cFlag, int month =0, int days=0, int hours=0, int minute=0)
        {
            DA_AdmSolAtencion admSolAtencionDAO = new DA_AdmSolAtencion();
            return admSolAtencionDAO.Update_AdmSolAtencion_CER(nSolAdmNumero,  cFlag,  month,  days,  hours,  minute);
        }

        //-------------------------------
        //Get Pruebas según Nº de Ficha
        //-------------------------------
        public DataTable Get_Pruebas_By_nSolAdmNumero(string pnSolAdmNumero)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.nSolAdmNumero = pnSolAdmNumero;

            return Obj.Get_Pruebas_By_nSolAdmNumero(Request);

        }
    }
}
