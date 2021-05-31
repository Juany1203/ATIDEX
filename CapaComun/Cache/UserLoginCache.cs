using System;
using System.Collections.Generic;
using System.Text;

namespace CapaComun.Cache
{
    public static class UserLoginCache
    {
        public static int IdUser { get; set; }

        public static string UserUsuario { get; set; }

        public static string PassUsuario { get; set; }

        public static bool TipoUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static string Apellido1Usuario { get; set; }
        public static string Apellido2Usuario { get; set; }
        public static string provinciaUsuario { get; set; }

        public static string cantonUsuario { get; set; }
        public static string distritoUsuario { get; set; }
        public static string direccionUsuario { get; set; }
        public static string telefonoUsuario { get; set; }
        public static string correoUsuario { get; set; }
        public static string sitiowebUsuario { get; set; }
        public static string perfilfbUsuario { get; set; }
        public static string perfiligUsuario { get; set; }
        public static string perfiltwUsuario { get; set; }

    }
}
