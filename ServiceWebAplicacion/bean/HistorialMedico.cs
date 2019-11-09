using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class HistorialMedico
    {

        private string _cApeDoctor;

        public string cApeDoctor
        {
            get { return _cApeDoctor; }
            set { _cApeDoctor = value; }
        }

        private string _cFecIni;

        public string cFecIni
        {
            get { return _cFecIni; }
            set { _cFecIni = value; }
        }

        private string _cFecFin;

        public string cFecFin
        {
            get { return _cFecFin; }
            set { _cFecFin = value; }
        }

        public HistorialMedico() {
            cApeDoctor = "";
            cFecIni = "";
            cFecFin = "";
        }

        public HistorialMedico(string cApeDoctor, string cFecIni, string cFecFin) {
            this.cApeDoctor = cApeDoctor;
            this.cFecIni = cFecIni;
            this.cFecFin = cFecFin;
        }

    }
}