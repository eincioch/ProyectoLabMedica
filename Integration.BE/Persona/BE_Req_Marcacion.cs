using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.Persona
{
    public class BE_Req_Marcacion
    {
        public string cPerCodigo { get; set; }
        public int nPerIdeTipo { get; set; }
        public string cPerIdeNumero { get; set; }
        public string cFechaHora { get; set; }
        public string cHost { get; set; }
        public int nDeviceID { get; set; }
        public string cPerJurCodigo { get; set; }
    }
}
