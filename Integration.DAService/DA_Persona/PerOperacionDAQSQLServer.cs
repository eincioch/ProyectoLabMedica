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
    public class PerOperacionDAQSQLServer
    {
        #region Insert PerOperacion
        public bool Insert_PerOperacion(PerOperacion perOperacion)
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
                        cm.CommandText = "[usp_Insert_PerOperacion]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@cPerJurCodigo", perOperacion.cPerJurCodigo);
                        cm.Parameters.AddWithValue("@nOpeCodigo", perOperacion.nOpeCodigo);
                        cm.Parameters.AddWithValue("@fMonto", perOperacion.fMonto);
                        cm.Parameters.AddWithValue("@cOpeHost", perOperacion.cOpeHost);
                        cm.Parameters.AddWithValue("@cObservacion", perOperacion.cObservacion);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Insert_PerOperacion]; Consulte al administrador del sistema");
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

        #region Get PerOperacion
        public DataTable Get_PerOperacion(PerOperacion perOperacion)
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
                        cm.CommandText = "[usp_Get_PerOperacion]";

                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@cPerJurCodigo", perOperacion.cPerJurCodigo);
                        cm.Parameters.AddWithValue("@nOpeCodigo", perOperacion.nOpeCodigo );

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
    }
}
