using System;

using Integration.DAService.DA_Android;

using System.Data;
using System.Data.SqlClient;

namespace Integration.BL.BL_Android
{
    public class GestionarEncSatisfaccionServicio
    {
        public DataTable Get_EncSatisfaccion(string cPerJurCodigo, string dFecIni, string dFecFin, string cFlag)
        {
            EncSatisfaccionDAOSQLServer encSatisfaccionDAOSQLServer = new EncSatisfaccionDAOSQLServer();
            return encSatisfaccionDAOSQLServer.Get_EncSatisfaccion(cPerJurCodigo, dFecIni, dFecFin, cFlag);
        }
    }
}
