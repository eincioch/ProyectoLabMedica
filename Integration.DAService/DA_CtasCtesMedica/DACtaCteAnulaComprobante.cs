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
    public class DACtaCteAnulaComprobante
    {
        //-------------------------------
        // Insert CtaCteAnulaComprobante
        //------------------------------
        public bool Ins_CtaCteAnulaComprobante(ReqCtaCteAnulaComprobante Objeto)
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
                        cm.CommandText = "[usp_Ins_CtaCteAnulaComprobante]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Objeto.cPerCodigo);
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Objeto.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("dCtaCteComFecEmision", Objeto.dCtaCteComFecEmision); 
                        cm.Parameters.AddWithValue("nCtaCteComCodigo", Objeto.nCtaCteComCodigo);
                        cm.Parameters.AddWithValue("cCtaCteComNumero", Objeto.cCtaCteComNumero);
                        cm.Parameters.AddWithValue("nCtaCteComImporte", Objeto.nCtaCteComImporte);
                        cm.Parameters.AddWithValue("cPerUserCodigo", Objeto.cPerUserCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0){
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCteAnulaComprobante]; Consulte al administrador del sistema");
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
