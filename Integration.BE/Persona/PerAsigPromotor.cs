using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.Persona
{
    public class PerAsigPromotor
    {
        private string _cPerPromCodigo;

        public string cPerPromCodigo
        {
            get { return _cPerPromCodigo; }
            set { _cPerPromCodigo = value; }
        }

        private string _cPerAsigCodigo;

        public string cPerAsigCodigo
        {
            get { return _cPerAsigCodigo; }
            set { _cPerAsigCodigo = value; }
        }

        private DateTime _dEffDate;

        public DateTime dEffDate
        {
            get { return _dEffDate; }
            set { _dEffDate = value; }
        }

        private int _nPerAsigTipo;

        public int nPerAsigTipo
        {
            get { return _nPerAsigTipo; }
            set { _nPerAsigTipo = value; }
        }

        private int _nPerAsigEstado;

        public int nPerAsigEstado
        {
            get { return _nPerAsigEstado; }
            set { _nPerAsigEstado = value; }
        }
        
        //ficticio
        private string _cNameDoctor;

        public string cNameDoctor
        {
            get { return _cNameDoctor; }
            set { _cNameDoctor = value; }
        }
        
        
    }
}
