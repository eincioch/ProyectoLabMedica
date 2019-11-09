using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Persona;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService
{
    //Capa: Persistencia
    public class DA_PerPorcentajeDscto
    {
        //--------------------------
        // Insert PerPorcentajeDscto
        //--------------------------
        public bool Ins_PerPorcentajeDscto(BE_ReqPerPorcentajeDscto Objeto)
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
                        cm.CommandText = "[usp_Ins_PerPorcentajeDscto]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Objeto.cPerCodigo);
                        cm.Parameters.AddWithValue("cPerParCodigo", Objeto.cPerParCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Objeto.nIntCodigo);
                        cm.Parameters.AddWithValue("nPorcDscto", Objeto.porcentajeCalc()); //utilizando una de regla del negocio "porcentajeCalc()"
                        cm.Parameters.AddWithValue("nAplicaTodo", Objeto.nAplicaTodo);
                        cm.Parameters.AddWithValue("cPerUsuario", Objeto.cPerUsuario);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0){
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_PerPorcentajeDscto]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //----------------------------------------------
        // Insert PerDetallePorcentajeDscto por Muestra
        //----------------------------------------------
        public bool Ins_PerDetallePorcentajeDscto(BE_ReqPerPorcentajeDscto Objeto) 
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
                        cm.CommandText = "[usp_Ins_PerDetallePorcentajeDscto]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Objeto.cPerCodigo);
                        cm.Parameters.AddWithValue("cPerParCodigo", Objeto.cPerParCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Objeto.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Objeto.nIntCodigo);
                        cm.Parameters.AddWithValue("nTipoDscto", Objeto.nTipoDscto);
                        cm.Parameters.AddWithValue("nPorcDscto", Objeto.porcentajeCalc()); 
                        cm.Parameters.AddWithValue("cPerUsuario", Objeto.cPerUsuario);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_PerDetallePorcentajeDscto]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //------------------------------------------------
        // Insert PerDetallePorcentajeDscto en Bloque XML
        //------------------------------------------------
        public bool Ins_PerDetallePorcentajeDscto_By_XML(BE_ReqPerPorcentajeDscto Objeto) 
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
                        cm.CommandText = "[usp_Admision_Ins_PerDetallePorcentajeDscto_By_XML]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("x", Objeto.strXML);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerCodigo);
                        cm.Parameters.AddWithValue("cPerParCodigo", Objeto.cPerParCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Objeto.nIntCodigo);
                        cm.Parameters.AddWithValue("cPerUsuCodigo", Objeto.cPerUsuario);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Admision_Ins_PerDetallePorcentajeDscto_By_XML_Doc_PerJur]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }


        


        //----------------------------------------------
        // DELETE PerDetallePorcentajeDscto por Muestra
        //----------------------------------------------
        public bool Del_PerDetallePorcentajeDscto_by_cPerCodigo_cPerParCodigo_nIntCodigo_nCtaCteSerCodigo(BE_ReqPerPorcentajeDscto Objeto)
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
                        cm.CommandText = "[usp_Del_PerDetallePorcentajeDscto_by_cPerCodigo_cPerParCodigo_nIntCodigo_nCtaCteSerCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Objeto.cPerCodigo);
                        cm.Parameters.AddWithValue("cPerParCodigo", Objeto.cPerParCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Objeto.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Objeto.nIntCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Del_PerDetallePorcentajeDscto_by_cPerCodigo_cPerParCodigo_nIntCodigo_nCtaCteSerCodigo]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }


        //----------------------------------------------
        // DELETE PerDetallePorcentajeDscto por Empresa
        //----------------------------------------------
        public bool Del_PerDetallePorcentajeDscto_by_cPerCodigo_cPerParCodigo_nIntCodigo(BE_ReqPerPorcentajeDscto Objeto)
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
                        cm.CommandText = "[usp_Del_PerDetallePorcentajeDscto_by_cPerCodigo_cPerParCodigo_nIntCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Objeto.cPerCodigo);
                        cm.Parameters.AddWithValue("cPerParCodigo", Objeto.cPerParCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Objeto.nIntCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Del_PerDetallePorcentajeDscto_by_cPerCodigo_cPerParCodigo_nIntCodigo]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }



        //-------------------------------------------------------
        // Get Procentaje aplicado por Entidad y Tipo de Relacion
        //-------------------------------------------------------
        public DataTable Get_PerPorcentajeDscto_by_cPerJurCodigo_and_cPerParCodigo_and_nIntCodigo(BE_ReqPerPorcentajeDscto Request)
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
                        cm.CommandText = "[usp_Get_PerPorcentajeDscto_by_cPerJurCodigo_and_cPerParCodigo_and_nIntCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerCodigo );
                        cm.Parameters.AddWithValue("cPerParCodigo", Request.cPerParCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("cFlag", Request.cFlag);
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

        #region Get PerDetallePorcentajeDscto nReg
        public int Get_PerDetallePorcentajeDscto_nReg(BE_ReqPerPorcentajeDscto Request)
        {
            int nReg = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_PerDetallePorcentajeDscto_nReg]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("@cPerParCodigo", Request.cPerParCodigo);
                        cm.Parameters.AddWithValue("@nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("@nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("@nTipoDscto", Request.nTipoDscto);
                        cm.Parameters.AddWithValue("@nPorcDscto", Request.nPorcDscto);

                        cm.Connection = cn;

                        SqlParameter sqlParameter = new SqlParameter();
                        sqlParameter.ParameterName = "@nReg";
                        sqlParameter.DbType = DbType.Int32;
                        sqlParameter.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(sqlParameter);
                        cm.ExecuteNonQuery();
                        nReg = Convert.ToInt32(cm.Parameters["@nReg"].Value);

                    }
                }
                return nReg;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
