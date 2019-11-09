using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqCtaCteNumeracion
    {
        public string cPerJurCodigo	{get;set;}
        public long nCajCodigo	{get;set;}
        public long nComCodigo	{get;set;}
        public long nCtaCteNumero	{get;set;}
        public string cCtaCteSerie	{get;set;}
        public long nCtaCteNumIni	{get;set;}
        public long nCtaCtaNumFin {get; set;}

        public string cNombreImpresora { get; set; }
        public string cPort { get; set; }
        public string cCodAutSUNAT { get; set; }
    }

    public class BE_ReqUpdCtaCteNumeracion
    {
        public string cPerJurCodigo {get;set;}
	    public long nCajCodigo  {get;set;}
	    public long nCtaCteComCodigo  {get;set;}
        public long  cCtaCteComNumero { get; set; }
        public string cCtaCteSerie { get; set; }
    }
}
