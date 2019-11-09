using System;


namespace Integration.BE.Persona
{
    public class PerOperacion
    {
        private int _nItem;

        public int nItem
        {
            get { return _nItem; }
            set { _nItem = value; }
        }

        private string _cPerJurCodigo;

        public string cPerJurCodigo
        {
            get { return _cPerJurCodigo; }
            set { _cPerJurCodigo = value; }
        }

        private DateTime  _dFecEvento;

        public DateTime  dFecEvento
        {
            get { return _dFecEvento; }
            set { _dFecEvento = value; }
        }

        private int _nOpeCodigo;

        public int nOpeCodigo
        {
            get { return _nOpeCodigo; }
            set { _nOpeCodigo = value; }
        }

        private Double _fMonto;

        public Double fMonto
        {
            get { return _fMonto; }
            set { _fMonto = value; }
        }

        private string _cOpeHost;

        public string cOpeHost
        {
            get { return _cOpeHost; }
            set { _cOpeHost = value; }
        }

        private string _cObservacion;

        public string cObservacion
        {
            get { return _cObservacion; }
            set { _cObservacion = value; }
        }
        
        
    }
}
