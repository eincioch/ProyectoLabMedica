using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Integration.BE.Persona;
using Integration.DAService.DA_Persona;

using System.Data;
using System.Data.SqlClient;

namespace Integration.BL.BL_Persona
{
    public class GestionarPerOperacionServicio
    {
        public DataTable Get_PerOperacion(PerOperacion perOperacion)
        {

            PerOperacionDAQSQLServer perOperacionDAQSQLServer = new PerOperacionDAQSQLServer();
            return perOperacionDAQSQLServer.Get_PerOperacion(perOperacion);
        }

        public bool Insert_PerOperacion(PerOperacion perOperacion)
        {
            PerOperacionDAQSQLServer perOperacionDAQSQLServer = new PerOperacionDAQSQLServer();
            return perOperacionDAQSQLServer.Insert_PerOperacion(perOperacion);
        }
    }
}
