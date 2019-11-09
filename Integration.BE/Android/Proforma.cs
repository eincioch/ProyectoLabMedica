using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.Android
{
    public class Proforma
    {
        public int nCorrelativo { get; set; }
        public int nPerIdeTipo { get; set; }
        public string cPerIdeNumero { get; set; }
        public string nIntJerarquia { get; set; }
        public double nPrecio { get; set; }
        public string nSolAdmNumero { get; set; }

        //Solucion por miestras averifuamos como enviar un ArrayList desde Android con ksoap2
        public string ListMuestras { get; set; }

        //paramString for Store Procedure
        public string cFecIni { get; set; }
        public string cFecFin { get; set; }
        public string cFlag { get; set; }

        //var para update proforma
        public int nPerIdeTipo_New { get; set; }
        public string cPerIdeNumero_New { get; set; }
    }
}
