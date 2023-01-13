using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPatriaNueva.Clases
{
    public class PersonaVM
    {
        private string Cedula;
        private string Nombre;
        private string Apellido;
        private string Direccion;
        private string Telefono;
        private DateTime Fecha_Nacimeinto;

        public PersonaVM()
        {
        }

        public PersonaVM(string cedula, string nombre, string apellido, string direccion, string telefono, DateTime fecha_Nacimeinto)
        {
            Cedula1 = cedula;
            Nombre1 = nombre;
            Apellido1 = apellido;
            Direccion1 = direccion;
            Telefono1 = telefono;
            Fecha_Nacimeinto1 = fecha_Nacimeinto;
        }

        public string Cedula1 { get => Cedula; set => Cedula = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public DateTime Fecha_Nacimeinto1 { get => Fecha_Nacimeinto; set => Fecha_Nacimeinto = value; }
    }
}
