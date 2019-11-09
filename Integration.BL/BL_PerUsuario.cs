using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.PerUsuario;
using Integration.BE;
using Integration.DAService;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL
{
    public class BL_PerUsuario
    {
        public DataTable Get_Persona_By_Usuario(BE_ReqSearhUsuario Request)
        {
            //Recuperando registros 
            //DataTable dt = new DataTable();
            DA_PerUsuario Obj = new DA_PerUsuario();
            return Obj.Get_Persona_By_Usuario(Request);

        }

        public DataTable Android_Get_Persona_By_Usuario(BE_ReqSearhUsuario Request)
        {
            //Recuperando registros 
            //DataTable dt = new DataTable(); 
            DA_PerUsuario Obj = new DA_PerUsuario();
            return Obj.Android_Get_Persona_By_Usuario(Request);

        }

        public DataTable Android_Get_Persona_By_UsuarioCliente(BE_ReqSearhUsuario Request)
        {
            //Recuperando registros 
            //DataTable dt = new DataTable(); 
            DA_PerUsuario Obj = new DA_PerUsuario();
            return Obj.Android_Get_Persona_By_UsuarioCliente(Request);

        }
        
        public DataTable Get_SearhUsuario(BE_ReqSearhUsuario  Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_PerUsuario Obj = new DA_PerUsuario();
            return Obj.Get_SearhUsuario(Request);

        }

        public BE_ResGenerico UpdChangePassword(BE_ReqSearhUsuario Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_PerUsuario Obj = new DA_PerUsuario();
            Item = Obj.UpdChangePassword(Request);
            return Item;
        }

        public DataTable Get_CboListUsuario(BE_ReqSearhUsuario Request)
        {
            DA_PerUsuario Obj = new DA_PerUsuario();
            return Obj.Get_CboListUsuario(Request);

        }

        //Obtiene Usuario con permisos especiales
        public DataTable Get_CboListUsuarioAutorizado(BE_ReqSearhUsuario Request)
        {
            DA_PerUsuario Obj = new DA_PerUsuario();
            return Obj.Get_CboListUsuarioAutorizado(Request);

        }

        //Valida acceso a Usuario con acceso especiales
        public DataTable Get_UsuarioAutorizado(BE_ReqSearhUsuario Request)
        {
            DA_PerUsuario Obj = new DA_PerUsuario();
            return Obj.Get_UsuarioAutorizado(Request);

        }

        public DataTable ADMISION_Get_Token_By_Per_Sede_Tipo(BE_ReqSearhUsuario Request)
        {
            DA_PerUsuario Obj = new DA_PerUsuario();
            return Obj.ADMISION_Get_Token_By_Per_Sede_Tipo(Request);

        }

        public BE_ResGenerico Insert_PerUsuarioCliente(BE_ReqSearhUsuario Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_PerUsuario Obj = new DA_PerUsuario();
            Item = Obj.Insert_PerUsuarioCliente(Request);
            return Item;
        }

        
    }
}
