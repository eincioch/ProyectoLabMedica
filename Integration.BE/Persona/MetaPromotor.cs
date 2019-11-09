using System;
using Integration.BE.Interface;

namespace Integration.BE.Persona
{
    /// <summary>
    /// Clase MetaPromotor
    /// </summary>
    public class MetaPromotor
    {
        private string _cPerJurCodigo;

        /// <summary>
        /// Campo cPerJurCodigo Grupo Empresa
        /// </summary>
        public string cPerJurCodigo
        {
            get { return _cPerJurCodigo; }
            set { _cPerJurCodigo = value; }
        }

        private int _nIntSrcCodigo;

        public int nIntSrcCodigo
        {
            get { return _nIntSrcCodigo; }
            set { _nIntSrcCodigo = value; }
        }             

        private int _nPrdCodigo;

        public int nPrdCodigo
        {
            get { return _nPrdCodigo; }
            set { _nPrdCodigo = value; }
        }

        private string _cPerPromCodigo;

        public string cPerPromCodigo
        {
            get { return _cPerPromCodigo; }
            set { _cPerPromCodigo = value; }
        }

        private int _nIntDstCodigo;

        public int nIntDstCodigo
        {
            get { return _nIntDstCodigo; }
            set { _nIntDstCodigo = value; }
        }
        

        private decimal _nMetValor;

        public decimal nMetValor
        {
            get { return _nMetValor; }
            set { _nMetValor = value; }
        }

        private string _cPerUsuCrea;

        public string cPerUsuCrea
        {
            get { return _cPerUsuCrea; }
            set { _cPerUsuCrea = value; }
        }

        private DateTime _dFechaCrea;

        public DateTime dFechaCrea
        {
            get { return _dFechaCrea; }
            set { _dFechaCrea = value; }
        }

        private string _cPerUsuModi;

        public string cPerUsuModi
        {
            get { return _cPerUsuModi; }
            set { _cPerUsuModi = value; }
        }

        private DateTime _dFechaModi;

        public DateTime dFechaModi
        {
            get { return _dFechaModi; }
            set { _dFechaModi = value; }
        }

        /// <summary>
        /// Clase Interface
        /// </summary>
        private BE_ReqInterface _interface;

        public BE_ReqInterface objInterface
        {
            get { return _interface; }
            set { _interface = value; }
        }
        

    }
}
