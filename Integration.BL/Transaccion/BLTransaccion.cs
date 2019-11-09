using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Integration.BE.Transaccion;
using Integration.DAService.DATransaccion;
using System.Configuration;

namespace Integration.BL.Transaccion
{
    public class BLTransaccion
    {
        //-------------------
        //Insert Transaccion
        //------------------
        public bool Ins_Transaccion(BETransaccion Objeto)
        {
            DATransaccion da = new DATransaccion();
            return da.Ins_Transaccion(Objeto);
        }
    }
}
