using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class ComisionDoctor
    {
        public string cPerCodigoDoctor { get; set; }
        public string Medico { get; set; }
        public int nPacientes { get; set; }
        public int nFichas { get; set; }
        public double fComision { get; set; }
        public int nFlagComision { get; set; } 

        public ComisionDoctor() {
            this.cPerCodigoDoctor = "";
            this.Medico = "";
            this.nPacientes = 0;
            this.nFichas = 0;
            this.fComision = 0.0;
            this.nFlagComision = 0;
        }

        public ComisionDoctor(string cPerCodigoDoctor,
                                string Medico,
                                int nPacientes,
                                int nFichas,
                                double fComision,
                                int nFlagComision) {
            this.cPerCodigoDoctor = cPerCodigoDoctor;
            this.Medico = Medico;
            this.nPacientes = nPacientes;
            this.nFichas = nFichas;
            this.fComision = fComision;
            this.nFlagComision = nFlagComision;
        }
    
   }
}