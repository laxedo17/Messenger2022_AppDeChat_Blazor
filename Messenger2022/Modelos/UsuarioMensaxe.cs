using System;

namespace Messenger2022.Modelos
{
    public class UsuarioMensaxe
    {
        public string NomeUsuario { get; set; }
        public string Mensaxe { get; set; }
        public bool IsUsuarioActual { get; set; }
        public DateTime DataEnvio { get; set; }
    }
}