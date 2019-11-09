using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Campana ;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_Campana
{
    public class DA_Campana
    {
        //--------------------------
        //Genrar NewId para Campaña
        //--------------------------
        public string Get_NewId_nIntCampana(BE_ReqCampana Request) 
        {
            string nNewId = "";
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");
                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_NewId_nIntCampana]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "nNewId";
                        pCod.DbType = DbType.String;
                        pCod.Size = 12;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        nNewId = cm.Parameters["nNewId"].Value.ToString();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nNewId;
        }

        //----------------
        // Insert Campaña
        //----------------
        public bool Ins_Campana(BE_ReqCampana Request)
        {
            bool exito = false;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Ins_Campana]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntCamp", Request.nIntCamp);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cNombreCamp", Request.cNombreCamp);
                        cm.Parameters.AddWithValue("dFecIniCamp", Request.dFecIniCamp);
                        cm.Parameters.AddWithValue("dFecFinCamp", Request.dFecFinCamp);
                        cm.Parameters.AddWithValue("nTCostoCamp", Request.nTCostoCamp);
                        cm.Parameters.AddWithValue("cPerUseCodigo", Request.cPerUseCodigo);
                        
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_Campana]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //----------------
        // Update Campaña
        //----------------
        public bool Upd_Campana(BE_ReqCampana Request)
        {
            bool exito = false;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Upd_Campana]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntCamp", Request.nIntCamp);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cNombreCamp", Request.cNombreCamp);
                        cm.Parameters.AddWithValue("dFecIniCamp", Request.dFecIniCamp);
                        cm.Parameters.AddWithValue("dFecFinCamp", Request.dFecFinCamp);
                        cm.Parameters.AddWithValue("nTCostoCamp", Request.nTCostoCamp);
                        cm.Parameters.AddWithValue("cPerUseCodigo", Request.cPerUseCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Upd_Campana]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //-----------------------
        // Insert Detalle Campaña
        //-----------------------
        public bool Ins_DetalleCampana(BE_ReqCampana Request)
        {
            bool exito = false;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Ins_DetCampana]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntCamp", Request.nIntCamp);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nCtaCteCosto", Request.nCtaCteCosto);
                        cm.Parameters.AddWithValue("cIntJerarquia", Request.cIntJerarquia);
                        cm.Parameters.AddWithValue("nFlag", Request.nFlag);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_DetCampana]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //-----------------------
        // Update Detalle Campaña
        //-----------------------
        public bool Upd_DetalleCampana(BE_ReqCampana Request)
        {
            bool exito = false;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Upd_DetCampana]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntCamp", Request.nIntCamp);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nCtaCteCosto", Request.nCtaCteCosto);
                        cm.Parameters.AddWithValue("cIntJerarquia", Request.cIntJerarquia);
                        cm.Parameters.AddWithValue("nFlag", Request.nFlag);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Upd_DetCampana]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //-----------------------------
        // Delete Item Detalle Campaña
        //----------------------------
        public bool Del_DetalleCampana_by_nIntCamp_cPerJurCodigo_nCtaCteSerCodigo(BE_ReqCampana Request)
        {
            bool exito = false;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Del_DetCampana]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntCamp", Request.nIntCamp);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Del_DetCampana]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //------------------------
        // Lista Campaña Vigentes
        //------------------------
        public DataTable Get_List_Campana(BE_ReqCampana Request)
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
                        cm.CommandText = "[usp_Get_List_Campana]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);

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

        //-------------------------
        // Lista Campaña Historial
        //-------------------------
        public DataTable Get_Campana_Historial(BE_ReqCampana Request)
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
                        cm.CommandText = "[usp_Get_Campana_Historial]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);

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
        // Lista Campaña Vigentes (App Android)
        //-------------------------------------
        public DataTable Android_Get_Campana_actual(BE_ReqCampana Request)
        {
            DataTable dt = new DataTable();
            try
            {
                //clsConection Obj = new clsConection();
                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid=android; Pwd=C2879442C28147B;Integrated Security=False; Pooling = False";
                //string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Android_Get_Campana_actual]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cFlag", Request.cFlag);

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

        //-------------------------------
        // Recuperar Servicio for campaña
        //-------------------------------
        public DataTable Get_Servicios_for_nIntCamp(BE_ReqCampana Request)
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
                        cm.CommandText = "[usp_Get_Servicios_for_nIntCamp]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nIntCamp", Request.nIntCamp);

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

        //----------------------------------------
        // Verifica si Existe Linea en DetCampaña
        //---------------------------------------
        public DataTable Get_DetCampana_by_nIntCamp_cPerJurCodigo_nCtaCteSerCodigo(BE_ReqCampana Request)
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
                        cm.CommandText = "[usp_Get_DetCampana_by_nIntCamp_cPerJurCodigo_nCtaCteSerCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntCamp", Request.nIntCamp);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);

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

        //--------------------------------------------------
        // Lista Detalle Campaña carga Grilla para editarla
        //--------------------------------------------------
        public DataTable Get_List_Campana_Detalle(BE_ReqCampana Request)
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
                        cm.CommandText = "[usp_Get_List_Campana_Detalle]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nIntCamp", Request.nIntCamp);

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
