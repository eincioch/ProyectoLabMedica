using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

using Integration.BE.Interface;
using Integration.BE.Reportes;
using Integration.BE.FichaAtencion;
using Integration.DAService.DA_Persona;


namespace Integration.BL.BL_Reportes
{
    public class BLRptMaster
    {

        //--------------------------------------------------------------------------
        // en SqlDataReader: Obtiene List Reporte Admision por Permisos PerUsuGruAcc
        //--------------------------------------------------------------------------
        public List<BE_Res_Interface> Get_List_Report_by_cIntJerarquia_and_cPerCodigo(ReqRptParametros Request)
        {

            DARptMaster Obj = new DARptMaster();
            return Obj.Get_List_Report_by_cIntJerarquia_and_cPerCodigo(Request);

        }

        //-------------------------------------------------------------------
        // Comsión Doctores usp_Get_ComisionMedico_by_cPerJuridica_cPerMedico
        //-------------------------------------------------------------------
        public DataTable Get_ComisionMedico_by_cPerJuridica_cPerMedico(string cPerJuridica, string cPerCodMedico, DateTime dFecIni, DateTime dFecFin, string nFlag ="G", string cPerCodPromotor = "")
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cPerJuridica = cPerJuridica;
            Request.cPerCodMedico = cPerCodMedico;
            Request.dFecIni = dFecIni;
            Request.dFecFin = dFecFin;
            

            Request.nFlag  = nFlag;
            Request.cPerCodPromotor = cPerCodPromotor;

            return Obj.Get_ComisionMedico_by_cPerJuridica_cPerMedico(Request);

        }

        //-------------------------------------
        // Ingresos por Laboratorio y Convenios
        //-------------------------------------
        public DataTable Get_Ingresos_LabExt_Convenio_by_rango_fechas(DateTime dFecIni, DateTime dFecFin, string nFlag = "P")
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.dFecIni = dFecIni;
            Request.dFecFin = dFecFin;
            Request.nFlag = nFlag;

            return Obj.Get_Ingresos_LabExt_Convenio_by_rango_fechas(Request);

        }

        //---------------------------------------------------------------------------------------
        // Detalle Importe Derivacion Get_Derivacion_Medico_by_cPerCodMedico_and_dFecIni_dFecFin
        //---------------------------------------------------------------------------------------
        public DataTable Get_Derivacion_Medico_by_cPerCodMedico_and_dFecIni_dFecFin(string cPerCodMedico, DateTime dFecIni, DateTime dFecFin)
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cPerCodMedico = cPerCodMedico;
            Request.dFecIni = dFecIni;
            Request.dFecFin = dFecFin;

            return Obj.Get_Derivacion_Medico_by_cPerCodMedico_and_dFecIni_dFecFin (Request);

        }


        //-------------------------------------------------------------------
        // Reporte por Sucursal y Rango de fechas
        //-------------------------------------------------------------------
        public DataTable Get_Venta_by_cPerJurCodigo_and_fecini_fecfin(string cPerJurCodigo, DateTime dFecIni, DateTime dFecFin)
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cPerJuridica = cPerJurCodigo;
            Request.dFecIni = dFecIni;
            Request.dFecFin = dFecFin; 

            return Obj.Get_Venta_by_cPerJurCodigo_and_fecini_fecfin(Request);

        }

        //-------------------------------------------------------------------
        // Reporte por Sucursal según Fecha de Atención
        //-------------------------------------------------------------------
        public DataTable Get_Venta_by_cPerJurCodigo_and_FechaAtencion(string cPerJurCodigo, string cFecIni, string cFecFin)
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cPerJuridica = cPerJurCodigo;
            Request.cFecIni = cFecIni;
            Request.cFecFin = cFecFin;

            return Obj.Get_Venta_by_cPerJurCodigo_and_FechaAtencion(Request);

        }

        //------------------------------------------------------------------------------
        // Reporte por Sucursal según Fecha de Atención y agrupado por Tipo de Atención
        //------------------------------------------------------------------------------
        public DataTable Get_Detalle_Venta_by_Tipo_FechaAtencion_Group_cPerJurCodigo(string cPerJurCodigo, string cFecIni, string cFecFin, string cFlagFiltro)
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cPerJuridica = cPerJurCodigo;
            Request.cFecIni = cFecIni;
            Request.cFecFin = cFecFin;
            Request.nFlagFiltro = cFlagFiltro;

            return Obj.Get_Detalle_Venta_by_Tipo_FechaAtencion_Group_cPerJurCodigo(Request);

        }


        //-------------------------------------------------------------------
        // Detalle de Saldos agrupado por Clientes y filtro por Rango de fechas
        //-------------------------------------------------------------------
        public DataTable Get_Detalle_Saldo_Venta_by_fecini_fecfin_Group_cPerCodigo(string cPerJurCodigo, string cFecIni, 
                                                                                        string cFecFin, string nflagFiltro, string nflag) 
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cPerJuridica = cPerJurCodigo;
            Request.cFecIni = cFecIni;
            Request.cFecFin = cFecFin;

            Request.nFlagFiltro = nflagFiltro;
            Request.nFlag = nflag;

            return Obj.Get_Detalle_Saldo_Venta_by_fecini_fecfin_Group_cPerCodigo(Request); 

        }

        //---------------------------------------------------------------------------------
        // Detalle de Saldos agrupado por Clientes y filtro por Rango de fechas for Android
        //---------------------------------------------------------------------------------
        public DataTable Get_Android_Detalle_Saldo_Venta_by_fecini_fecfin_Group_cPerCodigo(string cPerJurCodigo, string cFecIni,
                                                                                        string cFecFin, string nflagFiltro, string nflag)
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cPerJuridica = cPerJurCodigo;
            Request.cFecIni = cFecIni;
            Request.cFecFin = cFecFin;

            Request.nFlagFiltro = nflagFiltro;
            Request.nFlag = nflag;

            return Obj.Get_Android_Detalle_Saldo_Venta_by_fecini_fecfin_Group_cPerCodigo(Request);

        }

        //-------------------------------------------------------------------
        // Reporte por Sucursal y Rango de fechas en TEXTO (by App Android)
        //-------------------------------------------------------------------
        public DataTable Get_Venta_by_cPerJurCodigo_and_fecini_fecfin_01(string cPerJurCodigo, string cFecIni, string cFecFin)
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster(); 

            Request.cPerJuridica = cPerJurCodigo;
            Request.cFecIni = cFecIni;
            Request.cFecFin = cFecFin;

            return Obj.Get_Venta_by_cPerJurCodigo_and_fecini_fecfin_01(Request);

        }

        //------------------ 2016-06-09 ------------------------
        // Ver Comision Medico por Promotor for (App ANDROID) -EINCIO
        //------------------------------------------------------
        public DataTable Android_Comisiones_By_Promotor(string FecIni, string FecFin, string cPerUsuCodigo, int nFlagTodos = 0, string cTipo = "R", string cPerCodMedico = "", Int32 nFlagComision =1)
        {
            
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cFecIni = FecIni;
            Request.cFecFin = FecFin;
            Request.cPerUsuCodigo = cPerUsuCodigo;
            Request.nFlagTodos = nFlagTodos;
            Request.cTipo = cTipo;
            Request.cPerCodMedico = cPerCodMedico;
            Request.nFlagComision = nFlagComision;

            //Recuperando...
            return Obj.Android_Comisiones_By_Promotor(Request);  

        }

        //------------------ 2017-01-24 ------------------------
        // Ver Comision Medico por Promotor for (App ANDROID) -EINCIO
        //------------------------------------------------------
        public DataTable Android_Get_Medico_and_comision(string ApeDoctor, string FecIni, string FecFin)
        {

            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cApeDoctor = ApeDoctor;
            Request.cFecIni = FecIni;
            Request.cFecFin = FecFin;
            
            //Recuperando...
            return Obj.Android_Get_Medico_and_comision(Request); 

        }

        //------------------ 2017-03-03 ------------------------
        // Ver Historial Medico Detalle for (App ANDROID) -EINCIO
        //------------------------------------------------------
        public DataTable Android_Get_Medico_and_comision_Detalle(string cPerCodigo, string FecIni, string FecFin)
        {
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cPerCodigo = cPerCodigo;
            Request.cFecIni = FecIni;
            Request.cFecFin = FecFin;

            //Recuperando...
            return Obj.Android_Get_Medico_and_comision_Detalle(Request); 
        }

        //-------------------------------------------------------------------
        // Reporte por Sucursal y Rango de fechas en TEXTO (by App Android) VENTA-NETA
        //-------------------------------------------------------------------
        public DataTable Get_Android_Venta_Neta_by_cPerJurCodigo_and_fecini_fecfin(string cPerJurCodigo, string dFecIni, string dFecFin)
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cPerJuridica = cPerJurCodigo;
            Request.cFecIni = dFecIni;
            Request.cFecFin = dFecFin;

            return Obj.Get_Android_Venta_Neta_by_cPerJurCodigo_and_fecini_fecfin(Request);

        }

        public DataTable Get_Ventas_Group_cPerJur_Turno_TipoAtencion_by_Fechas(string cPerJuridica, string dFecIni, string dFecFin)
        {

            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cPerJuridica = cPerJuridica;
            Request.cFecIni = dFecIni;
            Request.cFecFin = dFecFin;

            return Obj.Get_Ventas_Group_cPerJur_Turno_TipoAtencion_by_Fechas(Request);

        }

        //------------------------------------------------------------------------------------------
        //Reporte Resumen y Detalle de Pruebas Pendientes de Facturación (Lab. Externo / Convenios)
        //------------------------------------------------------------------------------------------
        public DataTable Get_LabConv_Pendientes_de_Facturacion_By_RangoFecha(string FecIni, string FecFin, string cPerCodigoTerceros = "")
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cPerCodigoTerceros = cPerCodigoTerceros;
            Request.cFecIni = FecIni;
            Request.cFecFin = FecFin;


            return Obj.Get_LabConv_Pendientes_de_Facturacion_By_RangoFecha(Request);

        }



        //----------------------------------------------------
        //Reporte de Ventas según Fecha de Atención y Turnos
        //----------------------------------------------------
        public DataTable Get_Ventas_Group_PerJur_Turno_TipoAtencion_by_Fechas(string cFecIni, string cFecFin)
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.cFecIni = cFecIni;
            Request.cFecFin = cFecFin;

            return Obj.Get_Ventas_Group_PerJur_Turno_TipoAtencion_by_Fechas(Request);

        }


        public DataTable Get_FichaAtencion_By_Per_RFechas(string pcPerCodigo, string pcTipo, string pdFecIni, string pdFecFin, string pcBuscarTexto)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DARptMaster Obj = new DARptMaster();

            Request.cPerCodigo = pcPerCodigo;
            Request.Flag = pcTipo;
            Request.dFecIni = pdFecIni;
            Request.dFecFin = pdFecFin;
            Request.cPerApellidos = pcBuscarTexto;

            return Obj.Get_FichaAtencion_By_Per_RFechas(Request);

        }


        //---------------------------------------------------------------------
        // Reporte Ventas por Promotor en TEXTO (by App Android) VENTA SIN IGV
        //---------------------------------------------------------------------
        public DataTable Get_Android_MetaPromotor_Avance_By_Promotor(string cFlag, string cFecIni, string cFecFin, string cPerPromCodigo)
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();
            DARptMaster Obj = new DARptMaster();

            Request.nFlag = cFlag;
            Request.cFecIni = cFecIni;
            Request.cFecFin = cFecFin;
            Request.cPerCodPromotor = cPerPromCodigo;

            return Obj.Get_Android_MetaPromotor_Avance_By_Promotor(Request);

        }

        //VENTAS DIARIAS SEGÚN REPORTE
        public DataTable Get_VentasDiarias_Segun_Reporte(string cPrdIni = "", string cPrdFin = "", string cFlagReporte = "", string cPerPromCodigo = "")
        {
            //Recuperando...
            ReqRptParametros Request = new ReqRptParametros();

            Request.nFlag = cFlagReporte;
            Request.cFecIni = cPrdIni;
            Request.cFecFin = cPrdFin;
            Request.cPerCodPromotor = cPerPromCodigo;

            DARptMaster Obj = new DARptMaster();
            return Obj.Get_VentasDiarias_Segun_Reporte(Request);
        }

    }
}
