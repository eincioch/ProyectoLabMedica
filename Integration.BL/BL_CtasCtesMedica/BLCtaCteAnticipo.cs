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
    public class BLCtaCteAnticipo
    {
        //----------------------
        // Insert CtaCteAnticipo
        //----------------------
        public bool Ins_CtaCteAnticipo(string cPerJurCodigo, string cCtaCteRecibo, int nCtaCteComCodigo, string cCtaCteComNumero, int nMonCodigo, double fCtaCteImpAnti, int nCtaCteEstado, string cPerUserCodigo)
        {
            ReqCtaCteAnticipo Objeto = new ReqCtaCteAnticipo();
            DACtaCteAnticipo da = new DACtaCteAnticipo();

            Objeto.cPerJurCodigo = cPerJurCodigo;
            Objeto.cCtaCteRecibo = cCtaCteRecibo;
            Objeto.nCtaCteComCodigo = nCtaCteComCodigo;
            Objeto.cCtaCteComNumero = cCtaCteComNumero;
            Objeto.nMonCodigo = nMonCodigo;
            Objeto.fCtaCteImpAnti = fCtaCteImpAnti;
            Objeto.nCtaCteEstado = nCtaCteEstado;
            Objeto.cPerCodigo = cPerUserCodigo;

            return da.Ins_CtaCteAnticipo(Objeto);
        }
    }
}
