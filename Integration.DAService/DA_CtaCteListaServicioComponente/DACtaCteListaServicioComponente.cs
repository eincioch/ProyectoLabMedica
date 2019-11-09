using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integration.BE.CtasCtes;
using System.Data;
using System.Data.SqlClient;
using Integration.Conection;

namespace Integration.DAService.DA_CtaCteListaServicioComponente
{
    public class DACtaCteListaServicioComponente
    {

        //------------------------------------------------
        // Insert CtaCteListaServicioComponente en Bloque XML
        //------------------------------------------------
        public bool Ins_CtaCteListaServicioComponente_By_XML(CtaCteListaServicioComponente Objeto)
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
                        cm.CommandText = "[usp_Admision_Ins_CtaCteListaServicioComponente_By_XML]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("x", Objeto.strXML);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Objeto.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nTipoAtencionCodigo", Objeto.nTipoAtencionCodigo);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurcodigo);
                        cm.Parameters.AddWithValue("cPerUsuCodigo", Objeto.cPerUsuCodigo);
                        

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Admision_Ins_CtaCteListaServicioComponente_By_XML]; Consulte al administrador del sistema");
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
