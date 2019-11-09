using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.Reportes
{
    public class ReqRptParametros
    {

        //List Report por PerUsuGruAcc
        public int nIntClase { get; set; }
        public string cIntJerarquia { get; set; }
        public string cPerCodigo { get; set; }

        //Comision medicos
        public string cPerJuridica { get; set; }
        public string cPerCodMedico { get; set; }
        public DateTime dFecIni { get; set; }
        public DateTime dFecFin { get; set; }

        //busca medico
        public string cApeDoctor { get; set; }

        public string cFecIni { get; set; }
        public string cFecFin { get; set; }

        public string nFlagFiltro { get; set; }
        public string nFlag { get; set; }
        public string cPerCodPromotor { get; set; }

        public string cPerUsuCodigo { get; set; }
        public string cTipo { get; set; }
        public int nFlagTodos { get; set; }

        public string cPerCodigoTerceros { get; set; }

        public int nFlagComision { get; set; }
    }
}
