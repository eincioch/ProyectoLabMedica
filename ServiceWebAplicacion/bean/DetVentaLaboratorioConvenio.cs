using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion
{
    public class DetVentaLaboratorioConvenio
    {
        public string cPerJuridica { get; set; }
        public string Sucursal { get; set; }
        public int nIntCodigo { get; set; }
        public string cIntDescripcion { get; set; }
        public string cPerCodigoTerceros { get; set; }
        public string Cliente { get; set; }
        public int QtyFichas { get; set; }
        public double fCtaCteImporteB { get; set; }
        public double fCtaCteImporteG { get; set; }

        public DetVentaLaboratorioConvenio() { 
            this.cPerJuridica="";
            this.Sucursal="";
            this.nIntCodigo=0;
            this.cIntDescripcion="";
            this.cPerCodigoTerceros="";
            this.Cliente="";
            this.QtyFichas=0;
            this.fCtaCteImporteB =0.0;
            this.fCtaCteImporteG = 0.0;
        }

        public DetVentaLaboratorioConvenio(string cPerJuridica,
                             string Sucursal,
                             int nIntCodigo ,
                             string cIntDescripcion,
                             string cPerCodigoTerceros,
                             string Cliente,
                             int QtyFichas,
                             double fCtaCteImporteB,
                             double fCtaCteImporteG)
        {
            this.cPerJuridica = cPerJuridica;
            this.Sucursal = Sucursal;
            this.nIntCodigo = nIntCodigo;
            this.cIntDescripcion = cIntDescripcion;
            this.cPerCodigoTerceros = cPerCodigoTerceros;
            this.Cliente = Cliente;
            this.QtyFichas = QtyFichas;
            this.fCtaCteImporteB = fCtaCteImporteB;
            this.fCtaCteImporteG = fCtaCteImporteG;
        }

    }
}