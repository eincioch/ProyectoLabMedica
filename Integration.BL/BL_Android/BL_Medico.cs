using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.Persona;
using Integration.DAService.DA_Android;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_Android
{
    public class BL_Medico
    {
        //------------------------------
        // Listar Médico By Promotor
        //------------------------------
        public DataTable Android_Get_Medico_By_Promotor(BE_Req_Medico Object)
        {
            DA_Promotor Obj = new DA_Promotor();
            return Obj.Android_Get_Medico_By_Promotor(Object);
        }

        //------------------------------
        // Listar Asignaciones By Promotor
        //------------------------------
        public DataTable Android_Get_Asignaciones_By_Promotor(BE_Req_Medico Object)
        {
            DA_Promotor Obj = new DA_Promotor();
            return Obj.Android_Get_Asignaciones_By_Promotor(Object);
        }
    }
}
