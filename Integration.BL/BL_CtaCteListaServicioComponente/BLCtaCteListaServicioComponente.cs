using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.CtasCtes;
using Integration.DAService.DA_CtaCteListaServicioComponente;

namespace Integration.BL.BL_CtaCteListaServicioComponente
{
    public class BLCtaCteListaServicioComponente
    {
        //---------------------------------------------------
        //Insert CtaCteListaServicioComponente en Bloque con XML
        //---------------------------------------------------
        //public bool Ins_CtaCteListaServicioComponente_By_XML(string pstrXML, int pnCtaCteSerCodigo, int pnTipoAtencionCodigo, string pcPerJurCodigo, string pcPerUsuCodigo)
        //{
        //    CtaCteListaServicioComponente Objeto = new CtaCteListaServicioComponente();

        //    Objeto.strXML = pstrXML;
        //    Objeto.nCtaCteSerCodigo = pnCtaCteSerCodigo;
        //    Objeto.nTipoAtencionCodigo = pnTipoAtencionCodigo;
        //    Objeto.cPerJurcodigo = pcPerJurCodigo;
        //    Objeto.cPerUsuCodigo = pcPerUsuCodigo;

        //    DACtaCteListaServicioComponente Obj = new DACtaCteListaServicioComponente();
        //    return Obj.Ins_CtaCteListaServicioComponente_By_XML(Objeto);
        //}
        public bool Ins_CtaCteListaServicioComponente_By_XML(CtaCteListaServicioComponente Objeto)
        {

            DACtaCteListaServicioComponente Obj = new DACtaCteListaServicioComponente();
            return Obj.Ins_CtaCteListaServicioComponente_By_XML(Objeto);
        }


    }
}
