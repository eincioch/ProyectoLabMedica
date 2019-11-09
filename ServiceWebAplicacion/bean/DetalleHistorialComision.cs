using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion.bean
{
    public class DetalleHistorialComision
    {       
        private int _Periodo;

        public int Periodo
        {
            get { return _Periodo; }
            set { _Periodo = value; }
        }

        private string _Anio;

        public string Anio
        {
            get { return _Anio; }
            set { _Anio = value; }
        }

        private string _Mes;

        public string Mes
        {
            get { return _Mes; }
            set { _Mes = value; }
        }

        private double _nComision;

        public double nComision
        {
            get { return _nComision; }
            set { _nComision = value; }
        }
        
        public DetalleHistorialComision(){
            Periodo = 0;
            Anio = "";
            Mes = "";
            nComision = 0.0;
        }


        public DetalleHistorialComision(int periodo, string anio, string mes, double ncomision)
        {
            Periodo = periodo;
            Anio = anio;
            Mes = mes;
            nComision = ncomision;
        }
    }
}