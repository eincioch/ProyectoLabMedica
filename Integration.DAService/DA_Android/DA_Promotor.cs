using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.Persona;
using Integration.Conection;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_Android
{
    public class DA_Promotor
    {
        //------------------------------
        // Listar Promotores de Médica
        //------------------------------
        public DataTable Android_Get_Promotor(string cOpcion = "")
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
                        cm.CommandText = "[Android].[usp_Android_Get_Promotor]";
                        cm.CommandType = CommandType.StoredProcedure;
                        if (cOpcion != "")
                            cm.Parameters.AddWithValue("cOpcion", cOpcion);

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

        //------------------------------
        // Listar Médicos por promotor
        //------------------------------
        public DataTable Android_Get_Medico_By_Promotor(BE_Req_Medico Object)
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
                        cm.CommandText = "[Android].[usp_Get_Medico_By_Promotor]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerPromCodigo", Object.cPerPromCodigo);

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


        //------------------------------
        // Listar Asignaciones por promotor
        //------------------------------
        public DataTable Android_Get_Asignaciones_By_Promotor(BE_Req_Medico Object)
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
                        cm.CommandText = "[Android].[usp_Get_Asignaciones_By_Promotor]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerPromCodigo", Object.cPerPromCodigo);

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
