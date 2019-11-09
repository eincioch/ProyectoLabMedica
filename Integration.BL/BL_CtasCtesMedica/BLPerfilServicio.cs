using System;
using Integration.BE.CtasCtesMedica;
using Integration.DAService.DA_CtasCtesMedica;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BL.BL_CtasCtesMedica
{
    public class BLPerfilServicio
    {
        //----------------------
        // Insert PerfilServicio
        //----------------------
        public bool Ins_PerfilServicio(string cPerJurCodigo, int nIntCodigo, int nCtaCteSerCodigo, int nMonCodigo, double nCtaCteSerImpDef, string cPerUserCodigo)
        {
            ReqPerfilServicio Objeto = new ReqPerfilServicio();
            DAPerfilServicio da = new DAPerfilServicio();

            Objeto.cPerJurCodigo = cPerJurCodigo;
            Objeto.nIntCodigo = nIntCodigo;
            Objeto.nCtaCteSerCodigo = nCtaCteSerCodigo;
            Objeto.nMonCodigo = nMonCodigo;
            Objeto.nCtaCteSerImpDef = nCtaCteSerImpDef;
            Objeto.cPerCodigo = cPerUserCodigo;

            return da.Ins_PerfilServicio(Objeto);
        }

        //----------------------
        // Delete PerfilServicio
        //----------------------
        public bool Del_PerfilServicio(string cPerJurCodigo, int nIntCodigo, int nCtaCteSerCodigo)
        {
            bool Resultado = false;
            ReqPerfilServicio Objeto = new ReqPerfilServicio();
            DAPerfilServicio da = new DAPerfilServicio();

            Objeto.cPerJurCodigo = cPerJurCodigo;
            Objeto.nIntCodigo = nIntCodigo;
            Objeto.nCtaCteSerCodigo = nCtaCteSerCodigo;

            if (da.Get_PerfilServicio_by_cPerJurCodigo_nIntCodigo_nCtaCteSerCodigo(Objeto).Rows.Count > 0) { 
                Resultado=da.Del_PerfilServicio(Objeto);
            }
            return Resultado;
        }

        //--------------------------------------------------
        // Get PerfilServicio valor por default "P" --perfil
        //--------------------------------------------------
        public DataTable Get_PerfilServicio(string cPerJurCodigo, int nIntCodigo, String nFlag="P")
        {
            ReqPerfilServicio Objeto = new ReqPerfilServicio();
            DAPerfilServicio da = new DAPerfilServicio();

            Objeto.cPerJurCodigo = cPerJurCodigo;
            Objeto.nIntCodigo = nIntCodigo;
            Objeto.nFlag = nFlag;

            return da.Get_PerfilServicio(Objeto);

        }

        public DataTable Get_PerfilServicio_Terceros(string cPerJurCodigo, int nIntCodigo, String nFlag = "P", String cPerParCodigo = "", int nTipoAtencion = 1002)
        {
            ReqPerfilServicio Objeto = new ReqPerfilServicio();
            DAPerfilServicio da = new DAPerfilServicio();

            Objeto.cPerJurCodigo = cPerJurCodigo;
            Objeto.nIntCodigo = nIntCodigo;
            Objeto.nFlag = nFlag;
            Objeto.nTipoAtencion = nTipoAtencion;
            Objeto.cPerParCodigo = cPerParCodigo;

            return da.Get_PerfilServicio_Terceros(Objeto);

        }

        //----------------------------------------------------------------------------
        //Get List PerfilServicio for cPerJurCodigo and nIntCodigo and nCtaCteSerCodigo
        //----------------------------------------------------------------------------
        public DataTable Get_PerfilServicio_by_cPerJurCodigo_nIntCodigo_nCtaCteSerCodigo(ReqPerfilServicio Objeto)
        {

            DAPerfilServicio da = new DAPerfilServicio();
            return da.Get_PerfilServicio(Objeto);

        }
    }
}
