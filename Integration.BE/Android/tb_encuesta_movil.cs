using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.Android
{
    public class tb_encuesta_movil
    {
        public string cPerJurCodigo { get; set; }
        public string cPerPromotorCodigo { get; set; }

        public string cPerAsigCodigo { get; set; }
        public string cMedicoNoRegistra { get; set; }

        public int nRespuesta01 { get; set; }
        public int nRespuesta02 { get; set; }
        public int nRespuesta03 { get; set; }
        public int nRespuesta04 { get; set; }
        public int nRespuesta05 { get; set; }
        public string nObservacion { get; set; }
        public string cUserReg { get; set; }
        public double platitub { get; set; }
        public double plongitub { get; set; }
    }
}
