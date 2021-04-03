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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }
        string variable;
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (rboOP.Checked == true)
            {
               Oficinas_Principales OP = new Oficinas_Principales();
               OP.Show();
               this.Hide();
            }
            if (rboUR.Checked == true)
            {
                Unidad_Responsable UR = new Unidad_Responsable();
                UR.Show();
                this.Hide();
            }
            if (rboHistorial.Checked == true)
            {
                Historial Historial = new Historial();
                Historial.Show();
                this.Hide();
            }
            if (rboInsertar.Checked == true)
            {
                Insertar insertar = new Insertar();
                insertar.Show();
                this.Hide();
            }
            if ((rboOP.Checked == false) && (rboUR.Checked == false) && (rboHistorial.Checked == false) && (rboInsertar.Checked == false))
            {
                MessageBox.Show("Tienes que seleccionar uno", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

            Logeo varia = new Logeo();
            variable = Convert.ToString(varia.usuario);
            if (variable == "A")
            {
                rboInsertar.Enabled = true;
            }
            if (variable == "C")
            {
                rboInsertar.Enabled = false;
            }
            
            
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Salir de Aplicacion", "¿Estas seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Adios, vuelva pronto", "Cerrando aplicacion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
