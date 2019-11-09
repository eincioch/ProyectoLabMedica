using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Sistema
{
    public class BE_ReqPeriodo
    {
	    public string cPerJurCodigo {get;set;}
        public int nSisGruCodigo { get; set; }
        public string cflag { get; set; }
        public string cAnno { get; set; }
        public int nObjCodigo { get; set; }
    }

    public class BE_ReqPeriodoUpd
    {
        public long nPrdCodigo { get; set; }
        public long nPrdEstado { get; set; }
    }

    public class BE_ReqPeriodoDefault
    {
        public long nPrdCodigo { get; set; }
        public string cAnno { get; set; }
    }
}
