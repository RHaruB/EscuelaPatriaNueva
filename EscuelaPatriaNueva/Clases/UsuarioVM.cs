using EscuelaPatriaNueva.Clases;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPatriaNueva
{
    public class UsuarioVM
    {
        private string Nombre_Usuario;
        private string Contraseña;
        private PersonaVM PersonaVM;

        public UsuarioVM(string nombre_Usuario, string contraseña, PersonaVM personaVM) : this(nombre_Usuario, contraseña)
        {
            PersonaVM = personaVM;
        }

        public UsuarioVM()
        {
        }

        public UsuarioVM(string nombre_Usuario, string contraseña)
        {
            Nombre_Usuario1 = nombre_Usuario;
            Contraseña1 = contraseña;
        }

        public string Nombre_Usuario1 { get => Nombre_Usuario; set => Nombre_Usuario = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public PersonaVM PersonaVM1 { get => PersonaVM; set => PersonaVM = value; }
    }
}
