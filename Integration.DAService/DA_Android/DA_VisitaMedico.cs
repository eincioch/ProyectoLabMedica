using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integration.BE.Android;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;

namespace Integration.DAService.DA_Android
{
    public class DA_VisitaMedico
    {
        //-------------------
        // INSERT VisitaMedico
        //-------------------
        public bool Android_Insert_Visita_Medico(VisitaMedico Objeto)
        {
            bool exito = false;
            try
            {
                clsConection Obj = new clsConection();

                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[Android].[usp_Insert_Visita_Medico]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerPromCodigo", Objeto.cPerPromCodigo);
                        cm.Parameters.AddWithValue("cPerAsigCodigo", Objeto.cPerAsigCodigo);
                        cm.Parameters.AddWithValue("dVisLatitud", Objeto.dVisLatitud);
                        cm.Parameters.AddWithValue("dVisLongitud", Objeto.dVisLongitud);
                        cm.Parameters.AddWithValue("cVisObservacion", Objeto.cVisObservacion);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [Android].[usp_Insert_Visita_Medico]; Consulte al administrador del sistema");
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
        // Listar Visitas Diarios según Promotor
        //----------------------------------------
        public DataTable Android_Get_VisitaDiariaMedico_by_Promotor(VisitaMedico Objeto)
        {
            DataTable dt = new DataTable();
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
                        cm.CommandText = "[usp_Android_Get_VisitaDiariaMedico_by_Promotor]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerPromCodigo", Objeto.cPerPromCodigo);
                        cm.Parameters.AddWithValue("cFecha", Objeto.dVisFechaHora);

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
