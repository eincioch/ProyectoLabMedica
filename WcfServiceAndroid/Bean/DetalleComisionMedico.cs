using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class DetalleComisionMedico
    {
        public string Paciente { get; set; }
        public string Pruebas { get; set; }
        public Double fComision { get; set; }

        public DetalleComisionMedico() {
            this.Paciente = "";
            this.Pruebas = "";
            this.fComision = 0.0;
        }

        public DetalleComisionMedico(string Paciente, string Pruebas, Double fComision)
        {
            this.Paciente = Paciente;
            this.Pruebas = Pruebas;
            this.fComision = fComision;
        }

    }
}