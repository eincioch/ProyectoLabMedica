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
    public class DA_EncuestaMovil
    {
        //-------------------
        // INSERT Proforma
        //-------------------
        public bool Android_Insert_EncuestaMovil(tb_encuesta_movil Objeto)
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
                        cm.CommandText = "[Android].[usp_Insert_Encuesta_Movil]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cPerPromotorCodigo", Objeto.cPerPromotorCodigo);

                        cm.Parameters.AddWithValue("cPerAsigCodigo", Objeto.cPerAsigCodigo);
                        cm.Parameters.AddWithValue("cMedicoNoRegistra", Objeto.cMedicoNoRegistra);

                        cm.Parameters.AddWithValue("nRespuesta01", Objeto.nRespuesta01);
                        cm.Parameters.AddWithValue("nRespuesta02", Objeto.nRespuesta02);
                        cm.Parameters.AddWithValue("nRespuesta03", Objeto.nRespuesta03);
                        cm.Parameters.AddWithValue("nRespuesta04", Objeto.nRespuesta04);
                        cm.Parameters.AddWithValue("nRespuesta05", Objeto.nRespuesta05);
                        cm.Parameters.AddWithValue("nObservacion", Objeto.nObservacion);
                        cm.Parameters.AddWithValue("cUserReg", Objeto.cUserReg);
                        cm.Parameters.AddWithValue("platitub", Objeto.platitub);
                        cm.Parameters.AddWithValue("plongitub", Objeto.plongitub);
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [Android].[usp_Insert_Encuesta_Movil]; Consulte al administrador del sistema");
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
