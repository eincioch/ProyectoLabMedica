using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.CtasCtesMedica
{
    public class CtaCteReferencia
    {
        private string _cCtaCteRecibo;

        public string cCtaCteRecibo
        {
            get { return _cCtaCteRecibo; }
            set { _cCtaCteRecibo = value; }
        }

        private string _cCtaCteRefRecibo;

        public string cCtaCteRefRecibo
        {
            get { return _cCtaCteRefRecibo; }
            set { _cCtaCteRefRecibo = value; }
        }

        private int _nCtaCteRefTipo;

        public int nCtaCteRefTipo
        {
            get { return _nCtaCteRefTipo; }
            set { _nCtaCteRefTipo = value; }
        }

        private DateTime _dCtaCteRefFecha;

        public DateTime dCtaCteRefFecha
        {
            get { return _dCtaCteRefFecha; }
            set { _dCtaCteRefFecha = value; }
        }

        private string _cCtaCteRefGlosa;

        public string cCtaCteRefGlosa
        {
            get { return _cCtaCteRefGlosa; }
            set { _cCtaCteRefGlosa = value; }
        }

        private double _fCtaCteRefImporte;

        public double fCtaCteRefImporte
        {
            get { return _fCtaCteRefImporte; }
            set { _fCtaCteRefImporte = value; }
        }
                
        
    }
}
