using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Hacienda
{
    public partial class Logeo : Form
    {
        public Logeo()
        {
            InitializeComponent();
        }
        string contraseña = "SHCP", contraseñaMaestra = "contraseña",usuarioC ="Consultor", usuarioA ="Administrador";
        int v = 3;

        private static string _usuario;

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        bool admi = false, consu = false;
        
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if ((txtContraseña.Text == contraseñaMaestra) && (txtUsuario.Text == usuarioA))
            {
                MessageBox.Show("Bienvenido " + txtUsuario.Text,"SHCP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario = "A";
                admi = true;
                txtContraseña.Enabled = false;
                txtUsuario.Enabled = false;
                Menu_Principal Menu = new Menu_Principal();
                Menu.Show();
                this.Hide();
            }

            if ((txtContraseña.Text == contraseña) && (txtUsuario.Text == usuarioC))
            {
                MessageBox.Show("Bienvenido " + txtUsuario.Text, "SHCP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario = "C";
                consu = true;
                txtContraseña.Enabled = false;
                txtUsuario.Enabled = false;
                Menu_Principal Menu = new Menu_Principal();
                Menu.Show();
                this.Hide();
            }
            if ((consu==false) && (admi==false))
            {
                MessageBox.Show("Inténtalo de nuevo", "Contraseña o Usuario Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Text = "";
                txtUsuario.Text = "";
                v = v - 1;
            }
            if (v == 0)
            {
                MessageBox.Show("Adiós, demasiados intentos", "Contraseña o Usuario Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            
            
            
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            admi = false;
            consu = false;
            txtContraseña.Enabled = true;
            txtUsuario.Enabled = true;
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Salir de Aplicacion", "¿Estas seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Adios, vuelva pronto", "Cerrando aplicacion...",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
