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
    public partial class Oficinas_Principales : Form
    {
        public Oficinas_Principales()
        {
            InitializeComponent();
        }

        private static string _producto;

        public string producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        string nombre1, nombre2;


        public string choiceOP = "oficinas";
        Manual pdf = new Manual();

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            nombre1 = cbomo.Text;
            nombre2 = cbomp.Text;
            if ((string.IsNullOrEmpty(cbomo.Text)) && (string.IsNullOrEmpty(cbomp.Text)))
            {
                MessageBox.Show("Tienes que seleccionar uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                if (nombre1 == "1001")
                {
                    producto = "1001.pdf";
                    pdf.Show();
                    Close();
                }
                if (nombre1 == "2001")
                {
                    producto = "2001.pdf";
                    pdf.Show();
                    Close();
                }
                if (nombre1 == "3001")
                {
                    producto = "3001.pdf";
                    pdf.Show();
                    Close();
                }
                if (nombre1 == "4001")
                {
                    producto = "4001.pdf";
                    pdf.Show();
                    Close();
                }
            /*------------------------------------------------------------------*/
                if (nombre2 == "1002")
                {
                    producto = "1002.pdf";
                    pdf.Show();
                    Close();
                }
                if (nombre2 == "2002")
                {
                    producto = "2002.pdf";
                    pdf.Show();
                    Close();
                }
                if (nombre2 == "3002")
                {
                    producto = "3002.pdf";pdf.Show();
                    Close();
                }
                if (nombre2 == "4002")
                {
                    producto = "4002.pdf";
                    pdf.Show();
                    Close();
                }
            
           }

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Menu_Principal MP = new Menu_Principal();
            MP.Show();
            this.Close();
        }

        private void cbomo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbomo.Text)
            {
                case "1001":
                    cbomp.Enabled = false;
                    break;
                case "2001":
                    cbomp.Enabled = false;
                    break;
                case "3001":
                    cbomp.Enabled = false;
                    break;
                case "4001":
                    cbomp.Enabled = false;
                    break;
                default:
                    cbomp.Enabled = true;
                    break;

            }
        }

        private void cbomp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbomp.Text)
            {
                case "1002":
                    cbomo.Enabled = false;
                    break;
                case "2002":
                    cbomo.Enabled = false;
                    break;
                case "3002":
                    cbomo.Enabled = false;
                    break;
                case "4002":
                    cbomo.Enabled = false;
                    break;
                default:
                    cbomo.Enabled = true;
                    break;

            }
        }

        private void Oficinas_Principales_Load(object sender, EventArgs e)
        {

        }
    }
}
