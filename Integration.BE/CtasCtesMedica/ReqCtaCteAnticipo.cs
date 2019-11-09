using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtesMedica
{
    public class ReqCtaCteAnticipo
    {
        public string  cPerJurCodigo { get; set; }
        public string cCtaCteRecibo { get; set; }
        public int nCtaCteComCodigo { get; set; }
        public string cCtaCteComNumero { get; set; }
        public int nMonCodigo { get; set; }
        public double  fCtaCteImpAnti { get; set; }
        public int nCtaCteEstado { get; set; }
        public string cPerCodigo { get; set; }
    }
}
