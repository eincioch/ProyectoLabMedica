using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class VisitaDiaMedico
    {
        private string _cMedico;

        public string cMedico
        {
            get { return _cMedico; }
            set { _cMedico = value; }
        }
        private string _cFechaHora;

        public string cFechaHora
        {
            get { return _cFechaHora; }
            set { _cFechaHora = value; }
        }
        private string _cPerAsigCodigo;

        public string cPerAsigCodigo
        {
            get { return _cPerAsigCodigo; }
            set { _cPerAsigCodigo = value; }
        }
        private string _cPerPromCodigo;

        public string cPerPromCodigo
        {
            get { return _cPerPromCodigo; }
            set { _cPerPromCodigo = value; }
        }
        private string _cPromotor;

        public string cPromotor
        {
            get { return _cPromotor; }
            set { _cPromotor = value; }
        }


        public VisitaDiaMedico() {
            this._cMedico = "";
            this._cFechaHora = "";
            this._cPerAsigCodigo = "";
            this._cPerPromCodigo = "";
            this._cPromotor = "";
        }

        public VisitaDiaMedico(String cmedico, String cfechahora, String cperasigcodigo, String cperpromcodigo, String cpromotor)
        {
            this._cMedico = cmedico;
            this._cFechaHora = cfechahora;
            this._cPerAsigCodigo = cperasigcodigo;
            this._cPerPromCodigo = cperpromcodigo;
            this._cPromotor = cpromotor;
        }


    }
}