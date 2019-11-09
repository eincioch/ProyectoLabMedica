using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion
{
    public class DetVentaPendientePorCobrar
    {
        public string cPerJuridica { get; set; }
        public string Sucursal { get; set; }
        public string cPerCodigoTerceros { get; set; }
        public string Cliente { get; set; }
        public double nSaldo { get; set; }
        public double fCtaCtePagImportecred { get; set; }
        public double fImpTotal { get; set; }


        public DetVentaPendientePorCobrar()
        {
            this.cPerJuridica ="";   
            this.Sucursal ="";
            this.cPerCodigoTerceros="";
            this.Cliente ="";
            this.nSaldo =0.0;
            this.fCtaCtePagImportecred =0.0;
            this.fImpTotal = 0.0;
        }

        public DetVentaPendientePorCobrar(string cPerJuridica,
                                             string Sucursal,
                                             string cPerCodigoTerceros,
                                             string Cliente,
                                             double nSaldo,
                                             double fCtaCtePagImportecred ,
                                             double fImpTotal)
        {

            this.cPerJuridica = cPerJuridica;
            this.Sucursal = Sucursal;
            this.cPerCodigoTerceros = cPerCodigoTerceros;
            this.Cliente = Cliente;
            this.nSaldo = nSaldo;
            this.fCtaCtePagImportecred = fCtaCtePagImportecred;
            this.fImpTotal = fImpTotal;
        }
        
    }
}