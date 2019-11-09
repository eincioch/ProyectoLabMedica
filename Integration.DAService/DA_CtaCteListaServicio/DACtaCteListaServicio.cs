using System;
using Integration.BE.CtasCtes;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.DAService.DA_CtaCteListaServicio
{
    public class DACtaCteListaServicio
    {
        //---------------------------------
        // Get CtaCteListaServicio - Popup
        //--------------------------------
        public DataTable Get_CtaCteListaServicio_by_cPerJurCodigo_and_cCtaCteSerJerarquia(BE_ReqCtaCteServicio Objeto)
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
                        cm.CommandText = "[usp_Get_CtaCteListaServicio_by_cPerJurCodigo_and_cCtaCteSerJerarquia]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cCtaCteSerJerarquia", Objeto.cCtaCteSerJerarquia);

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

        //---------------------------------------------------------
        // Get usp_Android_SQL_Examenes_by_cIntJerarquia - Android
        //---------------------------------------------------------
        public DataTable Get_Android_SQL_Examenes_by_cIntJerarquia(BE_ReqCtaCteServicio Objeto)
        {
            DataTable dt = new DataTable();
            try
            {
                //clsConection Obj = new clsConection();
                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";
                //string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Android_SQL_Examenes_by_cIntJerarquia]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cIntJerarquia", Objeto.cCtaCteSerJerarquia);

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

        #region Get "nCtaCteSerCodigo" de CtaCteListaServicio (EINCIO 2017-03-28)
        public int Get_CtaCteListaServicio(CtaCteListaServicio Objeto)
        {
            int nCtaCteSerCodigo = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_CtaCteListaServicio]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("@cCtaCteSerJerarquia", Objeto.cCtaCteSerJerarquia);

                        cm.Connection = cn;

                        SqlParameter sqlParameter = new SqlParameter();
                        sqlParameter.ParameterName = "@nCtaCteSerCodigo";
                        sqlParameter.DbType = DbType.Int32;
                        sqlParameter.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(sqlParameter);
                        cm.ExecuteNonQuery();
                        nCtaCteSerCodigo = Convert.ToInt32(cm.Parameters["@nCtaCteSerCodigo"].Value);

                    }
                }
                return nCtaCteSerCodigo;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
