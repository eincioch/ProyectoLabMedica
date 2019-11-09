using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Campana;
using Integration.DAService.DA_Campana;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_Campana
{
    public class BL_Campana
    {
        //Genera nuevo Codigo nIntCamp
        public string Get_NewId_nIntCampana(BE_ReqCampana Request) 
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Get_NewId_nIntCampana(Request);

        }

        //Insert Campana
        public bool Ins_Campana(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Ins_Campana(Request);
        }

        //Update Campana
        public bool Upd_Campana(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Upd_Campana(Request);
        }

        //Insert Detalle Campana
        public bool Ins_DetalleCampana(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Ins_DetalleCampana(Request);
        }
 
        //Update Detalle Campana
        public bool Upd_DetalleCampana(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Upd_DetalleCampana(Request);
        }

        //-----------------------------
        // Delete Item Detalle Campana
        //-----------------------------
        public bool Del_DetalleCampana_by_nIntCamp_cPerJurCodigo_nCtaCteSerCodigo(int nIntCamp, string cPerJurCodigo, int nCtaCteSerCodigo)
        {
            bool Resultado = false;
            BE_ReqCampana Objeto = new BE_ReqCampana();
            DA_Campana da = new DA_Campana();

            Objeto.nIntCamp = nIntCamp;
            Objeto.cPerJurCodigo = cPerJurCodigo;
            Objeto.nCtaCteSerCodigo = nCtaCteSerCodigo;

            if (da.Get_DetCampana_by_nIntCamp_cPerJurCodigo_nCtaCteSerCodigo(Objeto).Rows.Count > 0)
            {
                Resultado = da.Del_DetalleCampana_by_nIntCamp_cPerJurCodigo_nCtaCteSerCodigo(Objeto);
            }
            return Resultado;
        }

        //------------------------
        //select CtaCteServicio
        //------------------------
        public DataTable Get_List_Campana(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Get_List_Campana(Request);
        }

        public DataTable Get_Campana_Historial(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Get_Campana_Historial(Request);
        }
        //-------------------------------------
        // Lista Campaña Vigentes (App Android)
        //-------------------------------------
        public DataTable Android_Get_Campana_actual(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Android_Get_Campana_actual(Request);
        }

        //------------------------
        //select CtaCteServicio
        //------------------------
        public DataTable Get_Servicios_for_nIntCamp(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Get_Servicios_for_nIntCamp(Request);
        }

        //----------------------------------------
        // Verifica si Existe Linea en DetCampaña
        //---------------------------------------
        public DataTable Get_DetCampana_by_nIntCamp_cPerJurCodigo_nCtaCteSerCodigo(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Get_DetCampana_by_nIntCamp_cPerJurCodigo_nCtaCteSerCodigo(Request);
        }

        //--------------------------------------------------
        // Lista Detalle Campaña carga Grilla para editarla
        //--------------------------------------------------
        public DataTable Get_List_Campana_Detalle(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Get_List_Campana_Detalle(Request);
        }
    }
}
