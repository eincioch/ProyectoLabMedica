using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.PadronReniec;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.PadronReniec
{
    public class DA_Reniec
    {
        public DataTable Get_Datos_Reniec_Local_by_dni(Reniec Objeto)
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
                        cm.CommandText = "[usp_Get_Datos_Reniec_Local_by_dni]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("dni", Objeto.dni);

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
