using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Integration.BE.Persona;

namespace Integration.DAService.DA_Persona
{
    public class DA_PerAsigDetalle
    {
        public DataTable Get_DatosMedico_by_cPerPromCodigo_NombresMedico(PerAsigPromotor Objeto)
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
                        cm.CommandText = "[usp_Android_Get_DatosMedico_by_cPerPromCodigo_NombresMedico]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerPromCodigo", Objeto.cPerPromCodigo);
                        cm.Parameters.AddWithValue("cPerAsigCodigo", Objeto.cPerAsigCodigo);

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
