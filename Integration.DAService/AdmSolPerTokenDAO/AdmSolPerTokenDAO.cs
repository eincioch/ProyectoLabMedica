using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integration.BE.AdmSolPerToken;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.AdmSolPerTokenDAO
{
    public class AdmSolPerTokenDAO
    {
        //----------------------
        // Insert AdmSolPerToken
        //----------------------
        public bool Upd_AdmSolPerToken(AdmSolPerToken admSolPerToken)
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
                        cm.CommandText = "[usp_Upd_AdmSolPerToken]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", admSolPerToken.cPerCodigo);
                        cm.Parameters.AddWithValue("cPerJurCodigo", admSolPerToken.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cToken", admSolPerToken.cToken);
                        cm.Parameters.AddWithValue("nTipo", admSolPerToken.nTipo);
                        cm.Parameters.AddWithValue("nSolAdmNumero", admSolPerToken.nSolAdmNumero);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Upd_AdmSolPerToken]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //-------------------------------------------------
        //Generar Clave Token desde App Medica Coorporativo
        //-------------------------------------------------
        public string Android_ADMISION_SET_TOKEN_DCTOS_OR_CORTESIA(AdmSolPerToken Objeto)
        {
            string Item = "";
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
                        cm.CommandText = "[USP_Android_ADMISION_SET_TOKEN_DCTOS_OR_CORTESIA]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerUsuCodigo", Objeto.cPerUsuCodigo);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nTipo", Objeto.nTipo);
                        cm.Parameters.AddWithValue("fPorcentaje", Objeto.fPorcentaje);
                        cm.Parameters.AddWithValue("nFlag", Objeto.nFlag);

                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "cToken";
                        pCod.DbType = DbType.String;
                        pCod.Size = 20;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        Item = cm.Parameters["cToken"].Value.ToString();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }

        //-------------------------------
        // Validar si esta libre el Token
        //-------------------------------
        public DataTable Get_AdmSolPerToken(AdmSolPerToken admSolPerToken)
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
                        cm.CommandText = "[usp_Get_AdmSolPerToken]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", admSolPerToken.cPerCodigo);
                        cm.Parameters.AddWithValue("cPerJurCodigo", admSolPerToken.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cToken", admSolPerToken.cToken);
                        cm.Parameters.AddWithValue("nTipo", admSolPerToken.nTipo);

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
