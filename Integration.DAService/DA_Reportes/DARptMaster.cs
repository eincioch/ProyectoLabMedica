using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Integration.Conection;
using Integration.BE.Interface;
using Integration.BE.Reportes;
using Integration.BE.FichaAtencion;
using System.Configuration;

namespace Integration.DAService.DA_Persona
{
    public class DARptMaster
    {

        //--------------------------------------------------------------------------
        // en SqlDataReader: Obtiene List Reporte Admision por Permisos PerUsuGruAcc
        //--------------------------------------------------------------------------
        public List<BE_Res_Interface> Get_List_Report_by_cIntJerarquia_and_cPerCodigo(ReqRptParametros Request)
        {
            BE_Res_Interface Item = new BE_Res_Interface();
            var lista = new List<BE_Res_Interface>();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_List_Report_by_cIntJerarquia_and_cPerCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntClase", Request.nIntClase);
                        cm.Parameters.AddWithValue("cIntJerarquia", Request.cIntJerarquia);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            lista.Clear();
                            while (dr.Read())
                            {
                                Item = new BE_Res_Interface();
                                //Item.nIntClase = dr.GetInt32(dr.GetOrdinal("nIntClase"));
                                //Item.nIntCodigo = dr.GetInt32(dr.GetOrdinal("nIntCodigo"));
                                Item.nIntTipo = dr.GetInt32(dr.GetOrdinal("nIntTipo"));
                                Item.cIntDescripcion = dr.GetString(dr.GetOrdinal("cIntDescripcion")).Trim();
                                Item.cIntJerarquia = dr.GetString(dr.GetOrdinal("cIntJerarquia")).Trim();
                                Item.cIntNombre = dr.GetString(dr.GetOrdinal("cIntNombre")).Trim();
                                lista.Add(Item);
                            }
                            dr.Close();
                        }

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        //-------------------------------------------------------------------
        // Comsión Doctores usp_Get_ComisionMedico_by_cPerJuridica_cPerMedico
        //-------------------------------------------------------------------
        public DataTable Get_ComisionMedico_by_cPerJuridica_cPerMedico(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_ComisionMedico_by_cPerJuridica_cPerMedico]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica ", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("cPerCodMedico ", Request.cPerCodMedico);
                        cm.Parameters.AddWithValue("dFecIni", Request.dFecIni);
                        cm.Parameters.AddWithValue("dFecFin", Request.dFecFin);

                        cm.Parameters.AddWithValue("nFlag", Request.nFlag);
                        cm.Parameters.AddWithValue("cPerCodPromotor", Request.cPerCodPromotor);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //-------------------------------------
        // Ingresos por Laboratorio y Convenios
        //-------------------------------------
        public DataTable Get_Ingresos_LabExt_Convenio_by_rango_fechas(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Ingresos_LabExt_Convenio_by_rango_fechas]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("dFecIni", Request.dFecIni);
                        cm.Parameters.AddWithValue("dFecFin", Request.dFecFin);
                        cm.Parameters.AddWithValue("nFlag", Request.nFlag);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //---------------------------------------------------------------------------------------
        // Detalle Importe Derivacion Get_Derivacion_Medico_by_cPerCodMedico_and_dFecIni_dFecFin
        //---------------------------------------------------------------------------------------
        public DataTable Get_Derivacion_Medico_by_cPerCodMedico_and_dFecIni_dFecFin(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Derivacion_Medico_by_cPerCodMedico_and_dFecIni_dFecFin]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodMedico ", Request.cPerCodMedico);
                        cm.Parameters.AddWithValue("dFecIni", Request.dFecIni);
                        cm.Parameters.AddWithValue("dFecFin", Request.dFecFin);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //-------------------------------------------------------------------
        // Reporte por Sucursal y Rango de fechas
        //-------------------------------------------------------------------
        public DataTable Get_Venta_by_cPerJurCodigo_and_fecini_fecfin(ReqRptParametros Request) 
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Venta_by_cPerJurCodigo_and_fecini_fecfin]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo ", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("FecIni", Request.dFecIni);
                        cm.Parameters.AddWithValue("FecFin", Request.dFecFin);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        

        //-------------------------------------------------------------------
        // Reporte por Sucursal según Fecha de Atención
        //-------------------------------------------------------------------
        public DataTable Get_Venta_by_cPerJurCodigo_and_FechaAtencion(ReqRptParametros Request) 
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Venta_by_cPerJurCodigo_and_FechaAtencion]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("cFecIni", Request.cFecIni);
                        cm.Parameters.AddWithValue("cFecFin", Request.cFecFin);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //-------------------------------------------------------------------
        // Detalle de Saldos agrupado por Clientes y filtro por Rango de fechas
        //-------------------------------------------------------------------
        public DataTable Get_Detalle_Saldo_Venta_by_fecini_fecfin_Group_cPerCodigo(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena)) 
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Detalle_Saldo_Venta_by_fecini_fecfin_Group_cPerCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo ", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("fecini", Request.cFecIni);
                        cm.Parameters.AddWithValue("fecfin", Request.cFecFin);
                        cm.Parameters.AddWithValue("nflagFiltro", Request.nFlagFiltro);
                        cm.Parameters.AddWithValue("nflag", Request.nFlag);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }


        //-------------------------------------------------------------------
        // Detalle de Ventas según Fecha de Atención agrupado por Tipo de Atención
        //-------------------------------------------------------------------
        public DataTable Get_Detalle_Venta_by_Tipo_FechaAtencion_Group_cPerJurCodigo(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Detalle_Venta_by_Tipo_FechaAtencion_Group_cPerJurCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo ", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("cFecIni", Request.cFecIni);
                        cm.Parameters.AddWithValue("cFecFin", Request.cFecFin);
                        cm.Parameters.AddWithValue("nflagFiltro", Request.nFlagFiltro);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }


        //-------------------------------------------------------------------
        // Detalle de Saldos agrupado por Clientes y filtro por Rango de fechas for Android
        //-------------------------------------------------------------------
        public DataTable Get_Android_Detalle_Saldo_Venta_by_fecini_fecfin_Group_cPerCodigo(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                //string Cadena = Obj.GetConexionString("Naylamp");
                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";


                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Detalle_Saldo_Venta_by_fecini_fecfin_Group_cPerCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo ", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("fecini", Request.cFecIni);
                        cm.Parameters.AddWithValue("fecfin", Request.cFecFin);
                        cm.Parameters.AddWithValue("nflagFiltro", Request.nFlagFiltro);
                        cm.Parameters.AddWithValue("nflag", Request.nFlag);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //-------------------------------------------------------------------
        // Reporte por Sucursal y Rango de fechas en TEXTO (by App Android)
        //-------------------------------------------------------------------
        public DataTable Get_Venta_by_cPerJurCodigo_and_fecini_fecfin_01(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();

                //string Cadena = Obj.GetConexionString("Naylamp");
                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Venta_by_cPerJurCodigo_and_fecini_fecfin_01]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo ", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("FecIni", Request.cFecIni);
                        cm.Parameters.AddWithValue("FecFin", Request.cFecFin);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //------------------ 2016-06-09 ------------------------
        // Ver Comision Medico por Promotor for (App ANDROID) -EINCIO
        //------------------------------------------------------
        public DataTable Android_Comisiones_By_Promotor(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();

                //string Cadena = Obj.GetConexionString("Naylamp");
                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[Android].[usp_Android_Comisiones_By_Promotor]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cFecIni", Request.cFecIni);
                        cm.Parameters.AddWithValue("cFecFin", Request.cFecFin);
                        cm.Parameters.AddWithValue("cPerUsuCodigo", Request.cPerUsuCodigo);
                        cm.Parameters.AddWithValue("nFlagTodos", Request.nFlagTodos);
                        cm.Parameters.AddWithValue("cTipo", Request.cTipo);
                        cm.Parameters.AddWithValue("cPerCodMedico", Request.cPerCodMedico);
                        cm.Parameters.AddWithValue("nFlagComision", Request.nFlagComision);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //------------------ 2017-01-24 ------------------------
        // Ver Historial Medico por Promotor for (App ANDROID) -EINCIO
        //------------------------------------------------------
        public DataTable Android_Get_Medico_and_comision(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();

                //string Cadena = Obj.GetConexionString("Naylamp");
                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[Android].[usp_Get_Medico_and_comision]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@cApeDoctor", Request.cApeDoctor);
                        cm.Parameters.AddWithValue("@cFecIni", Request.cFecIni);
                        cm.Parameters.AddWithValue("@cFecFin", Request.cFecFin);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //------------------ 2017-03-03 ------------------------
        // Ver Historial Medico Detalle for (App ANDROID) -EINCIO
        //------------------------------------------------------
        public DataTable Android_Get_Medico_and_comision_Detalle(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();

                //string Cadena = Obj.GetConexionString("Naylamp");
                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[Android].[usp_Get_Medico_and_comision_detalle]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("@cFecIni", Request.cFecIni);
                        cm.Parameters.AddWithValue("@cFecFin", Request.cFecFin);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //------------------------------------------------
        // Laboratorios con Pagos Pendientes de Facturar
        //------------------------------------------------
        public DataTable Get_LabConv_Pendientes_de_Facturacion_By_RangoFecha(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Admision_Get_LabConv_Pendientes_de_Facturacion_By_RangoFecha]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cFecIni", Request.cFecIni);
                        cm.Parameters.AddWithValue("cFecFin", Request.cFecFin);
                        if (Request.cPerCodPromotor != "")
                            cm.Parameters.AddWithValue("cPerCodigoTerceros", Request.cPerCodigoTerceros);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }


        //------------------------------------------------
        // Ventas según Fecha de Atención por Turnos
        //------------------------------------------------
        public DataTable Get_Ventas_Group_PerJur_Turno_TipoAtencion_by_Fechas(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_RRHH_Get_Ventas_Group_PerJur_Turno_TipoAtencion_by_Fechas]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cFechaIni", Request.cFecIni);
                        cm.Parameters.AddWithValue("cFechaFin", Request.cFecFin);
                        
                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        

        //-------***** -------------*****---------------
        // Menu Opcion: Ventas Según Atención (eincio)
        //-------***** -------------*****---------------

        //-------------------------------------------------------------------
        // a).- Reporte por Sucursal y Rango de fechas en TEXTO (by App Android) VENTA-NETA
        //-------------------------------------------------------------------
        public DataTable Get_Android_Venta_Neta_by_cPerJurCodigo_and_fecini_fecfin(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();

                //string Cadena = Obj.GetConexionString("Naylamp");
                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Android_Venta_Neta_by_cPerJurCodigo_and_fecini_fecfin]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica ", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("dFecIni", Request.cFecIni);
                        cm.Parameters.AddWithValue("dFecFin", Request.cFecFin);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //-------------------------------------------------------------------
        // Resultados de Fichas de Pacientes, Labs y Conv según Fechas
        //-------------------------------------------------------------------
        public DataTable Get_FichaAtencion_By_Per_RFechas(BE_ReqSolAtencion Request)
        {
            DataTable dt = new DataTable();
            string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";
            try
            {
                SqlConnection cn = new SqlConnection(Cadena);
                using (SqlCommand cm = new SqlCommand())
                {
                    cm.CommandText = "[usp_Admision_Get_FichaAtencion_By_Per_RFechas]";
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                    cm.Parameters.AddWithValue("cTipo", Request.Flag);
                    cm.Parameters.AddWithValue("cIni", Request.dFecIni);
                    cm.Parameters.AddWithValue("cFin", Request.dFecFin);
                    cm.Parameters.AddWithValue("cBuscaTexto", Request.cPerApellidos);

                    cm.Connection = cn;
                    cn.Open();

                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        dt.Load(dr);
                    }
                }

            }
            catch (Exception generatedExceptionName)
            {
                throw;
            }
            return dt;
        }



        //-------------------------------------
        // b).- Agrupado por Sucursal y Turno
        //-------------------------------------

        public DataTable Get_Ventas_Group_cPerJur_Turno_TipoAtencion_by_Fechas(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();

                //string Cadena = Obj.GetConexionString("Naylamp");
                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[Android].[usp_Get_Ventas_Group_cPerJur_Turno_TipoAtencion_by_Fechas]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica ", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("cFechaIni", Request.cFecIni);
                        cm.Parameters.AddWithValue("cFechaFin", Request.cFecFin);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }




        //-------------------------------------
        // VENTAS POR PROMOTOR
        //-------------------------------------

        public DataTable Get_Android_MetaPromotor_Avance_By_Promotor(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();

                //string Cadena = Obj.GetConexionString("Naylamp");
                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[Android].[usp_Get_MetaPromotor_Avance_By_Promotor]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cFlag ", Request.nFlag);
                        cm.Parameters.AddWithValue("cPrdIni", Request.cFecIni);
                        cm.Parameters.AddWithValue("cPrdFin", Request.cFecFin);
                        cm.Parameters.AddWithValue("cPerPromCodigo ", Request.cPerCodPromotor);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //------------------------------------------------
        // Ventas según Fecha de Atención por Turnos
        //------------------------------------------------
        public DataTable Get_VentasDiarias_Segun_Reporte(ReqRptParametros Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Admision_Get_Ventas_by_Fechas_Reporte]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cFechaIni", Request.cFecIni);
                        cm.Parameters.AddWithValue("cFechaFin", Request.cFecFin);
                        cm.Parameters.AddWithValue("cFlag", Request.nFlag);
                        if (!Request.cPerCodPromotor.Equals("")) cm.Parameters.AddWithValue("cPromCodigo", Request.cPerCodPromotor);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

    }
}
