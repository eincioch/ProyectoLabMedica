﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.CtasCtes;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService
{
    public class DA_CtaCteNumeracion
    {
        //--------------------------
        // CtaCteNumeracion
        //--------------------------
        //Insert
        public BE_ResGenerico InsCtaCteNumeracion(BE_ReqCtaCteNumeracion Request)
        {
            BE_ResGenerico Item = new BE_ResGenerico();
            long Resultado = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Ins_CtaCteNumeracion";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCajCodigo", Request.nCajCodigo);
                        cm.Parameters.AddWithValue("nComCodigo", Request.nComCodigo);
                        cm.Parameters.AddWithValue("nCtaCteNumero", Request.nCtaCteNumero);
                        cm.Parameters.AddWithValue("cCtaCteSerie", Request.cCtaCteSerie);
                        cm.Parameters.AddWithValue("nCtaCteNumIni", Request.nCtaCteNumIni);
                        cm.Parameters.AddWithValue("nCtaCtaNumFin", Request.nCtaCtaNumFin);
                        cm.Connection = cn;

                        Resultado = cm.ExecuteNonQuery();
                        Item.Resultado = Resultado;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }

        //Update CtaCteNumeracion
        public BE_ResGenerico UpdCtaCteNumeracion(BE_ReqCtaCteNumeracion Request)
        {
            BE_ResGenerico Item = new BE_ResGenerico();
            long Resultado = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Upd_CtaCteNumeracion";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCajCodigo", Request.nCajCodigo);
                        cm.Parameters.AddWithValue("nComCodigo", Request.nComCodigo);
                        cm.Parameters.AddWithValue("nCtaCteNumero", Request.nCtaCteNumero);
                        cm.Parameters.AddWithValue("cCtaCteSerie", Request.cCtaCteSerie);
                        cm.Parameters.AddWithValue("nCtaCteNumIni", Request.nCtaCteNumIni);
                        cm.Parameters.AddWithValue("nCtaCtaNumFin", Request.nCtaCtaNumFin);
                        cm.Connection = cn;
                        Resultado = cm.ExecuteNonQuery();
                        Item.Resultado = Resultado;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }

        //Get_CtaCteNumeracion
        public DataTable Get_CtaCteNumeracion(BE_ReqCtaCteNumeracion Request)
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
                        cm.CommandText = "usp_Get_CtaCteNumeracion";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
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

        //Obtener Correlativo Actual "CtaCteNumeracion" por Tipo docu.
        public string Get_CtaCteNumCorrelativo(BE_ReqCtaCteNumeracion Request)
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
                        cm.CommandText = "[usp_Get_CtaCteNumCorrelativo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCajCodigo", Request.nCajCodigo);
                        cm.Parameters.AddWithValue("nComCodigo", Request.nComCodigo);
                        //Update 2016-07-15 (EINCIO)
                        cm.Parameters.AddWithValue("cCtaCteSerie_1", Request.cCtaCteSerie); 
                        //
                        cm.Connection = cn;

                        SqlParameter pSerie = new SqlParameter();
                        pSerie.ParameterName = "cCtaCteSerie";
                        pSerie.DbType = DbType.String;
                        pSerie.Size = 4;
                        pSerie.Direction = ParameterDirection.Output;

                        SqlParameter pCorrelativo = new SqlParameter();
                        pCorrelativo.ParameterName = "cCtaCteNumero";
                        pCorrelativo.DbType = DbType.String;
                        pCorrelativo.Size = 8;
                        pCorrelativo.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pSerie);
                        cm.Parameters.Add(pCorrelativo);
                        cm.ExecuteNonQuery();
                        //Item = cm.Parameters["cCtaCteSerie"].Value.ToString() + '-' + cm.Parameters["cCtaCteNumero"].Value.ToString();
                        Item = cm.Parameters["cCtaCteSerie"].Value.ToString() + cm.Parameters["cCtaCteNumero"].Value.ToString();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }

        //----------------------------------------
        // UPDATE CtaCteNumeracion (nCtaCteNumero)
        //----------------------------------------
        public bool Upd_CtaCteNumeracion_nCtaCteNumero(BE_ReqUpdCtaCteNumeracion Request)
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
                        cm.CommandText = "[usp_Upd_CtaCteNumeracion_nCtaCteNumero]";   
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCajCodigo", Request.nCajCodigo);
                        cm.Parameters.AddWithValue("nCtaCteComCodigo", Request.nCtaCteComCodigo);
                        cm.Parameters.AddWithValue("cCtaCteComNumero", Request.cCtaCteComNumero);
                        //Update 2016-07-15
                        cm.Parameters.AddWithValue("cCtaCteSerie", Request.cCtaCteSerie);
                        //
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("Se ha producido un error procedimiento almacenado: [usp_Upd_CtaCteNumeracion_nCtaCteNumero]; Consulte al administrador del sistema");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //Add 2015-11-26 (eincio)

        //------------------------------------
        // INSERT Medica.CtaCteDatosImpresora
        //------------------------------------
        public bool Ins_Medica_CtaCteDatosImpresora(BE_ReqCtaCteNumeracion Objeto)
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
                        cm.CommandText = "[usp_Ins_Medica_CtaCteDatosImpresora]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCajCodigo", Objeto.nCajCodigo);
                        cm.Parameters.AddWithValue("cSerie", Objeto.cCtaCteSerie);
                        cm.Parameters.AddWithValue("cNombreImpresora", Objeto.cNombreImpresora);
                        cm.Parameters.AddWithValue("cPort", Objeto.cPort);
                        cm.Parameters.AddWithValue("cCodAutSUNAT", Objeto.cCodAutSUNAT);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("Se ha producido un error procedimiento almacenado: [usp_Ins_Medica_CtaCteDatosImpresora]; Consulte al administrador del sistema");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        public bool Upd_Medica_CtaCteDatosImpresora(BE_ReqCtaCteNumeracion Objeto)
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
                        cm.CommandText = "[usp_Upd_Medica_CtaCteDatosImpresora]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Objeto.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCajCodigo", Objeto.nCajCodigo);
                        cm.Parameters.AddWithValue("cSerie", Objeto.cCtaCteSerie);
                        cm.Parameters.AddWithValue("cNombreImpresora", Objeto.cNombreImpresora);
                        cm.Parameters.AddWithValue("cPort", Objeto.cPort);
                        cm.Parameters.AddWithValue("cCodAutSUNAT", Objeto.cCodAutSUNAT);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("Se ha producido un error procedimiento almacenado: [usp_Upd_Medica_CtaCteDatosImpresora]; Consulte al administrador del sistema");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //Get_Medica_CtaCteDatosImpresora_by_cPerJurCodigo
        public DataTable Get_Medica_CtaCteDatosImpresora_by_cPerJurCodigo(BE_ReqCtaCteNumeracion Request)
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
                        cm.CommandText = "[usp_Get_Medica_CtaCteDatosImpresora_by_cPerJurCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
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
