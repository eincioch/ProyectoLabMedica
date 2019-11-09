using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class Promotor
    {
        public string cPerCodigo { get; set; }
        public string promotor { get; set; }

        public Promotor() {
            this.cPerCodigo = "";
            this.promotor = "";
        }

        public Promotor(string cPerCodigo, string promotor) {
            this.cPerCodigo = cPerCodigo;
            this.promotor = promotor;
        }
    }
}