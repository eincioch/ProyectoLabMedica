using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.AdmSolPerToken
{
    public class AdmSolPerToken
    {
        private string _cPerCodigo;
        private string _cPerJurCodigo;
        private string _cToken;
        private int _nTipo;
        private double _fPorcentaje;
        private int _nFlag;
        private DateTime _dFechaHoraCaduc;
        private string _nSolAdmNumero;

        //Update 2016-03-18 (EINCIO)
        private string _cPerUsuCodigo;

        public string cPerUsuCodigo
        {
            get { return _cPerUsuCodigo; }
            set { _cPerUsuCodigo = value; }
        }

        public string cPerCodigo
        {
            get { return _cPerCodigo; }
            set { _cPerCodigo = value; }
        }
              
        public string cPerJurCodigo
        {
            get { return _cPerJurCodigo; }
            set { _cPerJurCodigo = value; }
        }               

        public string cToken
        {
            get { return _cToken; }
            set { _cToken = value; }
        }        

        public int nTipo
        {
            get { return _nTipo; }
            set { _nTipo = value; }
        }            

        public double fPorcentaje
        {
            get { return _fPorcentaje; }
            set { _fPorcentaje = value; }
        }       

        public int nFlag
        {
            get { return _nFlag; }
            set { _nFlag = value; }
        }       

        public DateTime dFechaHoraCaduc
        {
            get { return _dFechaHoraCaduc; }
            set { _dFechaHoraCaduc = value; }
        }        

        public string nSolAdmNumero
        {
            get { return _nSolAdmNumero; }
            set { _nSolAdmNumero = value; }
        }
        
        
    }
}
