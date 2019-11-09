using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class FichaResultados
    {
        public string dFecRegistro { get; set; }
        public string cConDescripcion { get; set; } 
        public string cPruebas { get; set; }
        public string cEstadoResultado { get; set; }
        public string nAdmSolEstado { get; set; }
        public string cPerCodigo { get; set; }
        public string cPerCodigoTerceros { get; set; }
        public string cPerJuridica { get; set; }
        public string nSolAdmNumero { get; set; }
        public string nIntCodigo { get; set; }
        public string cResultado { get; set; }
        public string cTiempoEntrega { get; set; }
        public string cPaciente { get; set; }

        public FichaResultados()
        {
            this.dFecRegistro = "";
            this.cConDescripcion = "";
            this.cPruebas = "";
            this.cEstadoResultado = "";
            this.nAdmSolEstado = "";
            this.cPerCodigo = "";
            this.cPerCodigoTerceros = "";
            this.cPerJuridica = "";
            this.nSolAdmNumero = "";
            this.nIntCodigo = "";
            this.cResultado = "";
            this.cTiempoEntrega = "";
            this.cPaciente = "";
        }

        public FichaResultados(string _dFecRegistro, string _cConDescripcion, string _cPruebas, string _cEstadoResultado, string _nAdmSolEstado, string _cPerCodigo,
                                string _cPerCodigoTerceros, string _cPerJuridica, string _nSolAdmNumero, string _nIntCodigo, string _cResultado, string _cTiempoEntrega, string _cPaciente)
        {
            this.dFecRegistro = _dFecRegistro;
            this.cConDescripcion = _cConDescripcion;
            this.cPruebas = _cPruebas;
            this.cEstadoResultado = _cEstadoResultado;
            this.nAdmSolEstado = _nAdmSolEstado;
            this.cPerCodigo = _cPerCodigo;
            this.cPerCodigoTerceros = _cPerCodigoTerceros;
            this.cPerJuridica = _cPerJuridica;
            this.nSolAdmNumero = _nSolAdmNumero;
            this.nIntCodigo = _nIntCodigo;
            this.cResultado = _cResultado;
            this.cTiempoEntrega = _cTiempoEntrega;
            this.cPaciente = _cPaciente;
        }

    }
}