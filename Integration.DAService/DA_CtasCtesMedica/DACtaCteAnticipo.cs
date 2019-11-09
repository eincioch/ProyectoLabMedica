using System;
using Integration.BE.CtasCtesMedica;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.DAService.DA_CtasCtesMedica
{
    public class DACtaCteAnticipo
    {
        //-----------------------
        // Insert CtaCteAnticipo
        //-----------------------
        public bool Ins_CtaCteAnticipo(ReqCtaCteAnticipo Objeto)
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
                        cm.CommandText = "[usp_Ins_CtaCteAnticipo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Objeto.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("nCtaCteComCodigo", Objeto.nCtaCteComCodigo);
                        cm.Parameters.AddWithValue("cCtaCteComNumero", Objeto.cCtaCteComNumero);
                        cm.Parameters.AddWithValue("nMonCodigo", Objeto.nMonCodigo);
                        cm.Parameters.AddWithValue("fCtaCteImpAnti", Objeto.fCtaCteImpAnti);
                        cm.Parameters.AddWithValue("nCtaCteEstado", Objeto.nCtaCteEstado);
                        cm.Parameters.AddWithValue("cPerCodigo", Objeto.cPerCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0){
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCteAnticipo]; Consulte al administrador del sistema");
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
