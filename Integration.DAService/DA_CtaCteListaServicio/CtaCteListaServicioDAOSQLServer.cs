using System;
using System.Collections.Generic;

using Integration.BE.Reportes;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;

namespace Integration.DAService.DA_CtaCteListaServicio
{
    public class CtaCteListaServicioDAOSQLServer
    {
        #region Get Lista Grupo Examenes
        public DataTable Get_Lista_Grupo_Examenes(ReqRptParametros reqRptParametros)
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
                        cm.CommandText = "[usp_Get_Lista_Grupo_Examenes]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", reqRptParametros.cPerCodigo);
                        cm.Parameters.AddWithValue("cFlag", reqRptParametros.cTipo);

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
        #endregion

        #region Get Ranking Grupo Examenes
        public DataTable Get_Ranking_Grupo_Examenes(ReqRptParametros reqRptParametros)
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
                        cm.CommandText = "[usp_Get_Ranking_Grupo_Examenes]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cCtaCteSerJerarquia", reqRptParametros.cIntJerarquia);
                        cm.Parameters.AddWithValue("dFecIni", reqRptParametros.cFecIni);
                        cm.Parameters.AddWithValue("dFecFin", reqRptParametros.cFecFin);
                        cm.Parameters.AddWithValue("cFlag", reqRptParametros.cTipo);

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
        #endregion

    }
}
