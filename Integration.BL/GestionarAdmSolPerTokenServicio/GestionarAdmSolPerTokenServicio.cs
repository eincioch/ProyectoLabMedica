using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Integration.BE.AdmSolPerToken;
using Integration.DAService.AdmSolPerTokenDAO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Integration.BL.GestionarAdmSolPerTokenServicio
{
    public class GestionarAdmSolPerTokenServicio
    {
        //----------------------
        // Insert AdmSolPerToken
        //----------------------
        public bool Upd_AdmSolPerToken(AdmSolPerToken admSolPerToken)
        {
            AdmSolPerTokenDAO Obj = new AdmSolPerTokenDAO();
            return Obj.Upd_AdmSolPerToken(admSolPerToken);
        }

        //-------------------------------
        // Validar si esta libre el Token
        //-------------------------------
        public DataTable Get_AdmSolPerToken(AdmSolPerToken admSolPerToken)
        {
            AdmSolPerTokenDAO Obj = new AdmSolPerTokenDAO();
            return Obj.Get_AdmSolPerToken(admSolPerToken);
        }

        //-------------------------------------------------
        //Generar Clave Token desde App Medica Coorporativo
        //-------------------------------------------------
        public string Android_ADMISION_SET_TOKEN_DCTOS_OR_CORTESIA(AdmSolPerToken Objeto)
        {
            AdmSolPerTokenDAO Obj = new AdmSolPerTokenDAO();
            return Obj.Android_ADMISION_SET_TOKEN_DCTOS_OR_CORTESIA(Objeto);

        }
    }
}
