using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.Android;
using Integration.DAService.DA_Android;
using System.Data;
using System.Data.SqlClient;

namespace Integration.BL.BL_Android
{
    public class BL_VisitaMedico
    {
        //Insert Visita Médico
        public bool Android_Insert_Visita_Medico(VisitaMedico Objeto)
        {
            DA_VisitaMedico Obj = new DA_VisitaMedico();
            return Obj.Android_Insert_Visita_Medico(Objeto);
        }


        //---------------------------------------------
        // Cargar Visitas Médico Diaria según Promotor
        //---------------------------------------------
        public DataTable Android_Get_VisitaDiariaMedico_by_Promotor(VisitaMedico Objeto)
        {
            DA_VisitaMedico Obj = new DA_VisitaMedico();
            return Obj.Android_Get_VisitaDiariaMedico_by_Promotor(Objeto);
        }

    }
}
