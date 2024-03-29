﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.PerUsuGruAcc;
using Integration.BE.Interface;
using Integration.BL;
using Integration.DAService;
using System.Data;

namespace Integration.BL
{
    public class BL_PerUsuGruAcc
    {
        public IList<BE_Res_PerUsuGruAcc> obtenerPermisos(BE_Req_PerUsuGruAcc Request)
        {

            DAPerUsuGruAcc ObjPermisos = new DAPerUsuGruAcc();
            return ObjPermisos.ObtenerPermisos(Request);

        }

        public IList<BE_Res_Interface> ObtenerPermisosMenu(BE_Req_PermisosMenu Request)
        {

            DAPerUsuGruAcc ObjPermisos = new DAPerUsuGruAcc();
            return ObjPermisos.ObtenerPermisosMenu(Request);

        }

        public DataTable Get_PerUsuGruAcc_Get_Interface(BE_Req_PerUsuGruAcc Request)
        {
            DAPerUsuGruAcc da = new DAPerUsuGruAcc();
            return da.Get_PerUsuGruAcc_Get_Interface(Request);

        }

    }
}
