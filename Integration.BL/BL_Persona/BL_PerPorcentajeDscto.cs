using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Persona;
using Integration.DAService;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL
{
    //Capa: Servicio
    public class BL_PerPorcentajeDscto
    {
        //-------------------------
        //Insert PerPorcentajeDscto
        //---------------------------
        public bool Ins_PerPorcentajeDscto(BE_ReqPerPorcentajeDscto Objeto) 
        {
            DA_PerPorcentajeDscto Obj = new DA_PerPorcentajeDscto();
            return Obj.Ins_PerPorcentajeDscto(Objeto);
        }

        //--------------------------------
        //Insert PerDetallePorcentajeDscto
        //--------------------------------
        public bool Ins_PerDetallePorcentajeDscto(BE_ReqPerPorcentajeDscto Objeto)
        {
            DA_PerPorcentajeDscto Obj = new DA_PerPorcentajeDscto();
            return Obj.Ins_PerDetallePorcentajeDscto(Objeto);
        }

        //-------------------------------------------------------
        // Get Procentaje aplicado por Entidad y Tipo de Relacion
        //-------------------------------------------------------
        public DataTable Get_PerPorcentajeDscto_by_cPerJurCodigo_and_cPerParCodigo_and_nIntCodigo(BE_ReqPerPorcentajeDscto Objeto)
        {
            DA_PerPorcentajeDscto Obj = new DA_PerPorcentajeDscto();
            return Obj.Get_PerPorcentajeDscto_by_cPerJurCodigo_and_cPerParCodigo_and_nIntCodigo(Objeto);
        }

        //--------------------------------
        //DELETE PerDetallePorcentajeDscto
        //--------------------------------
        public bool Del_PerDetallePorcentajeDscto_by_cPerCodigo_cPerParCodigo_nIntCodigo_nCtaCteSerCodigo(BE_ReqPerPorcentajeDscto Objeto)
        {
            DA_PerPorcentajeDscto Obj = new DA_PerPorcentajeDscto();
            return Obj.Del_PerDetallePorcentajeDscto_by_cPerCodigo_cPerParCodigo_nIntCodigo_nCtaCteSerCodigo(Objeto);
        }

        //--------------------------------
        //DELETE PerDetallePorcentajeDscto
        //--------------------------------
        public bool Del_PerDetallePorcentajeDscto_by_cPerCodigo_cPerParCodigo_nIntCodigo(BE_ReqPerPorcentajeDscto Objeto)
        {
            DA_PerPorcentajeDscto Obj = new DA_PerPorcentajeDscto();
            return Obj.Del_PerDetallePorcentajeDscto_by_cPerCodigo_cPerParCodigo_nIntCodigo(Objeto);
        }

        public int Get_PerDetallePorcentajeDscto_nReg(BE_ReqPerPorcentajeDscto perPorcentajeDscto) { 
            DA_PerPorcentajeDscto Obj = new DA_PerPorcentajeDscto();
            return Obj.Get_PerDetallePorcentajeDscto_nReg(perPorcentajeDscto);
        }

        //---------------------------------------------------
        //Insert PerDetallePorcentajeDscto en Bloque con XML
        //---------------------------------------------------
        public bool Ins_PerDetallePorcentajeDscto_By_XML(BE_ReqPerPorcentajeDscto Objeto)
        {
            DA_PerPorcentajeDscto Obj = new DA_PerPorcentajeDscto();
            return Obj.Ins_PerDetallePorcentajeDscto_By_XML(Objeto);
        }
        

    }
}
