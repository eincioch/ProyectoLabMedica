using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.DAService.DA_Android;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_Android
{
    public class BL_Promotor
    {
        //------------------------------
        // Listar Promotores de Médica
        //------------------------------
        public DataTable Android_Get_Promotor(string cOpcion = "")
        {
            DA_Promotor Obj = new DA_Promotor();
            return Obj.Android_Get_Promotor(cOpcion);
        }
    }
}
