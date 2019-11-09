using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Reportes;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_Persona
{
    public class DA_RptCuadreCaja
    {
        //----------------------------
        // SELECT Get_ReportCuadraCaja
        //----------------------------
        public DataTable Get_ReportCuadraCaja(BE_ReqRptCuadreCaja Request)
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
                        cm.CommandText = "[usp_Get_CuadreCaja_by_cPerJurCodigo_nTurno_fecini_fecfin]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nTurno", Request.nTurno);
                        cm.Parameters.AddWithValue("fecini", Request.dCtaCteComFecIni);
                        cm.Parameters.AddWithValue("fecfin", Request.dCtaCteComFecFin);
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

        //------------------------------------
        // SELECT Get_ReportCuadraCaja Detalle
        //------------------------------------
        public DataTable Get_ReportCuadraCaja_Detalle(BE_ReqRptCuadreCaja Request) 
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
                        cm.CommandText = "[usp_Get_CuadreCaja_by_cPerJurCodigo_nTurno_fecini_fecfin_Detalle]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nTurno", Request.nTurno);
                        cm.Parameters.AddWithValue("fecini", Request.dCtaCteComFecIni);
                        cm.Parameters.AddWithValue("fecfin", Request.dCtaCteComFecFin);

                        //update 2016-03-16 (EINCIO)
                        cm.Parameters.AddWithValue("cIncluye", Request.cIncluye);

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
