using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using Integration.BE.Persona;

namespace Integration.DAService
{
    public class DA_Marcacion
    {
        public bool Set_tb_reportslist(BE_Req_Marcacion Objeto)
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
                        cm.CommandText = "[usp_Marcacion_Set_tb_reportslist]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cFechaHora", Objeto.cFechaHora);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Objeto.cPerIdeNumero);
                        cm.Parameters.AddWithValue("nDeviceID", Objeto.nDeviceID);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cHost", Objeto.cHost);

                        cm.Connection = cn;

                        cm.ExecuteNonQuery();
                        exito = true;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
    }
}
