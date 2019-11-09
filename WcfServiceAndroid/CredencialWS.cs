using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceWebAplicacion
{
    public class CredencialWS
    {
        private string sUserPass;
        private string sUserName;

        public CredencialWS() { 
            this.sUserName="#m3d1c@#";
            this.sUserPass="4E1AD8B3-E8C1-47F5-8C0C-FFFE97B6EACB";
        }

        /// <summary> 
        /// Lee o escribe la clave del usuario 
        /// </summary> 
        public string UsuarioClave
        {
            get
            {
                return sUserPass;
            }
            set
            {
                sUserPass = value;
            }
        }

        /// <summary> 
        /// Lee o escribe el nombre del usuario 
        /// </summary> 
        public string UsuarioNombre
        {
            get
            {
                return sUserName;
            }
            set
            {
                sUserName = value;
            }
        } 

    }
}