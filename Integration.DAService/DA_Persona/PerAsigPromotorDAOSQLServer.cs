using System;
using System.Collections.Generic;

//Clases VS
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

//Referencias
using Integration.BE.Persona;
using Integration.Conection;

namespace Integration.DAService.DA_Persona
{
    public class PerAsigPromotorDAOSQLServer
    {
        #region Get PerAsigPromotor
        public DataTable Get_PerAsigPromotor(int nPerAsigTipo)
        {
            try
            {
                DataTable dataTable = new DataTable();

                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_PerAsigPromotor]";

                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@nPerAsigTipo", nPerAsigTipo);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                        dataTable.Load(dr);

                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Get PerAsigPromotor Listado Medico
        public DataTable Get_PerAsigPromotor_Listado_Medico(PerAsigPromotor perAsigPromotor)
        {
            try
            {
                DataTable dataTable = new DataTable();

                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_PerAsigPromotor_Listado_Medico]";

                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@cNameDoctor", perAsigPromotor.cNameDoctor);
                        cm.Parameters.AddWithValue("@cPerPromCodigo", perAsigPromotor.cPerPromCodigo);
                        cm.Parameters.AddWithValue("@nPerAsigTipo", perAsigPromotor.nPerAsigTipo);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dataTable.Load(dr);

                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Get PerAsigPromotor_By_cPerPromCodigo
        public DataTable Get_PerAsigPromotor_By_cPerPromCodigo(PerAsigPromotor perAsigPromotor)
        {
            try
            {
                DataTable dataTable = new DataTable();

                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_PerAsigPromotor_By_cPerPromCodigo]";

                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@cPerPromCodigo", perAsigPromotor.cPerPromCodigo);
                        cm.Parameters.AddWithValue("@nPerAsigTipo", perAsigPromotor.nPerAsigTipo);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dataTable.Load(dr);

                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Insert PerAsigPromotor
        public bool Insert_PerAsigPromotor(PerAsigPromotor perAsigPromotor)
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
                        cm.CommandText = "[usp_Insert_PerAsigPromotor]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@cPerPromCodigo", perAsigPromotor.cPerPromCodigo);
                        cm.Parameters.AddWithValue("@cPerAsigCodigo", perAsigPromotor.cPerAsigCodigo);
                        cm.Parameters.AddWithValue("@dEffDate", perAsigPromotor.dEffDate);
                        cm.Parameters.AddWithValue("@nPerAsigTipo", perAsigPromotor.nPerAsigTipo);
                        cm.Parameters.AddWithValue("@nPerAsigEstado", perAsigPromotor.nPerAsigEstado);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Insert_PerAsigPromotor]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        #region Get dEffDate por cPerAsigCodigo y nPerAsigEstado
        public String Get_PerAsigPromotor_By_nPerAsigEstado_dEffDate(PerAsigPromotor perAsigPromotor)
        {
            string Item = "";
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");
                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_PerAsigPromotor_By_nPerAsigEstado_dEffDate]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@cPerAsigCodigo", perAsigPromotor.cPerAsigCodigo);
                        cm.Parameters.AddWithValue("@nPerAsigEstado", perAsigPromotor.nPerAsigEstado);
                        cm.Parameters.AddWithValue("@nPerAsigTipo", perAsigPromotor.nPerAsigTipo);
                        //
                        cm.Connection = cn;

                        SqlParameter dEffDate = new SqlParameter();
                        dEffDate.ParameterName = "@dEffDate";
                        dEffDate.DbType = DbType.String;
                        dEffDate.Size = 8;
                        dEffDate.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(dEffDate);
                        cm.ExecuteNonQuery();
                        //Item = cm.Parameters["cCtaCteSerie"].Value.ToString() + '-' + cm.Parameters["cCtaCteNumero"].Value.ToString();
                        Item = cm.Parameters["@dEffDate"].Value.ToString();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }
        #endregion 
    }
}
