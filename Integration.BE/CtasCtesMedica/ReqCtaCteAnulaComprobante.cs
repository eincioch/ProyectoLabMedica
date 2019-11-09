using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtesMedica
{
    public class ReqCtaCteAnulaComprobante
    {
        public string cPerJurCodigo { get; set; }
        public string cPerCodigo { get; set; }
        public string cCtaCteRecibo { get; set; }
        public DateTime  dCtaCteComFecEmision { get; set; }
        public DateTime dCtaCteFecAnulacion { get; set; }
        public int nCtaCteComCodigo { get; set; }
        public string cCtaCteComNumero { get; set; }
        public double nCtaCteComImporte { get; set; }
        public string cPerUserCodigo { get; set; }
    }
}
