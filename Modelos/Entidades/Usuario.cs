using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelos.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string apellidoUsuario;
        private string emailUsuario;
        private string contrasena;
        private string rol;
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string ApellidoUsuario { get => apellidoUsuario; set => apellidoUsuario = value; }
        public string EmailUsuario { get => emailUsuario; set => emailUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Rol { get => rol; set => rol = value; }
    }
}
