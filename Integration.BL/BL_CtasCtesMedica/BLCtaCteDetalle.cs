using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using Integration.BE.CtasCtesMedica;
using Integration.DAService.DA_CtasCtesMedica;

namespace Integration.BL.BL_CtasCtesMedica
{
    public class BLCtaCteDetalle
    {
        public DataTable Get_CtaCteDetalle(BE_ReqCtaCteDetalle ctaCteDetalle)
        {
            DA_CtaCteDetalle Obj = new DA_CtaCteDetalle();
            return Obj.Get_CtaCteDetalle(ctaCteDetalle);

        }

        /*guardando conjunto de registro utilizando Listas List*/
        public bool Insert_CtaCteDetalle(List<BE_ReqCtaCteDetalle> listCtaCteDetalle) {

            bool exito = true;

            DA_CtaCteDetalle ctaCteDetalleDAO = new DA_CtaCteDetalle();
            foreach (BE_ReqCtaCteDetalle Item in listCtaCteDetalle)
            {
                exito = ctaCteDetalleDAO.Ins_CtaCteDetalle(Item);
                if (!exito)
                {
                    break;
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Insert_CtaCteDetalle].!");
                }
            }

            return exito;

        }
    }
}
