using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.CtasCtesMedica;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_CtasCtesMedica
{
    public class DACtaCteIntDetalle
    {
        //-------------------------
        // Insert CtaCteIntDetalle
        //-------------------------
        public bool Ins_CtaCteIntDetalle(ReqCtaCteIntDetalle Objeto)
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
                        cm.CommandText = "[usp_Ins_CtaCteIntDetalle]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Objeto.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("nIntCodigo", Objeto.nIntCodigo);
                        cm.Parameters.AddWithValue("nIntClase", Objeto.nIntClase);
                        cm.Parameters.AddWithValue("cIntJerarquia", Objeto.cIntJerarquia);
                        cm.Parameters.AddWithValue("cIntValor", Objeto.cIntValor);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0){
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCteIntDetalle]; Consulte al administrador del sistema");
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
