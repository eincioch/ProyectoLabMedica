using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integration.BE.Persona;
using Integration.DAService;

namespace Integration.BL
{
    public class BL_Marcacion
    {
        public bool Set_tb_reportslist(BE_Req_Marcacion Objeto)
        {
            DA_Marcacion da = new DA_Marcacion();
            return da.Set_tb_reportslist(Objeto);
        }
    }
}
