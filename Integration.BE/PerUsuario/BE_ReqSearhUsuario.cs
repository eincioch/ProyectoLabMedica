using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.PerUsuario
{
    public class BE_ReqSearhUsuario
    {
        public string PerCodigo { get; set; }
        public string cPerUsuClave { get; set; }
        public string cPerUsuClave2 { get; set; }
        public string cPercodigo { get; set; }

        public string cPerUsuCodigo { get; set; }
        public int nSisGruCodigo { get; set; }
        public int nObjCodigo { get; set; }

        public string cModulo { get; set; }

        public string  cPerJurCodigo { get; set; }
    }

    public class BE_ReqCredencialesAndroid {
        public string PerCodigo { get; set; }
        public string cPerUsuClave { get; set; }
        public string cPerUsuClave2 { get; set; }
        public string cModulo { get; set; }
    }
}
