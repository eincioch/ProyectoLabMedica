using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

using Integration.BE.Persona;
using Integration.BE.Periodo;
using Integration.DAService.DA_Persona;

namespace Integration.BL.BL_Persona
{
    public class GestionarMetaPromotorServicio
    {
        public List<MetaPromotor> Get_MetaPromotor(MetaPromotor objeto)
        {
            MetaPromotorDAOSQLServer metaPromotorDAOSQLServer = new MetaPromotorDAOSQLServer();
            return metaPromotorDAOSQLServer.Get_MetaPromotor(objeto);
        }

        public bool Insert_MetaPromotor(MetaPromotor metaPromotor)
        {
            MetaPromotorDAOSQLServer metaPromotorDAOSQLServer = new MetaPromotorDAOSQLServer();
            return metaPromotorDAOSQLServer.Insert_MetaPromotor(metaPromotor);
        }

        public bool Update_MetaPromotor(MetaPromotor metaPromotor)
        {
            MetaPromotorDAOSQLServer metaPromotorDAOSQLServer = new MetaPromotorDAOSQLServer();
            return metaPromotorDAOSQLServer.Update_MetaPromotor(metaPromotor);
        }

        public DataTable Get_MetaPromotor_Avance(Periodo periodo, string cFlagFec = "P", string cPrdIni = "", string cPrdFin = "", string cPerPromCodigo = "")
        { 
            MetaPromotorDAOSQLServer metaPromotorDAOSQLServer = new MetaPromotorDAOSQLServer();
            return metaPromotorDAOSQLServer.Get_MetaPromotor_Avance(periodo, cFlagFec, cPrdIni, cPrdFin, cPerPromCodigo); 
        }

        #region Derivaciones
        public DataTable Get_Derivaciones_Qty_Amount(string cFecIni = "", string cFecFin = "", string cFlag="", string cFlag2 = "")
        { 
            MetaPromotorDAOSQLServer metaPromotorDAOSQLServer = new MetaPromotorDAOSQLServer();
            return metaPromotorDAOSQLServer.Get_Derivaciones_Qty_Amount(cFecIni, cFecFin, cFlag, cFlag2);
        }
        #endregion
    }
}
