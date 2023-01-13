using EscuelaPatriaNueva.Metodos;
using EscuelaPatriaNueva.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaPatriaNueva
{
    public partial class Loggin : Form
    {
        public Loggin()
        {
            InitializeComponent();
        }

        public bool ValidarVacios()
        {
            if(String.IsNullOrEmpty(TxtUsuario.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(TxtContrasena.Text))
            {
                return false;
            }
            return true;
        }
        private void Iniciar()
        {
            if (ValidarVacios())
            {
                UsuarioVM usuarioVM = new UsuarioVM
                {
                    Nombre_Usuario1 = TxtUsuario.Text,
                    Contraseña1 = TxtContrasena.Text
                };

                MetUsuarios met = new MetUsuarios();
                var existe_Usuario = met.MetListarUsuarios(usuarioVM);
                if (existe_Usuario)
                {
                    FrmMenu menu = new FrmMenu(usuarioVM);
                    this.Hide();
                    menu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto");
                }
                Vaciar();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }

        }
        private void Vaciar()
        {
            TxtUsuario.Text = String.Empty;
            TxtContrasena.Text = String.Empty;
        }

        private void BtnLoggin_Click(object sender, EventArgs e)
        {
            Iniciar();
        }
    }
}
