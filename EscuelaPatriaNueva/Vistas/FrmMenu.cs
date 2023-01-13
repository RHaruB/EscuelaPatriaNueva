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
    public partial class FrmMenu : Form
    {
        public FrmMenu(UsuarioVM usuarioVM )
        {
            InitializeComponent();
            MessageBox.Show($"Bienvenido {usuarioVM.Nombre_Usuario1}");
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario frmRegistrarUsuario = new FrmRegistrarUsuario();
            this.Hide();
            frmRegistrarUsuario.ShowDialog();
            this.Show();
        }
    }
}
