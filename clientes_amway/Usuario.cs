using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clientes_amway
{
    class Usuario
    {
        public Usuario()
        {
            this.idUsuario = 0;
            this.nombreUsuario = "";
            this.loginUsuario = "";
            this.claveUsuario = "";
            this.telefonoUsuario = "";
            this.correoUsuario = "";
        }

        public Usuario(int idUsuario, string nombreUsuario, string loginUsuario,
                       string claveUsuario, string telefonoUsuario, string correoUsuario)
        {
            this.idUsuario = IdUsuario;
            this.nombreUsuario = NombreUsuario;
            this.loginUsuario = LoginUsuario;
            this.claveUsuario = ClaveUsuario;
            this.telefonoUsuario = TelefonoUsuario;
            this.correoUsuario = CorreoUsuario;
        }

        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        private string nombreUsuario;

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        private string loginUsuario;

        public string LoginUsuario
        {
            get { return loginUsuario; }
            set { loginUsuario = value; }
        }
        private string claveUsuario;

        public string ClaveUsuario
        {
            get { return claveUsuario; }
            set { claveUsuario = value; }
        }
        private string telefonoUsuario;

        public string TelefonoUsuario
        {
            get { return telefonoUsuario; }
            set { telefonoUsuario = value; }
        }
        private string correoUsuario;

        public string CorreoUsuario
        {
            get { return CorreoUsuario; }
            set { correoUsuario = value; }
        }
    }
}
