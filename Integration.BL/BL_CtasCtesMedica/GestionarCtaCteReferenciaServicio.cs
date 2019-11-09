using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.CtasCtesMedica;
using Integration.DAService.DA_CtasCtesMedica;
using System.Data;
using System.Data.SqlClient;

namespace Integration.BL.BL_CtasCtesMedica
{
    public class GestionarCtaCteReferenciaServicio
    {
        public bool Insert_CtaCteReferencia(CtaCteReferencia ctaCteReferencia) {

            CtaCteReferenciaDAO ctaCteReferenciaDAO = new CtaCteReferenciaDAO();

            return ctaCteReferenciaDAO.Insert_CtaCteReferencia(ctaCteReferencia);
        }

        public DataTable Get_CtaCteReferencia_By_cCtaCteRefRecibo(CtaCteReferencia ctaCteReferencia) {
            CtaCteReferenciaDAO ctaCteReferenciaDAO = new CtaCteReferenciaDAO();
            return ctaCteReferenciaDAO.Get_CtaCteReferencia_By_cCtaCteRefRecibo(ctaCteReferencia);
        }

    }
}
