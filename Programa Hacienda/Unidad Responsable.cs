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
    public partial class Unidad_Responsable : Form
    {
        public Unidad_Responsable()
        {
            InitializeComponent();
        }

        string nombre, nombre1, nombre2, nombre3, nombre4, nombre5, nombre6, nombre7;

        private static string _producto2;

        public string producto2
        {
            get { return _producto2; }
            set { _producto2 = value; }
        }


        public string choiceUR = "unidad";

        Manual pdf = new Manual();
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            nombre = cbo100mo.Text;
            nombre1 = cbo200mo.Text;
            nombre2 = cbo300mo.Text;
            nombre3 = cbo400mo.Text;
            nombre4 = cbo100mp.Text;
            nombre5 = cbo200mp.Text;
            nombre6 = cbo300mp.Text;
            nombre7 = cbo400mp.Text;


            if (nombre == "1101")
            {
                producto2 = "1101.pdf";
                pdf.Show();
                Close();
            }
            if (nombre == "1111")
            {
                producto2 = "1111.pdf";
                pdf.Show();
                Close();
            }
            if (nombre == "1121")
            {
                producto2 = "1121.pdf";
                pdf.Show();
                Close();
            }
            if (nombre1 == "2101")
            {
                producto2 = "2101.pdf";
                pdf.Show();
                Close();
            }
            if (nombre1 == "2111")
            {
                producto2 = "2111.pdf";
                pdf.Show();
                Close();
            }
            if (nombre1 == "2121")
            {
                producto2 = "2121.pdf";
                pdf.Show();
                Close();
            }
            if (nombre2 == "3101")
            {
                producto2 = "3101.pdf";
                pdf.Show();
                Close();
            }
            if (nombre2 == "3111")
            {
                producto2 = "3111.pdf";
                pdf.Show();
                Close();
            }
            if (nombre2 == "3121")
            {
                producto2 = "3121.pdf";
                pdf.Show();
                Close();
            }
            if (nombre3 == "4101")
            {
                producto2 = "4101.pdf";
                pdf.Show();
                Close();
            }
            if (nombre3 == "4111")
            {
                producto2 = "4111.pdf";
                pdf.Show();
                Close();
            }
            if (nombre3 == "4121")
            {
                producto2 = "4121.pdf";
                pdf.Show();
                Close();
            }
            /*-----------------------------------------------------------------------*/
            if (nombre4 == "1102")
            {
                producto2 = "1102.pdf";
                pdf.Show();
                Close();
            }
            if (nombre4 == "1112")
            {
                producto2 = "1112.pdf";
                pdf.Show();
                Close();
            }
            if (nombre4 == "1122")
            {
                producto2 = "1122.pdf";
                pdf.Show();
                Close();
            }
            if (nombre5 == "2102")
            {
                producto2 = "2102.pdf";
                pdf.Show();
                Close();
            }
            if (nombre5 == "2112")
            {
                producto2 = "2112.pdf";
                pdf.Show();
                Close();
            }
            if (nombre5 == "2122")
            {
                producto2 = "2122.pdf";
                pdf.Show();
                Close();
            }
            if (nombre6 == "3102")
            {
                producto2 = "3102.pdf";
                pdf.Show();
                Close();
            }
            if (nombre6 == "3112")
            {
                producto2 = "3112.pdf";
                pdf.Show();
                Close();
            }
            if (nombre6 == "3122")
            {
                producto2 = "3122.pdf";
                pdf.Show();
                Close();
            }
            if (nombre7 == "4102")
            {
                producto2 = "4102.pdf";
                pdf.Show();
                Close();
            }
            if (nombre7 == "4112")
            {
                producto2 = "4112.pdf";
                pdf.Show();
                Close();
            }
            if (nombre7 == "4122")
            {
                producto2 = "4122.pdf";
                pdf.Show();
                Close();
            }
            /*----------------------------------------------------------------------------------------*/
            
            if ((string.IsNullOrWhiteSpace(nombre)) && (string.IsNullOrWhiteSpace(nombre1)) && (string.IsNullOrWhiteSpace(nombre2)) && (string.IsNullOrWhiteSpace(nombre3)) && (string.IsNullOrWhiteSpace(nombre4)) && (string.IsNullOrWhiteSpace(nombre5)) && (string.IsNullOrWhiteSpace(nombre6)) && (string.IsNullOrWhiteSpace(nombre7)))
            {
                MessageBox.Show("Tienes que seleccionar uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Menu_Principal MP = new Menu_Principal();
            MP.Show();
            this.Close();
        }

        private void cbo100mo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo100mo.Text)
            {
                case "1101":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "1111":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "1121":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                default:
                    cbo200mo.Enabled = true;
                    cbo300mo.Enabled = true;
                    cbo400mo.Enabled = true;
                    cbo100mp.Enabled = true;
                    cbo200mp.Enabled = true;
                    cbo300mp.Enabled = true;
                    cbo400mp.Enabled = true;
                    break;

            }
        }

        private void cbo200mo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo200mo.Text)
            {
                case "2101":
                    cbo100mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "2111":
                    cbo100mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "2121":
                    cbo100mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                default:
                    cbo100mo.Enabled = true;
                    cbo300mo.Enabled = true;
                    cbo400mo.Enabled = true;
                    cbo100mp.Enabled = true;
                    cbo200mp.Enabled = true;
                    cbo300mp.Enabled = true;
                    cbo400mp.Enabled = true;
                    break;
            }
        }

        private void cbo300mo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo300mo.Text)
            {
                case "3101":
                    cbo100mo.Enabled = false;
                    cbo200mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "3111":
                    cbo100mo.Enabled = false;
                    cbo200mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "3121":
                    cbo100mo.Enabled = false;
                    cbo200mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                default:
                    cbo100mo.Enabled = true;
                    cbo200mo.Enabled = true;
                    cbo400mo.Enabled = true;
                    cbo100mp.Enabled = true;
                    cbo200mp.Enabled = true;
                    cbo300mp.Enabled = true;
                    cbo400mp.Enabled = true;
                    break;
            }
        }

        private void cbo400mo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo400mo.Text)
            {
                case "4101":
                    cbo100mo.Enabled = false;
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "4111":
                    cbo100mo.Enabled = false;
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "4121":
                    cbo100mo.Enabled = false;
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                default:
                    cbo100mo.Enabled = true;
                    cbo200mo.Enabled = true;
                    cbo300mo.Enabled = true;
                    cbo100mp.Enabled = true;
                    cbo200mp.Enabled = true;
                    cbo300mp.Enabled = true;
                    cbo400mp.Enabled = true;
                    break;
            }
        }

        private void cbo100mp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo100mp.Text)
            {
                case "1102":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mo.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "1112":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mo.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "1122":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mo.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                default:
                    cbo200mo.Enabled = true;
                    cbo300mo.Enabled = true;
                    cbo400mo.Enabled = true;
                    cbo100mo.Enabled = true;
                    cbo200mp.Enabled = true;
                    cbo300mp.Enabled = true;
                    cbo400mp.Enabled = true;
                    break;

            }
        }

        private void cbo200mp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo200mp.Text)
            {
                case "2102":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "2112":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "2122":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                default:
                    cbo200mo.Enabled = true;
                    cbo300mo.Enabled = true;
                    cbo400mo.Enabled = true;
                    cbo100mo.Enabled = true;
                    cbo100mp.Enabled = true;
                    cbo300mp.Enabled = true;
                    cbo400mp.Enabled = true;
                    break;

            }
        }

        private void cbo300mp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo300mp.Text)
            {
                case "3102":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "3112":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                case "3122":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                default:
                    cbo200mo.Enabled = true;
                    cbo300mo.Enabled = true;
                    cbo400mo.Enabled = true;
                    cbo100mo.Enabled = true;
                    cbo100mp.Enabled = true;
                    cbo200mp.Enabled = true;
                    cbo400mp.Enabled = true;
                    break;

            }
        }

        private void cbo400mp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo400mp.Text)
            {
                case "4102":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    break;
                case "4112":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo300mp.Enabled = false;
                    break;
                case "4122":
                    cbo200mo.Enabled = false;
                    cbo300mo.Enabled = false;
                    cbo400mo.Enabled = false;
                    cbo100mo.Enabled = false;
                    cbo100mp.Enabled = false;
                    cbo200mp.Enabled = false;
                    cbo400mp.Enabled = false;
                    break;
                default:
                    cbo200mo.Enabled = true;
                    cbo300mo.Enabled = true;
                    cbo400mo.Enabled = true;
                    cbo100mo.Enabled = true;
                    cbo100mp.Enabled = true;
                    cbo200mp.Enabled = true;
                    cbo300mp.Enabled = true;
                    break;

            }
        }
    }
}
