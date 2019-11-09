using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.Persona
{
    public class PerAsigDetalle
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

        private string cNombres;

        public string _cNombres
        {
            get { return cApellidoMedico + ' ' + cNombreMedico; }
            set {  }
        }

        private string cPerPromCodigo;

        public string _cPerPromCodigo
        {
            get { return cPerPromCodigo; }
            set { cPerPromCodigo = value; }
        }

        

    }
}
