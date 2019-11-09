using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class EncSatisfaccion
    {
        private string _pregunta;

        public string pregunta
        {
            get { return _pregunta; }
            set { _pregunta = value; }
        }

        private string _bueno;

        public string bueno
        {
            get { return _bueno; }
            set { _bueno = value; }
        }

        private string _regular;

        public string regular
        {
            get { return _regular; }
            set { _regular = value; }
        }

        private string _malo;

        public string malo
        {
            get { return _malo; }
            set { _malo = value; }
        }

        public EncSatisfaccion() {
            this.pregunta = "";
            this.bueno = "";
            this.regular = "";
            this.malo = "";
        }

        public EncSatisfaccion(string pregunta, string bueno, string regular, string malo) { 
            this.pregunta = pregunta;
            this.bueno = bueno;
            this.regular = regular;
            this.malo = malo;
        }

    }
}