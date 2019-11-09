using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion
{
    public class Ventas
    {
        
        public string cPerJuridica { get; set; }
        public string cPerApellido { get; set; }
        public int nQtyFicha { get; set; }
        public int nCantMuestra { get; set; }
        public double nImpTotal { get; set; }
        public double nCtaCteCosto { get; set; }
        public string cCtaCteRecibo { get; set; }
        public double fCtaCteImporteB { get; set; }
        public double fCtaCtePagImporte { get; set; }
        public double fCtaCtePagImportet { get; set; }
        public double fCtaCtePagImportec { get; set; }
        public double fCtaCteImporte { get; set; }
        public double nImpTotalBruto { get; set; }
        public double fCtaCteImporteSinIGV { get; set; }
        public double nSaldoPendienteporPagar { get; set; }

        public Ventas() {
            this.cPerJuridica = "";
            this.cPerApellido = "";
            this.nQtyFicha = 0;
            this.nCantMuestra = 0;
            this.nImpTotal = 0.0;
            this.nCtaCteCosto = 0.0;
            this.cCtaCteRecibo = "";
            this.fCtaCteImporteB = 0.0;
            this.fCtaCtePagImporte = 0.0;
            this.fCtaCtePagImportet = 0.0;
            this.fCtaCtePagImportec = 0.0;
            this.fCtaCteImporte = 0.0;
            this.nImpTotalBruto = 0.0;
            this.fCtaCteImporteSinIGV = 0.0;
            this.nSaldoPendienteporPagar = 0.0;
        }		

        public Ventas(string cPerJuridica,
                         string cPerApellido,
                         int nQtyFicha,
                         int nCantMuestra,
                         double nImpTotal,
                         double nCtaCteCosto,
                         string cCtaCteRecibo,
                         double fCtaCteImporteB,
                         double fCtaCtePagImporte,
                         double fCtaCtePagImportet,
                         double fCtaCtePagImportec,
                         double fCtaCteImporte,
                         double nImpTotalBruto,
                         double fCtaCteImporteSinIGV,
                         double nSaldoPendienteporPagar 
            ){

            this.cPerJuridica = cPerJuridica;
            this.cPerApellido = cPerApellido;
            this.nQtyFicha=nQtyFicha;
            this.nCantMuestra=nCantMuestra;
            this.nImpTotal=nImpTotal;
            this.nCtaCteCosto=nCtaCteCosto;
            this.cCtaCteRecibo=cCtaCteRecibo;
            this.fCtaCteImporteB=fCtaCteImporteB;
            this.fCtaCtePagImporte=fCtaCtePagImporte;
            this.fCtaCtePagImportet=fCtaCtePagImportet;
            this.fCtaCtePagImportec=fCtaCtePagImportec;
            this.fCtaCteImporte=fCtaCteImporte;
            this.nImpTotalBruto=nImpTotalBruto;
            this.fCtaCteImporteSinIGV=fCtaCteImporteSinIGV;
            this.nSaldoPendienteporPagar=nSaldoPendienteporPagar;

        }


    }
}