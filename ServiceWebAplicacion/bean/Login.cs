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
        public double cPorcentajeDesc { get; set; }

        public Login()
        {
            this.cPerCodigo = "";
            this.cClave = "";
            this.cPermisos = "";
            this.cPermisoMenu = "";
            this.cPorcentajeDesc = 0.0;
        }

        public Login(string cPerCodigo,
                        string cClave,
                        string cPermisos,
                        string cPermisoMenu,
                        double cPorcentajeDesc)
        {
            this.cPerCodigo = cPerCodigo;
            this.cClave = cClave;
            this.cPermisos = cPermisos;
            this.cPermisoMenu = cPermisoMenu;
            this.cPorcentajeDesc = cPorcentajeDesc;
        }

        
    }
}