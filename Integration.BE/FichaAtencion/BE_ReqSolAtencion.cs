using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.FichaAtencion
{
    public class BE_ReqSolAtencion
    {
        public string   cPerJuridica { get; set; }
        public int      nIntCodigo { get; set; }
        public string   cPerCodigoTerceros { get; set; }
        public string   nSolAdmNumero { get; set; }
        public string   cPerCodigo { get; set; }
        public DateTime dFecExamen { get; set; }
        public int      nAdmSolEstado { get; set; }

        public string   cCtaCteRecibo { get; set; }

        public double   nImpTotal { get; set; }
        public string   cPerUseCodigo { get; set; }
        public string   cPerUseCodUpd { get; set; }

        public int      nEstadoExportLIS { get; set; }
        public string   cNroOrdenLIS { get; set; }

        public int      nFlagComision { get; set; } //Update 2016-01-12 (eincio)

        public string   IncluirAnulado { get; set; } //Update 2016-01-15 (eincio)

        //DetAdmSolAtencion
        public int      nCtaCteSerCodigo { get; set; }

        public long     nCtaCteCantidad { get; set; }
        public double   nCtaCteCosto { get; set; }
        public string   nFlag { get; set; }

        public int      nTipoDscto { get; set; }
        public double   nCtaCteSerImpDef { get; set; }
        
        public string   cIntJerarquia { get; set; }

        public string   cPerCodigoDoctor { get; set; }

        public int nPerIntCodigo { get; set; }

        //parametros List AdmSolAtencion
        public string   Flag { get; set; }
        public string   cPerIdeNumero { get; set; }
        public string   cPerApellidos { get; set; }
        public string   dFecIni { get; set; }
        public string   dFecFin { get; set; }

        public DateTime  FecIni { get; set; }
        public DateTime  FecFin { get; set; }

        public string   cPerCodigoAut { get; set; }

        //Codigo Diagnostico
        public string  cDiagCodigo { get; set; }

        //Auditoria
        public int      nAudiIntClase { get; set; }
        public int      nAudiIntCodigo { get; set; }
        public string   cAudiDescripcion { get; set; }
        public int      nAudiMotivoDscto { get; set; }
        public string   cAudiDetalleDscto { get; set; }
        public double   fAudiPorcDscto { get; set; }
        public double   fAudiTotalDscto { get; set; }
    }
}
