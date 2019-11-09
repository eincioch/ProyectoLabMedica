using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class Medico 
    {
        private String cPerAsigCodigo;

        public String _cPerAsigCodigo
        {
            get { return cPerAsigCodigo; }
            set { cPerAsigCodigo = value; }
        }

        private String cNombres;

        public String _cNombres
        {
            get { return cNombres; }
            set { cNombres = value; }
        }

        private double _nComision;

        public double nComision
        {
            get { return _nComision; }
            set { _nComision = value; }
        }
        
        private String cApellidosMedico;

        public String _cApellidosMedico
        {
            get { return cApellidosMedico; }
            set { cApellidosMedico = value; }
        }

        private String cNombreMedico;

        public String _cNombreMedico
        {
            get { return cNombreMedico; }
            set { cNombreMedico = value; }
        }

        public Medico() {
            this._cPerAsigCodigo = "";
            this._cNombres = "";
            this._nComision = 0.0;
        }

        public Medico(String cperasigCodigo, String cnombres, Double ncomision=0)
        {
            this._cPerAsigCodigo = cperasigCodigo;
            this._cNombres = cnombres;
            this._nComision = ncomision;
        }

        public Medico(String cperasigCodigo, String cnombres, String capellidosmedico, String cnombremedico)
        {
            this._cPerAsigCodigo = cperasigCodigo;
            this._cNombres = cnombres;
            this._cApellidosMedico = capellidosmedico;
            this._cNombreMedico = cnombremedico;
        }

    }
}