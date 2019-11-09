using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class Muestra
    { 
        public string nIntJerarquia { get; set; } 
        public string cClase { get; set; }
        public string cNombreExamen { get; set; }
        public double nPrecio { get; set; }
        public string cPreparacion { get; set; }
        public string cProceso { get; set; }
        public string cFlag { get; set; }

        public Muestra()
        {
            this.nIntJerarquia = "";
            this.cClase="";
            this.cNombreExamen = "";
            this.nPrecio = 0.0;
            this.cPreparacion = "";
            this.cProceso = "";
            this.cFlag = "";
        }

        public  Muestra(string nIntJerarqui,
                        string cClase,
                        string cNombreExamen,
                        double nPrecio,
                        string cPreparacion,
                        string cProceso,
                        string cFlag)
        {
            this.nIntJerarquia = nIntJerarqui;
            this.cClase = cClase;
            this.cNombreExamen = cNombreExamen;
            this.nPrecio = nPrecio;
            this.cPreparacion = cPreparacion;
            this.cProceso = cProceso;
            this.cFlag = cFlag;
        }

    }
}