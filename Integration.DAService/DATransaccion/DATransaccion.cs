using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using Integration.BE.Transaccion;
using System.Configuration;


namespace Integration.DAService.DATransaccion
{
    public class DATransaccion
    {
        //-------------------
        // Insert Transaccion
        //-------------------
        public bool Ins_Transaccion(BETransaccion Objeto)
        {
            bool exito = false;

            String cTraCodigo  = String.Empty;
            cTraCodigo = DateTime.Now.ToString("yyyyMMddhhmmssFF"); //VB = Format(Date.Now, "yyyyMMddhhmmssFF")

            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[sp_Transaction_Set]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cTraCodigo", cTraCodigo); //Objeto.cTraCodigo);
                        cm.Parameters.AddWithValue("nOpeCodigo", Objeto.nOpeCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Objeto.cPerCodigo);
                        cm.Parameters.AddWithValue("cTraHost", Objeto.cTraHost);
                        cm.Parameters.AddWithValue("cTraDescripcion", Objeto.cTraDescripcion);
                        
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [sp_Transaction_Set]; Consulte al administrador del sistema");
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
