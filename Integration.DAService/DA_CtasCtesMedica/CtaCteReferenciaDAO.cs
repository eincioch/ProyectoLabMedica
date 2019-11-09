using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.CtasCtesMedica;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;

namespace Integration.DAService.DA_CtasCtesMedica
{
    public class CtaCteReferenciaDAO
    {
        //------------------------
        // Insert CtaCteReferencia
        //------------------------
        public bool Insert_CtaCteReferencia(CtaCteReferencia  ctaCteReferencia)
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
                        cm.CommandText = "[usp_Insert_CtaCteReferencia]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cCtaCteRecibo", ctaCteReferencia.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("cCtaCteRefRecibo", ctaCteReferencia.cCtaCteRefRecibo);
                        cm.Parameters.AddWithValue("nCtaCteRefTipo", ctaCteReferencia.nCtaCteRefTipo); 
                        cm.Parameters.AddWithValue("dCtaCteRefFecha", ctaCteReferencia.dCtaCteRefFecha);
                        cm.Parameters.AddWithValue("cCtaCteRefGlosa", ctaCteReferencia.cCtaCteRefGlosa);
                        cm.Parameters.AddWithValue("fCtaCteRefImporte", ctaCteReferencia.fCtaCteRefImporte);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("Se ha producido error en procedimiento almacenado: [usp_Insert_CtaCteReferencia]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //----------------------------------------
        //Get taCteReferencia_By_cCtaCteRefRecibo
        //----------------------------------------
        public DataTable Get_CtaCteReferencia_By_cCtaCteRefRecibo(CtaCteReferencia ctaCteReferencia)
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
                        cm.CommandText = "[usp_Get_CtaCteReferencia_By_cCtaCteRefRecibo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cCtaCteRecibo", ctaCteReferencia.cCtaCteRecibo);

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
