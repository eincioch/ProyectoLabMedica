using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.Android;
using Integration.DAService.DA_Android;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_Android
{
    public class BL_EncuestaMovil
    {
        //Insert Proforma Android
        public bool Android_Insert_EncuestaMovil(tb_encuesta_movil Objeto)
        {
            DA_EncuestaMovil Obj = new DA_EncuestaMovil();
            return Obj.Android_Insert_EncuestaMovil(Objeto);
        }

    }
}
