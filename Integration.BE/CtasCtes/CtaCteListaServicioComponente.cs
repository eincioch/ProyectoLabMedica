using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.CtasCtes
{
    public class CtaCteListaServicioComponente{
 
    #region "Declaraciones"
 
        private int _nCtaCteSerCodigo;
        private string _cPerJurcodigo;
        private int _nTipoAtencionCodigo;
        private int _nCtaCteSerCmpCodigo;
        private int _nCtaCteSerCmpUndDestino;
        private decimal _nCtaCteSerCmpCantidad;
        private int _nCtaCteSerCmpEstado;
        private string _cPerUsuCodigo;
        private string _strXML;
 
    #endregion
 
    #region "Propiedades"
 
        public int nCtaCteSerCodigo{
            get{
                return _nCtaCteSerCodigo;
            }
            set{
                _nCtaCteSerCodigo = value;
            }
        }  
 
        public string cPerJurcodigo{
            get{
                return _cPerJurcodigo;
            }
            set {
                _cPerJurcodigo = value;
            }
        }  
 
        public int nTipoAtencionCodigo{
            get{
                return _nTipoAtencionCodigo;
            }
            set {
                _nTipoAtencionCodigo = value;
            }
        }  
 
        public int nCtaCteSerCmpCodigo{
            get{
                return _nCtaCteSerCmpCodigo;
            }
            set {
                _nCtaCteSerCmpCodigo = value;
            }
        }  
 
        public int nCtaCteSerCmpUndDestino{
            get{
                return _nCtaCteSerCmpUndDestino;
            }
            set {
                _nCtaCteSerCmpUndDestino = value;
            }
        }  
 
        public decimal nCtaCteSerCmpCantidad{
            get{
                return _nCtaCteSerCmpCantidad;
            }
            set {
                _nCtaCteSerCmpCantidad = value;
            }
        }  
 
        public int nCtaCteSerCmpEstado{
            get{
                return _nCtaCteSerCmpEstado;
            }
            set {
                _nCtaCteSerCmpEstado = value;
            }
        }

        public string cPerUsuCodigo
        {
            get
            {
                return _cPerUsuCodigo;
            }
            set
            {
                _cPerUsuCodigo = value;
            }
        }  

        public string strXML
        {
            get
            {
                return _strXML;
            }
            set
            {
                _strXML = value;
            }
        }  
 
 
    #endregion
 
    #region "Constructors"
 
        public CtaCteListaServicioComponente() {
        
        }  
 
        public CtaCteListaServicioComponente(int nCtaCteSerCodigo, string cPerJurcodigo, int nTipoAtencionCodigo, int nCtaCteSerCmpCodigo, int nCtaCteSerCmpUndDestino, decimal nCtaCteSerCmpCantidad, int nCtaCteSerCmpEstado) : this() {
        }  
 
    #endregion
 
    }
}
