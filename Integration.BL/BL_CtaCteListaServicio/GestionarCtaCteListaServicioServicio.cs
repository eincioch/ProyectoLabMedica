using System;
using System.Collections.Generic;

using Integration.BE.Reportes;
using Integration.DAService.DA_CtaCteListaServicio;
using System.Data;
using System.Data.SqlClient;
using Integration.BE.CtasCtes;

namespace Integration.BL.BL_CtaCteListaServicio
{
    public class GestionarCtaCteListaServicioServicio
    {
        public DataTable Get_Lista_Grupo_Examenes(ReqRptParametros reqRptParametros)
        {
            CtaCteListaServicioDAOSQLServer ctaCteListaServicioDAOSQLServer =  new CtaCteListaServicioDAOSQLServer();
            return ctaCteListaServicioDAOSQLServer.Get_Lista_Grupo_Examenes(reqRptParametros);
        }

        public DataTable Get_Ranking_Grupo_Examenes(ReqRptParametros reqRptParametros)
        {
            CtaCteListaServicioDAOSQLServer ctaCteListaServicioDAOSQLServer = new CtaCteListaServicioDAOSQLServer();
            return ctaCteListaServicioDAOSQLServer.Get_Ranking_Grupo_Examenes(reqRptParametros);
        }

        #region Get "nCtaCteSerCodigo" de CtaCteListaServicio (EINCIO 2017-03-28)
        public int Get_CtaCteListaServicio(CtaCteListaServicio Objeto)
        {
            DACtaCteListaServicio Obj = new DACtaCteListaServicio();
            return Obj.Get_CtaCteListaServicio(Objeto);
        }
        #endregion
    }
}
