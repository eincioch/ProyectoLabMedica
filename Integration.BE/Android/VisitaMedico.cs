using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.Android
{
    public class VisitaMedico
    {
        private String _cPerPromCodigo;
        public String cPerPromCodigo
        {
            get { return _cPerPromCodigo; }
            set { _cPerPromCodigo = value; }
        }

        private String _cPerAsigCodigo;
        public String cPerAsigCodigo
        {
            get { return _cPerAsigCodigo; }
            set { _cPerAsigCodigo = value; }
        }

        private String _dVisFechaHora;
        public String dVisFechaHora
        {
            get { return _dVisFechaHora; }
            set { _dVisFechaHora = value; }
        }

        private double _dVisLatitud;

        public double dVisLatitud
        {
            get { return _dVisLatitud; }
            set { _dVisLatitud = value; }
        }
        private double _dVisLongitud;

        public double dVisLongitud
        {
            get { return _dVisLongitud; }
            set { _dVisLongitud = value; }
        }

        private string _cVisObservacion;

        public string cVisObservacion
        {
            get { return _cVisObservacion; }
            set { _cVisObservacion = value; }
        }


    }
}
