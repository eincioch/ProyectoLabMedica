using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Integration.BE.CtasCtesMedica;
using Integration.BE.FichaAtencion;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_CtasCtesMedica
{
    public class Da_CtaCteComprobante
    {
        //--------------------------
        // Insert CtaCteComprobante
        //-------------------------
        public bool Ins_CtaCteComprobante(BE_ReqCtaCteComprobante Request) 
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
                        cm.CommandText = "[usp_Ins_CtaCteComprobante]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);     
                        cm.Parameters.AddWithValue("nCtaCteComCodigo", Request.nCtaCteComCodigo);  //Constante (1063) Tipo Docu. BOL-FACT-TICK
                        cm.Parameters.AddWithValue("cCtaCteComNumero", Request.cCtaCteComNumero);  //SERIE+CORRELATIVO
                        cm.Parameters.AddWithValue("nCtaCteTipoPago", Request.nCtaCteTipoPago);    //Constante (3002) 1 - Al Contado
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);  //Persona (Cliente)

                        //Update 2016-03-16
                        cm.Parameters.AddWithValue("dCtaCteEmiFecha", Request.dCtaCteEmiFecha);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("Se ha producido error procedimiento almacenado: [usp_Ins_CtaCteComprobante]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //----------------------------------------------------------
        //Obtengo Estructura "Cabecera" para el comprobante de venta
        //----------------------------------------------------------
        public DataTable Get_Fiscal_Header(BE_ReqCtaCteImprimirDocuVta Request)
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
                        cm.CommandText = "[usp_Get_Fiscal_Header]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCtaCteComCodigo", Request.nCtaCteComCodigo);
                        cm.Parameters.AddWithValue("cCtaCteComNumero", Request.cCtaCteComNumero);
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

        //----------------------------------------------------------
        //Obtengo Detalle de Documentos por pago de Anticipo
        //----------------------------------------------------------
        public DataTable Get_Detalle_DocuRef_Anticipo(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Get_Detalle_DocuRef_Anticipo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
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

        //-------------------------------------------------------------
        //Obtengo Detalle de Documentos por pago por Nro Ficha Atencion
        //-------------------------------------------------------------
        public DataTable Get_Detalle_DocuRef_by_nSolAdmNumero(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Get_Detalle_DocuRef_by_nSolAdmNumero]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
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
 