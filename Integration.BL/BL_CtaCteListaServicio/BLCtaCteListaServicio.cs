using System;
using Integration.BE.CtasCtes;
using Integration.DAService.DA_CtaCteListaServicio;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BL.BL_CtaCteListaServicio
{
    public class BLCtaCteListaServicio
    {
        //---------------------------------
        // Get CtaCteListaServicio - Popup
        //--------------------------------
        public DataTable Get_CtaCteListaServicio_by_cPerJurCodigo_and_cCtaCteSerJerarquia(BE_ReqCtaCteServicio Request)
        {
            DACtaCteListaServicio Obj = new DACtaCteListaServicio();
            return Obj.Get_CtaCteListaServicio_by_cPerJurCodigo_and_cCtaCteSerJerarquia(Request);

        }

        //---------------------------------------------------------
        // Get usp_Android_SQL_Examenes_by_cIntJerarquia - Android
        //---------------------------------------------------------
        public DataTable Get_Android_SQL_Examenes_by_cIntJerarquia(BE_ReqCtaCteServicio Request)
        {
            DACtaCteListaServicio Obj = new DACtaCteListaServicio();
            return Obj.Get_Android_SQL_Examenes_by_cIntJerarquia(Request);
        }

        
    }
}
