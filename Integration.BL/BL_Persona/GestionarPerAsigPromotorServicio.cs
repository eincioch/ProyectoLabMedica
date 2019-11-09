using System;
using System.Collections.Generic;
using System.Linq;

using Integration.BE.Persona;
using Integration.DAService.DA_Persona;

using System.Data;
using System.Data.SqlClient;

namespace Integration.BL.BL_Persona
{
    public class GestionarPerAsigPromotorServicio
    {

        public DataTable Get_PerAsigPromotor(int nPerAsigTipo) {

            PerAsigPromotorDAOSQLServer perAsigPromotorDAOSQLServer = new PerAsigPromotorDAOSQLServer();
            return perAsigPromotorDAOSQLServer.Get_PerAsigPromotor(nPerAsigTipo);
        }

        public DataTable Get_PerAsigPromotor_Listado_Medico(PerAsigPromotor perAsigPromotor)
        {
            PerAsigPromotorDAOSQLServer perAsigPromotorDAOSQLServer = new PerAsigPromotorDAOSQLServer();
            return perAsigPromotorDAOSQLServer.Get_PerAsigPromotor_Listado_Medico(perAsigPromotor);
        }

        public DataTable Get_PerAsigPromotor_By_cPerPromCodigo(PerAsigPromotor perAsigPromotor)
        {
            PerAsigPromotorDAOSQLServer perAsigPromotorDAOSQLServer = new PerAsigPromotorDAOSQLServer();
            return perAsigPromotorDAOSQLServer.Get_PerAsigPromotor_By_cPerPromCodigo(perAsigPromotor);
        }

        public bool Insert_PerAsigPromotor(PerAsigPromotor perAsigPromotor)
        { 
            PerAsigPromotorDAOSQLServer perAsigPromotorDAOSQLServer = new PerAsigPromotorDAOSQLServer();
            return perAsigPromotorDAOSQLServer.Insert_PerAsigPromotor(perAsigPromotor);
        }

        public String Get_PerAsigPromotor_By_nPerAsigEstado_dEffDate(PerAsigPromotor perAsigPromotor) {
            PerAsigPromotorDAOSQLServer perAsigPromotorDAOSQLServer = new PerAsigPromotorDAOSQLServer();
            return perAsigPromotorDAOSQLServer.Get_PerAsigPromotor_By_nPerAsigEstado_dEffDate(perAsigPromotor);
        }

        public DataTable Get_DatosMedico_by_cPerPromCodigo_NombresMedico(PerAsigPromotor perAsigPromotor)
        {
            DA_PerAsigDetalle perAsigDetalleSQL = new DA_PerAsigDetalle();
            return perAsigDetalleSQL.Get_DatosMedico_by_cPerPromCodigo_NombresMedico(perAsigPromotor);
        }
    }
}
