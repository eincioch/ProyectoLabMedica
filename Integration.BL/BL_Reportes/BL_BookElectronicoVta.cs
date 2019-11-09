using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Reportes;
using Integration.DAService.DA_Persona;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_Reportes
{
    public class BL_BookElectronicoVta
    {
        //Get_CtaCteNumeracion
        public DataTable Get_CtasCtes_Get_LibroVentas_Electronico(Int32 nPrdCodigo, string cFlag = "D")
        {
            //Recuperando registros 
            BE_ReqBookElectronicoVta Request = new BE_ReqBookElectronicoVta();

            Request.nPrdCodigo = nPrdCodigo;
            Request.cFlag = cFlag;

            DA_BookElectronicoVta Obj = new DA_BookElectronicoVta();

            return Obj.Get_CtasCtes_Get_LibroVentas_Electronico(Request);

        }
    }
}
