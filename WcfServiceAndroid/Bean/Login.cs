using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class Login
    {
        public string cPerCodigo { get; set; }
        public string cClave { get; set; }
        public string cPermisos { get; set; }
        public string cPermisoMenu { get; set; }

        public Login()
        {
            this.cPerCodigo = "";
            this.cClave = "";
            this.cPermisos = "";
            this.cPermisoMenu = "";
        }

        public Login(string cPerCodigo,
                        string cClave,
                        string cPermisos,
                        string cPermisoMenu)
        {
            this.cPerCodigo = cPerCodigo;
            this.cClave = cClave;
            this.cPermisos = cPermisos;
            this.cPermisoMenu = cPermisoMenu;
        }

        
    }
}