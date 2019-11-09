using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Persona
{
    //Capa: Dominio (Entidad "PerPorcentajeDscto")
    public class BE_ReqPerPorcentajeDscto
    {
        public string cPerCodigo { get; set; }
        public string cPerParCodigo { get; set; }
        public int nCtaCteSerCodigo { get; set; }
        public int nIntCodigo { get; set; }
        public int nTipoDscto { get; set; }
        public double nPorcDscto { get; set; }
        public DateTime dEffDate { get; set; }
        public int nAplicaTodo { get; set; }
        public string cPerUsuario { get; set; }
        public int nReg { get; set; }
        public string strXML { get; set; }
        
        //se agrego parametro
        public string cFlag { get; set; }

        //Reglas del nogocio Guardar porcentaje en decimal o precio fijo en la db.
        public double porcentajeCalc(){
            double nValor=0;
            if (nTipoDscto == 1){
                nValor = nPorcDscto / 100;
            }
            else {
                nValor = nPorcDscto;
            }

            return nValor; // nPorcDscto / 100;
        }

    }

    
}
