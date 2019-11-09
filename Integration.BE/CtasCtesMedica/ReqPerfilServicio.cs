using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtesMedica
{
    public class ReqPerfilServicio
    {
        public string cPerJurCodigo { get; set; }
        public int nIntCodigo { get; set; }
        public int nCtaCteSerCodigo { get; set; }
        public int nMonCodigo { get; set; }
        public double  nCtaCteSerImpDef { get; set; }
        public string cPerCodigo { get; set; }
        public string nFlag { get; set; }
        public int nTipoAtencion { get; set; }
        public string cPerParCodigo { get; set; }
    }
}
