using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.BE.Servicios
{
    public class Resultado_HIS
    {
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
