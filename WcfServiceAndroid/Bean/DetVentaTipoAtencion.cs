using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion
{
    public class DetVentaTipoAtencion
    {
        public string cPerJuridica { get; set; }
        public string Sucursal { get; set; }
        public int nIntCodigo { get; set; }
        public string cIntDescripcion { get; set; }
        public int QtyFichas { get; set; }
        public double fCtaCteImporteB { get; set; }
        public double fCtaCteImporteG { get; set; } 

        public DetVentaTipoAtencion() {
            this.cPerJuridica = "";
            this.Sucursal = "";
            this.nIntCodigo = 0;
            this.cIntDescripcion = "";
            this.QtyFichas = 0;
            this.fCtaCteImporteB = 0.0;
            this.fCtaCteImporteG = 0.0;
        }

        public DetVentaTipoAtencion(string cPerJuridica,
                                     string Sucursal,
                                     int nIntCodigo,
                                     string cIntDescripcion,
                                     int QtyFichas,
                                     double fCtaCteImporteB,
                                     double fCtaCteImporteG) {
            this.cPerJuridica = cPerJuridica;
            this.Sucursal = Sucursal;
            this.nIntCodigo = nIntCodigo;
            this.cIntDescripcion = cIntDescripcion;
            this.QtyFichas = QtyFichas;
            this.fCtaCteImporteB = fCtaCteImporteB;
            this.fCtaCteImporteG = fCtaCteImporteG;
        }
    }
}