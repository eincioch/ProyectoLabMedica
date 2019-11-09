using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using Integration.BE.PadronReniec;
using Integration.DAService.PadronReniec;


namespace Integration.BL.BL_Reniec
{
    public class BL_Reniec
    {
        public DataTable Get_Datos_Reniec_Local_by_dni(Reniec Objeto)
        {

            DA_Reniec da = new DA_Reniec();
            return da.Get_Datos_Reniec_Local_by_dni(Objeto);

        }
    }
}
