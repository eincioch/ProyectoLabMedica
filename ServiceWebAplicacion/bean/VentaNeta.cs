using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class VentaNeta
    {
        public string cPerJuridica { get; set; }
        public string sucursal { get; set; }
        public double nEfectivo { get; set; }
        public double nCortesia { get; set; }

        public VentaNeta()
        {
            this.cPerJuridica = "";
            this.sucursal = "";
            this.nEfectivo = 0.0;
            this.nCortesia = 0.0;
        }

        public VentaNeta(string cPerJuridica,
                            string sucursal,
                            double nEfectivo,
                            double nCortesia)
        {
            this.cPerJuridica = cPerJuridica;
            this.sucursal = sucursal;
            this.nEfectivo = nEfectivo;
            this.nCortesia = nCortesia;
        }

        
    }
}