using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class VentaSucursalTurno
    {
        public string cPerJuridica { get; set; }
        public string cPerApellido { get; set; }
        //public int nTurno { get; set; }
        //public string cTurno { get; set; }
        public string cTipoAtencion { get; set; }
        //public double fImporte { get; set; }
        public double fManana { get; set; }
        public double fTarde { get; set; }
        public double fNoche { get; set; }

        public VentaSucursalTurno() {
            cPerJuridica = "";
            cPerApellido="";
            cTipoAtencion = "";
            fManana = 0.0;
            fTarde = 0.0;
            fNoche = 0.0;

            //nTurno=0;
            //cTurno="";
            //fImporte=0.0;
        }

        public VentaSucursalTurno(string cPerJuridica, string cPerApellido, string cTipoAtencion, double fmanana, double ftarde, double fnoche)
        {
            this.cPerJuridica = cPerJuridica;
            this.cPerApellido = cPerApellido;
            //this.nTurno = nTurno;
            //this.cTurno = cTurno;
            this.cTipoAtencion = cTipoAtencion;
            //this.fImporte = fImporte;
            this.fManana = fmanana;
            this.fTarde = ftarde;
            this.fNoche = fnoche;
        }
    }
}