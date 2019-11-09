using System;

using Integration.BE.Android;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;

namespace Integration.DAService.DA_Android
{
    public class EncSatisfaccionDAOSQLServer
    {
        //-------------------------------
        // Obtener Resultado de Encuenta
        //-------------------------------
        public DataTable Get_EncSatisfaccion(string cPerJurCodigo, string dFecIni, string dFecFin, string cFlag)
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
                        cm.CommandText = "[Android].[usp_Get_EncSatisfaccion]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", cPerJurCodigo);
                        cm.Parameters.AddWithValue("dFecIni", dFecIni);
                        cm.Parameters.AddWithValue("dFecFin", dFecFin);
                        cm.Parameters.AddWithValue("cFlag", cFlag);

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
