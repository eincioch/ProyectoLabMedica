using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.CtasCtesMedica;
using Integration.DAService.DA_CtasCtesMedica;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_CtasCtesMedica
{
    public class BLCtaCteIntDetalle
    {
        //------------------------
        // Insert CtaCteIntDetalle
        //------------------------
        public bool Ins_CtaCteIntDetalle(string cCtaCteRecibo, int nIntCodigo, int nIntClase, string cIntJerarquia, string cIntValor)
        {
            ReqCtaCteIntDetalle Objeto = new ReqCtaCteIntDetalle();
            DACtaCteIntDetalle da = new DACtaCteIntDetalle();

            Objeto.cCtaCteRecibo = cCtaCteRecibo;
            Objeto.nIntCodigo = nIntCodigo;
            Objeto.nIntClase = nIntClase; 
            Objeto.cIntJerarquia = cIntJerarquia;
            Objeto.cIntValor = cIntValor; 

            return da.Ins_CtaCteIntDetalle(Objeto);
        }

        
    }
}
