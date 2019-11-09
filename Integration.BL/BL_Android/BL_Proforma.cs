using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.Android;
using Integration.DAService.DA_Android;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_Android
{
    public class BL_Proforma
    {
        public int Android_Get_Correlativo_Proforma(Proforma Objeto)
        {
            DA_Proforma Obj = new DA_Proforma();
            return Obj.Android_Get_Correlativo_Proforma(Objeto);
        }

        //Insert Proforma Android
        public bool Android_Insert_Proforma(Proforma Objeto)
        {
            DA_Proforma Obj = new DA_Proforma();
            return Obj.Android_Insert_Proforma(Objeto);
        }

        //Update Proforma Android
        public bool Android_Update_Proforma(Proforma Objeto)
        {
            DA_Proforma Obj = new DA_Proforma();
            return Obj.Android_Update_Proforma(Objeto);
        }

        //----------------------------------------------------------------------------------------------
        // Update Proforma [nPerIdeTipo, cPerIdeNumero] si hay correccion de documento en la validación
        //---------------------------------------------------------------------------------------------
        public bool Android_Update_Proforma_by_cPerIdeNumero(Proforma Objeto)
        {
            DA_Proforma Obj = new DA_Proforma();
            return Obj.Android_Update_Proforma_by_cPerIdeNumero(Objeto);
        }

        //--------------------------------------------------
        // Listar Proforma por nPerIdeTipo_and_cPerIdeNumero
        //--------------------------------------------------
        public DataTable Android_Listar_Proforma_by_nPerIdeTipo_and_cPerIdeNumero(Proforma Objeto)
        {
            DA_Proforma Obj = new DA_Proforma();
            return Obj.Android_Listar_Proforma_by_nPerIdeTipo_and_cPerIdeNumero(Objeto);
        }


        //---------------------------------
        // Buscar Persona para ser atendida
        //---------------------------------
        public DataTable Android_Get_Persona_by_nPerIdeTipo_cPerIdeNumero(Proforma Objeto)
        {
            DA_Proforma Obj = new DA_Proforma();
            return Obj.Android_Get_Persona_by_nPerIdeTipo_cPerIdeNumero(Objeto);
        }

        //-----------------------------------
        // Cargar Detalle Proforma (Muestras)
        //-----------------------------------
        public DataTable Get_Proforma_by_nPerIdeTipo_cPerIdeNumero(Proforma Objeto)
        {
            DA_Proforma Obj = new DA_Proforma();
            return Obj.Get_Proforma_by_nPerIdeTipo_cPerIdeNumero(Objeto);
        }

    }
}
