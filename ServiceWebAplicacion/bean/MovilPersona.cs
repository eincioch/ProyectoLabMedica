using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class MovilPersona
    {
        public string nPerIdeTipo { get; set; }
        public string cPerIdeNumero { get; set; }
        public string cPerApellido { get; set; }
        public string cPerNombre { get; set; }
        public string dPerNacimiento { get; set; }

        public MovilPersona(){
            this.nPerIdeTipo = "";
            this.cPerIdeNumero = "";
            this.cPerApellido = "";
            this.cPerNombre = "";
            this.dPerNacimiento="";
        }

        public MovilPersona(string nPerIdeTipo,
                        string cPerIdeNumero,
                        string cPerApellido,
                        string cPerNombre,
                        string dPerNacimiento){

            this.nPerIdeTipo = nPerIdeTipo;
            this.cPerIdeNumero = cPerIdeNumero;
            this.cPerApellido = cPerApellido;
            this.cPerNombre = cPerNombre;
            this.dPerNacimiento = dPerNacimiento;
        }
    }
}