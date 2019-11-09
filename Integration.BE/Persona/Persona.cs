using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.Persona
{
    public class Persona
    {
        public string cPerCodigo { get; set; }
        public string cPerApellido { get; set; }
        public string cPerNombre { get; set; }
        public DateTime dPerNacimiento { get; set; }
        public int nPerTipo { get; set; }
        public int nPerEstado { get; set; }
        public string cUbiGeoCodigo { get; set; }
        public string cperestadobiblio { get; set; }
        public int nUbiGeoCodigo { get; set; }
        public DateTime dPerDate { get; set; }
    }
}
