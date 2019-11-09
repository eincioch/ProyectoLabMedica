using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class MedicoDetalle
    {
        private string cPerAsigCodigo;

        public string _cPerAsigCodigo
        {
            get { return cPerAsigCodigo; }
            set { cPerAsigCodigo = value; }
        }

        private string cApellidoMedico;

        public string _cApellidoMedico
        {
            get { return cApellidoMedico; }
            set { cApellidoMedico = value; }
        }

        private string cNombreMedico;

        public string _cNombreMedico
        {
            get { return cNombreMedico; }
            set { cNombreMedico = value; }
        }
        private string cPerTelFijo;

        public string _cPerTelFijo
        {
            get { return cPerTelFijo; }
            set { cPerTelFijo = value; }
        }

        private string cPerTelCelular;

        public string _cPerTelCelular
        {
            get { return cPerTelCelular; }
            set { cPerTelCelular = value; }
        }

        private string cEspecialidad;

        public string _cEspecialidad
        {
            get { return cEspecialidad; }
            set { cEspecialidad = value; }
        }

        private string cNombreEstabPublic;

        public string _cNombreEstabPublic
        {
            get { return cNombreEstabPublic; }
            set { cNombreEstabPublic = value; }
        }

        private string cNombreEstabPriv;

        public string _cNombreEstabPriv
        {
            get { return cNombreEstabPriv; }
            set { cNombreEstabPriv = value; }
        }

        private string cConsultorio;

        public string _cConsultorio
        {
            get { return cConsultorio; }
            set { cConsultorio = value; }
        }

        private double dVentaMes;

        public double _dVentaMes
        {
            get { return dVentaMes; }
            set { dVentaMes = value; }
        }
        private int nCantidadMes;

        public int _nCantidadMes
        {
            get { return nCantidadMes; }
            set { nCantidadMes = value; }
        }

        private string cNombres;

        public string _cNombres
        {
            get { return cApellidoMedico + ' ' + cNombreMedico; }
            set { }
        }

        private string cPerPromCodigo;

        public string _cPerPromCodigo
        {
            get { return cPerPromCodigo; }
            set { cPerPromCodigo = value; }
        }

        private string cNombresPromotor;

        public string _cNombresPromotor
        {
            get { return cNombresPromotor; }
            set { cNombresPromotor = value; }
        }

        private int nPerTipo;

        public int _nPerTipo
        {
            get { return nPerTipo; }
            set { nPerTipo = value; }
        }

        public MedicoDetalle() {
            this._cPerAsigCodigo = "";
            this._cApellidoMedico = "";
            this._cNombreMedico = "";
            this._cPerTelFijo = "";
            this._cPerTelCelular = "";
            this._cNombres = "";
            this._cEspecialidad = "";
            this._cNombreEstabPublic = "";
            this._cNombreEstabPriv = "";
            this._cConsultorio = "";
            this._dVentaMes = 0.00;
            this._nCantidadMes = 0;
            this._cNombresPromotor = "";
            this._nPerTipo = 0;
        }

        public MedicoDetalle(String cperasigCodigo, String capellido, String cnombre, String cpertelfijo, String cpertelcelular, String cespecialidad, String cnombreestabpublic, String cnombreestabpriv, String cconsultorio, double dventames, int ncantidadmes, string cperpromcodigo, string cnombrespromotor, int npertipo)
        {
            this._cPerAsigCodigo = cperasigCodigo;
            this._cApellidoMedico = capellido;
            this._cNombreMedico = cnombre;
            this._cPerTelFijo = cpertelfijo;
            this._cPerTelCelular = cpertelcelular;
            this._cEspecialidad = cespecialidad;
            this._cNombreEstabPublic = cnombreestabpublic;
            this._cNombreEstabPriv = cnombreestabpriv;
            this._cConsultorio = cconsultorio;
            this._dVentaMes = dventames;
            this._nCantidadMes = ncantidadmes;
            this._cPerPromCodigo = cperpromcodigo;
            this._cNombresPromotor = cnombrespromotor;
            this._nPerTipo = npertipo;
        }

    }
}