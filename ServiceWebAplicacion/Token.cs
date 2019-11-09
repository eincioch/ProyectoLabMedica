using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceWebAplicacion
{
    public class Token
    {
        public string cToken { get; set; }

        public Token() { 
            this.cToken="";
        }

        public Token(string cToken) {
            this.cToken = cToken;
        }
    }
}
