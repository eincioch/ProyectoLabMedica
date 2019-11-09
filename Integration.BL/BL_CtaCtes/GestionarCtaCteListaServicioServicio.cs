using System;
using System.Collections.Generic;

using Integration.BE.CtasCtes;
using Integration.DAService.DA_CtaCte;

namespace Integration.BL.BL_CtaCtes
{
    public class GestionarCtaCteListaServicioServicio
    {
        public List<CtaCteListaServicio> Get_CtaCteListaServicio(string cPerJurCodigo = "1000098770")
        {
            CtaCteListaServicioDAOSQLServer ctaCteListaServicioDAOSQLServer = new CtaCteListaServicioDAOSQLServer();
            return ctaCteListaServicioDAOSQLServer.Get_CtaCteListaServicio(cPerJurCodigo);
        }
    }
}
