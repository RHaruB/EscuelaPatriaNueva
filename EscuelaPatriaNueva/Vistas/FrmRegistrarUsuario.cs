using EscuelaPatriaNueva.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaPatriaNueva.Vistas
{
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                UsuarioVM usuarioVM = new UsuarioVM
                {
                    PersonaVM1 = new Clases.PersonaVM
                    {
                        Cedula1 = TxtCedula.Text,
                        Apellido1 = TxtApellido.Text,
                        Nombre1 = TxtNombre.Text,
                        Direccion1 = TxtDireccion.Text,
                        Telefono1 = TxtTelefono.Text,
                        Fecha_Nacimeinto1 = Convert.ToDateTime(monthCalendar1.SelectionStart)
                    },
                    Contraseña1 = TxtContrasena.Text,
                    Nombre_Usuario1 = TxtUsuario.Text
                };
                MetUsuarios met = new MetUsuarios();
                bool guardo = met.RegistrarUsuario(usuarioVM);
                if (guardo)
                {
                    MessageBox.Show("Usuario guardado con éxito");
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Ocurrio un error, consulte con sistemas");
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(TxtApellido.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(TxtCedula.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(TxtDireccion.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(TxtTelefono.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(TxtUsuario.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(TxtContrasena.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(Calendar.Text))
            {
                return false;
            }
            return true;
        }
        private void Limpiar()
        {
            TxtApellido.Text = string.Empty;
            TxtCedula.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtContrasena.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
            TxtUsuario.Text = string.Empty;
            Calendar.Text = string.Empty;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
