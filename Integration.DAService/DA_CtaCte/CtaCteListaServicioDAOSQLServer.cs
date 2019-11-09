using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;
using Integration.Conection;

using Integration.BE.CtasCtes;

namespace Integration.DAService.DA_CtaCte
{
    public class CtaCteListaServicioDAOSQLServer
    {
        public List<CtaCteListaServicio> Get_CtaCteListaServicio(string cPerJurCodigo)
        {

            List<CtaCteListaServicio> listaCtaCteListaServicio =  new List<CtaCteListaServicio>();
            CtaCteListaServicio ctaCteListaServicio;

            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "SELECT [nCtaCteSerCodigo]      ,[cPerJurCodigo]      ,[cCtaCteSerJerarquia]      ,[cCtaCteSerKeyWord]      ,[nBieCodigo]      ,[nCtaCteSerAfecto]      ,[nCtaCteSerExonerado]      ,[nMonCodigo]      ,[nCtaCteSerImpMin]      ,[nCtaCteSerImpMax]      ,[nCtaCteSerImpDef]      ,[dCtaCTeSerFecRegistro]      ,[nSeuCodigo]      ,[nCtaCteSerFacturable]      ,[nCtaCteTipoCta]      ,[nCtaAlterna]      ,[cRequisitoIndica]      ,[cPreparaPaciente]      ,[cIdentificaMuestra]      ,[cEntregaResultado]      ,[cRecepcionMuestra]      ,[cConservaTransporte]      ,[cEstabilidadMuestra]      ,[nCantMuestra]      ,[nCodEnvase]      ,[nCodTipoMuestra]      ,[cVolumMinimo]      ,[cDiaHoraProceso]      ,[nTiempoEntrega]      ,[nProceso]      ,[nEstado]      ,[nHorasProceso] " +
                                            " FROM CtaCteListaServicio WITH(NOLOCK) " +
                                            " WHERE cPerJurCodigo = '" + cPerJurCodigo + "' " + 
                                            " ORDER BY cCtaCteSerJerarquia"; 

                        cm.CommandType = CommandType.Text;
                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader()) {
                            while (dr.Read())
                            {
                                ctaCteListaServicio = new CtaCteListaServicio();
                                ctaCteListaServicio.nCtaCteSerCodigo = dr.GetInt32(0);
                                ctaCteListaServicio.cPerJurCodigo = dr.GetString(1);
                                ctaCteListaServicio.cCtaCteSerJerarquia = dr.GetString(2);
                                ctaCteListaServicio.cCtaCteSerKeyWord = dr.GetString(3);
                                ctaCteListaServicio.nBieCodigo = dr.GetInt32(4);
                                ctaCteListaServicio.nCtaCteSerAfecto = dr.GetInt32(5);
                                ctaCteListaServicio.nCtaCteSerExonerado = dr.GetInt32(6);
                                ctaCteListaServicio.nMonCodigo = dr.GetInt32(7);
                                ctaCteListaServicio.nCtaCteSerImpMin = Convert.ToDouble(dr.GetDecimal(8));
                                ctaCteListaServicio.nCtaCteSerImpMax = Convert.ToDouble(dr.GetDecimal(9));
                                ctaCteListaServicio.nCtaCteSerImpDef = Convert.ToDouble(dr.GetDecimal(10));
                                ctaCteListaServicio.dCtaCTeSerFecRegistro = dr.GetDateTime(11);
                                ctaCteListaServicio.nSeuCodigo = dr.GetInt32(12);
                                ctaCteListaServicio.nCtaCteSerFacturable = dr.GetInt32(13);
                                ctaCteListaServicio.nCtaCteTipoCta = dr.GetInt32(14);
                                ctaCteListaServicio.nCtaAlterna = dr.GetString(15);
                                ctaCteListaServicio.cRequisitoIndica = dr.GetString(16);
                                ctaCteListaServicio.cPreparaPaciente = dr.GetString(17);
                                ctaCteListaServicio.cIdentificaMuestra = dr.GetString(18);
                                ctaCteListaServicio.cEntregaResultado = dr.GetString(19);
                                ctaCteListaServicio.cRecepcionMuestra = dr.GetString(20);
                                ctaCteListaServicio.cConservaTransporte = dr.GetString(21);
                                ctaCteListaServicio.cEstabilidadMuestra = dr.GetString(22);
                                ctaCteListaServicio.nCantMuestra = dr.GetInt32(23);
                                ctaCteListaServicio.nCodEnvase = dr.GetInt32(24);
                                ctaCteListaServicio.nCodTipoMuestra = dr.GetInt32(25);
                                ctaCteListaServicio.cVolumMinimo = dr.GetString(26);
                                ctaCteListaServicio.cDiaHoraProceso = dr.GetString(27);
                                ctaCteListaServicio.nTiempoEntrega = dr.GetInt32(28);
                                ctaCteListaServicio.nProceso = dr.GetInt32(29);
                                ctaCteListaServicio.nEstado = dr.GetInt32(30);
                                ctaCteListaServicio.nHorasProceso = dr.GetInt32(31);

                                listaCtaCteListaServicio.Add(ctaCteListaServicio);
                            }

                            return listaCtaCteListaServicio;
                        }
       
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        } 
    }
}
