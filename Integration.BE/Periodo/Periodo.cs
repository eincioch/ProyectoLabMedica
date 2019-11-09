﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.Periodo
{
    public class Periodo
    {
        private int _nPrdCodigo;

        public int nPrdCodigo
        {
            get { return _nPrdCodigo; }
            set { _nPrdCodigo = value; }
        }

        private string _cPrdDescripcion;

        public string cPrdDescripcion
        {
            get { return _cPrdDescripcion; }
            set { _cPrdDescripcion = value; }
        }

        private int _nPrdActividad;

        public int nPrdActividad
        {
            get { return _nPrdActividad; }
            set { _nPrdActividad = value; }
        }

        private DateTime _dPrdIni;

        public DateTime dPrdIni
        {
            get { return _dPrdIni; }
            set { _dPrdIni = value; }
        }

        private DateTime _dPrdFin;

        public DateTime dPrdFin
        {
            get { return _dPrdFin; }
            set { _dPrdFin = value; }
        }

        private int _nPrdTipo;

        public int nPrdTipo
        {
            get { return _nPrdTipo; }
            set { _nPrdTipo = value; }
        }

        private int _nPrdEstado;

        public int nPrdEstado
        {
            get { return _nPrdEstado; }
            set { _nPrdEstado = value; }
        }

        private string _cFlag;

        public string cFlag
        {
            get { return _cFlag; }
            set { _cFlag = value; }
        }
        

    }
}
