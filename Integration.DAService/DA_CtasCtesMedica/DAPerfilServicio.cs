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
    public class DAPerfilServicio
    {
        //-----------------------
        // Insert PerfilServicio
        //-----------------------
        public bool Ins_PerfilServicio(ReqPerfilServicio Objeto)
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
                        cm.CommandText = "[usp_Ins_PerfilServicio]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Objeto.nIntCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Objeto.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nMonCodigo", Objeto.nMonCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerImpDef", Objeto.nCtaCteSerImpDef);
                        cm.Parameters.AddWithValue("cPerCodigo", Objeto.cPerCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_PerfilServicio]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //-----------------------
        // DELETE PerfilServicio
        //-----------------------
        public bool Del_PerfilServicio(ReqPerfilServicio Objeto)
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
                        cm.CommandText = "[usp_Del_PerfilServicio]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Objeto.nIntCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Objeto.nCtaCteSerCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0){
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Del_PerfilServicio]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //-------------------
        // Get PerfilServicio
        //-------------------
        public DataTable Get_PerfilServicio(ReqPerfilServicio Objeto)
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
                        cm.CommandText = "[usp_Get_PerfilServicio_by_cPerJurCodigo_nIntCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Objeto.nIntCodigo);
                        cm.Parameters.AddWithValue("nFlag", Objeto.nFlag);

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

        public DataTable Get_PerfilServicio_Terceros(ReqPerfilServicio Objeto)
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
                        cm.CommandText = "[usp_Get_PerfilServicio_by_cPerJurCodigo_nIntCodigo_Terceros]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Objeto.nIntCodigo);
                        cm.Parameters.AddWithValue("nFlag", Objeto.nFlag);
                        cm.Parameters.AddWithValue("nTipoAtencion", Objeto.nTipoAtencion);
                        cm.Parameters.AddWithValue("cPerCodigoTerceros", Objeto.cPerParCodigo);

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

        //----------------------------------------------------------------------------
        //Get List PerfilServicio for cPerJurCodigo and nIntCodigo and nCtaCteSerCodigo
        //----------------------------------------------------------------------------
        public DataTable Get_PerfilServicio_by_cPerJurCodigo_nIntCodigo_nCtaCteSerCodigo(ReqPerfilServicio Objeto)
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
                        cm.CommandText = "[usp_Get_PerfilServicio_by_cPerJurCodigo_nIntCodigo_nCtaCteSerCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Objeto.nIntCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Objeto.nCtaCteSerCodigo);

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
