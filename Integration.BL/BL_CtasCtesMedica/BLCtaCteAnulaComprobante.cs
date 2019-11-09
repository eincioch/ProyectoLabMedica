using System;
using Integration.BE.CtasCtesMedica;
using Integration.DAService.DA_CtasCtesMedica;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BL.BL_CtasCtesMedica
{
    public class BLCtaCteAnulaComprobante
    {
        //--------------------------------
        // Insert CtaCteAnulaComprobante
        //---------------------------------
        public bool Ins_CtaCteAnulaComprobante(string cPerJurCodigo, string cPerCodigo, string cCtaCteRecibo, DateTime dCtaCteComFecEmision, int nCtaCteComCodigo, string cCtaCteComNumero, double nCtaCteComImporte, string cPerUserCodigo)
        {
            ReqCtaCteAnulaComprobante Objeto = new ReqCtaCteAnulaComprobante();
            DACtaCteAnulaComprobante da = new DACtaCteAnulaComprobante();

            Objeto.cPerJurCodigo = cPerJurCodigo;
            Objeto.cPerCodigo = cPerCodigo;
            Objeto.cCtaCteRecibo = cCtaCteRecibo;
            Objeto.dCtaCteComFecEmision = dCtaCteComFecEmision; 
            Objeto.nCtaCteComCodigo = nCtaCteComCodigo; 
            Objeto.cCtaCteComNumero = cCtaCteComNumero;
            Objeto.nCtaCteComImporte = nCtaCteComImporte;
            Objeto.cPerUserCodigo = cPerUserCodigo;

            return da.Ins_CtaCteAnulaComprobante(Objeto);
        }
    }
}
