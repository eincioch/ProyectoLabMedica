using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.CtasCtesMedica
{
    public class ReqCtaCteIntDetalle
    {
        public string cCtaCteRecibo { get; set; }
        public int nIntCodigo { get; set; }
        public int nIntClase { get; set; }
        public string cIntJerarquia { get; set; }
        public string  cIntValor { get; set; }
    }
}
