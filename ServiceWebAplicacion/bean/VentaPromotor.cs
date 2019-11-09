using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class VentaPromotor
    {
        public string cPerPromCodigo { get; set; }
        public string tipo { get; set; }
        public double nMeta { get; set; }
        public double nAvance { get; set; }
        public double nNecesidadDia { get; set; }
        public double nImporteFaltante { get; set; }
        public string cPerPromName { get; set; }
        public string nIntSrcCodigo { get; set; }
        public int nAtenciones { get; set; }
        public string cPerTercero { get; set; }

        public VentaPromotor()
        {
            this.cPerPromCodigo = "";
            this.tipo = "";
            this.nMeta = 0.0;
            this.nAvance = 0.0;
            this.nNecesidadDia = 0.0;
            this.nImporteFaltante = 0.0;
            this.cPerPromName = "";
            this.nIntSrcCodigo = "";
            this.nAtenciones = 0;
            this.cPerTercero = "";
        }

        public VentaPromotor(string cPerPromCodigo,
                            string tipo,
                            double nMeta,
                            double nAvance,
                            double nNecesidadDia,
                            double nImporteFaltante,
                            string cPerPromName,
                            string nIntSrcCodigo,
                            int nAtenciones,
                            string cPerTercero
                            )
        {
            this.cPerPromCodigo = cPerPromCodigo;
            this.tipo = tipo;
            this.nMeta = nMeta;
            this.nAvance = nAvance;
            this.nNecesidadDia = nNecesidadDia;
            this.nImporteFaltante = nImporteFaltante;
            this.cPerPromName = cPerPromName;
            this.nIntSrcCodigo = nIntSrcCodigo;
            this.nAtenciones = nAtenciones;
            this.cPerTercero = cPerTercero;
        }
    }
}