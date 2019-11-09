using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class Campana
    {
        public int nIntCamp { get; set; }
        public string cNombreCamp { get; set; }
        public double Precio { get; set; }

        public Campana()
        {
            this.nIntCamp =0;
            this.cNombreCamp ="";
            this.Precio = 0.0;
        }

        public Campana(int nIntCamp,
                        string cNombreCamp,
                        double Precio)
        {
            this.nIntCamp = nIntCamp;
            this.cNombreCamp = cNombreCamp;
            this.Precio = Precio;
        }
    }
}