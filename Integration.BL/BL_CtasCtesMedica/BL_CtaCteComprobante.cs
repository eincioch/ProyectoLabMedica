using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtesMedica;
using Integration.BE.FichaAtencion;
using Integration.DAService.DA_CtasCtesMedica;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.BL_CtasCtesMedica
{
    public class BL_CtaCteComprobante
    {
        public bool Ins_CtaCteComprobante(string cCtaCteRecibo, int nCtaCteComCodigo, string cCtaCteComNumero, int nCtaCteTipoPago, string cPerCodigo, DateTime dCtaCteEmiFecha)
        {
            bool exito = false;

            try
            {
                BE_ReqCtaCteComprobante Request = new BE_ReqCtaCteComprobante();
                Da_CtaCteComprobante ObjComprobante = new Da_CtaCteComprobante();

                Request.cCtaCteRecibo = cCtaCteRecibo;
                Request.nCtaCteComCodigo = nCtaCteComCodigo;
                Request.cCtaCteComNumero = cCtaCteComNumero;
                Request.nCtaCteTipoPago = nCtaCteTipoPago; //Al Contado / Credito
                Request.cPerCodigo = cPerCodigo;
                Request.dCtaCteEmiFecha = dCtaCteEmiFecha;

                if (!ObjComprobante.Ins_CtaCteComprobante(Request)) 
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCteComprobante].!");
                }
                else
                {
                    exito = true;
                }

                //exito = ObjComprobante.Ins_CtaCteComprobante(Request);
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        public bool Insert_CtaCteComprobante(BE_ReqCtaCteComprobante ctaCteComprobante)  {
                Da_CtaCteComprobante ctaCteComprobanteDAO = new Da_CtaCteComprobante();
                return ctaCteComprobanteDAO.Ins_CtaCteComprobante(ctaCteComprobante);
        }

        //----------------------------------------------------------
        //Obtengo Estructura "Cabecera" para el comprobante de venta
        //----------------------------------------------------------
        public DataTable Get_Fiscal_Header(string cPerJurCodigo, int nCtaCteComCodigo, string cCtaCteComNumero)
        {
            BE_ReqCtaCteImprimirDocuVta ReqParam = new BE_ReqCtaCteImprimirDocuVta();
            Da_CtaCteComprobante Obj = new Da_CtaCteComprobante();

            ReqParam.cPerJurCodigo = cPerJurCodigo;
            ReqParam.nCtaCteComCodigo = nCtaCteComCodigo;
            ReqParam.cCtaCteComNumero = cCtaCteComNumero;

            return Obj.Get_Fiscal_Header(ReqParam);

        }

        //----------------------------------------------------------
        //Obtengo Detalle de Documentos por pago de Anticipo
        //----------------------------------------------------------
        public DataTable Get_Detalle_DocuRef_Anticipo(string nSolAdmNumero)
        {
            BE_ReqSolAtencion ReqParam = new BE_ReqSolAtencion();
            Da_CtaCteComprobante Obj = new Da_CtaCteComprobante();

            ReqParam.nSolAdmNumero = nSolAdmNumero;

            return Obj.Get_Detalle_DocuRef_Anticipo (ReqParam);

        }

        //-------------------------------------------------------------
        //Obtengo Detalle de Documentos por pago por Nro Ficha Atencion
        //-------------------------------------------------------------
        public DataTable Get_Detalle_DocuRef_by_nSolAdmNumero(string nSolAdmNumero)
        {
            BE_ReqSolAtencion ReqParam = new BE_ReqSolAtencion();
            Da_CtaCteComprobante Obj = new Da_CtaCteComprobante();

            ReqParam.nSolAdmNumero = nSolAdmNumero;

            return Obj.Get_Detalle_DocuRef_by_nSolAdmNumero(ReqParam);

        }

    }
}
