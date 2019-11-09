using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.Android;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_Android
{
    public class DA_Proforma
    {
        //----------------------------------
        //Generar cDocCodigo para Documentos
        //----------------------------------
        public int Android_Get_Correlativo_Proforma(Proforma Objeto)
        {
            int Item = 0;
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
                        cm.CommandText = "[Android].[usp_Android_Get_Correlativo_Proforma]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nPerIdeTipo", Objeto.nPerIdeTipo);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Objeto.cPerIdeNumero);
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "nCorrelativo";
                        pCod.DbType = DbType.Int32;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        Item = Convert.ToInt32(cm.Parameters["nCorrelativo"].Value);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }

        //-------------------
        // INSERT Proforma
        //-------------------
        public bool Android_Insert_Proforma(Proforma Objeto)
        {
            bool exito = false;
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
                        cm.CommandText = "[Android].[usp_Android_Insert_Proforma]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nCorrelativo", Objeto.nCorrelativo);
                        cm.Parameters.AddWithValue("nPerIdeTipo", Objeto.nPerIdeTipo);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Objeto.cPerIdeNumero);
                        cm.Parameters.AddWithValue("ListMuestras", Objeto.ListMuestras);
                        //cm.Parameters.AddWithValue("nIntJerarquia", Objeto.nIntJerarquia);
                        //cm.Parameters.AddWithValue("nPrecio", Objeto.nPrecio);
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [Android].[usp_Android_Insert_Proforma]; Consulte al administrador del sistema");
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
        // UPDATE Proforma (nEstado, nSolAdmNumero)
        //-------------------
        public bool Android_Update_Proforma(Proforma Objeto)
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
                        cm.CommandText = "[Android].[usp_Android_Update_Proforma]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nCorrelativo", Objeto.nCorrelativo);
                        cm.Parameters.AddWithValue("nPerIdeTipo", Objeto.nPerIdeTipo);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Objeto.cPerIdeNumero);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Objeto.nSolAdmNumero);
                        //cm.Parameters.AddWithValue("nIntJerarquia", Objeto.nIntJerarquia);
                        //cm.Parameters.AddWithValue("nPrecio", Objeto.nPrecio);
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [Android].[usp_Android_Update_Proforma]; Consulte al administrador del sistema");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }


        //----------------------------------------------------------------------------------------------
        // Update Proforma [nPerIdeTipo, cPerIdeNumero] si hay correccion de documento en la validación
        //---------------------------------------------------------------------------------------------
        public bool Android_Update_Proforma_by_cPerIdeNumero(Proforma Objeto) {
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
                        cm.CommandText = "[Android].[usp_Update_Proforma_by_cPerIdeNumero]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nPerIdeTipo", Objeto.nPerIdeTipo);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Objeto.cPerIdeNumero);
                        cm.Parameters.AddWithValue("nPerIdeTipo_New", Objeto.nPerIdeTipo_New);
                        cm.Parameters.AddWithValue("cPerIdeNumero_New", Objeto.cPerIdeNumero_New);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [Android].[usp_Update_Proforma_by_cPerIdeNumero]; Consulte al administrador del sistema");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //--------------------------------------------------
        // Listar Proforma por nPerIdeTipo_and_cPerIdeNumero
        //--------------------------------------------------
        public DataTable Android_Listar_Proforma_by_nPerIdeTipo_and_cPerIdeNumero(Proforma Objeto)
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
                        cm.CommandText = "[Android].[usp_Listar_Proforma_by_nPerIdeTipo_and_cPerIdeNumero]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nPerIdeTipo", Objeto.nPerIdeTipo);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Objeto.cPerIdeNumero);

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

        //---------------------------------
        // Buscar Persona para ser atendida
        //---------------------------------
        public DataTable Android_Get_Persona_by_nPerIdeTipo_cPerIdeNumero(Proforma Objeto)
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
                        cm.CommandText = "[Android].[usp_Android_Get_Persona_by_nPerIdeTipo_cPerIdeNumero]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nPerIdeTipo", Objeto.nPerIdeTipo);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Objeto.cPerIdeNumero);

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

        //-----------------------------------
        // Cargar Detalle Proforma (Muestras)
        //-----------------------------------
        public DataTable Get_Proforma_by_nPerIdeTipo_cPerIdeNumero(Proforma Objeto)
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
                        cm.CommandText = "[Android].[usp_Get_Proforma_by_nPerIdeTipo_cPerIdeNumero]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nPerIdeTipo", Objeto.nPerIdeTipo);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Objeto.cPerIdeNumero);
                        cm.Parameters.AddWithValue("cFecIni", Objeto.cFecIni);
                        cm.Parameters.AddWithValue("cFecFin", Objeto.cFecFin);
                        cm.Parameters.AddWithValue("cFlag", Objeto.cFlag);
                        cm.Parameters.AddWithValue("nCorrelativo", Objeto.nCorrelativo);

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
