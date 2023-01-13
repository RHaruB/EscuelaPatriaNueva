using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPatriaNueva.Metodos
{
    public class MetUsuarios
    {

        public bool MetListarUsuarios(UsuarioVM usuarioVM)
        {
            ConexionDBDataContext db = new ConexionDBDataContext();
            var lista = db.SP_Listar_Usuarios().ToList();

            return lista.Where(s => s.NombreUsuario == usuarioVM.Nombre_Usuario1 && s.Contrasena == usuarioVM.Contraseña1).Any();

        }

        public bool RegistrarUsuario(UsuarioVM usuarioVM)
        {
            ConexionDBDataContext db = new ConexionDBDataContext();

            var a = db.SP_Insert_Usuario(usuarioVM.PersonaVM1.Cedula1, usuarioVM.PersonaVM1.Nombre1, usuarioVM.PersonaVM1.Apellido1, usuarioVM.PersonaVM1.Telefono1, usuarioVM.PersonaVM1.Direccion1, usuarioVM.PersonaVM1.Fecha_Nacimeinto1, usuarioVM.Nombre_Usuario1, usuarioVM.Contraseña1);

            return a==0;
        }
    }
}
