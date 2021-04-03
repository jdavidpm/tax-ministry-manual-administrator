using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Programa_Hacienda
{
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }
        private static string _archivo;
        public string archivo
        {
            get { return _archivo; }
            set { _archivo = value; }
        }
        
        string file, file2, ele1, ele2;
       
        public bool Adj = true;

        

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            
            Oficinas_Principales OP = new Oficinas_Principales();
            file = Convert.ToString(OP.producto);
            string directory = @"E:\Programa Hacienda\Programa Hacienda\DOCUMENTOS\" + file;
            /*---------------------------------------------------------------------------------------------------*/
            Unidad_Responsable UR = new Unidad_Responsable();
            file2 = Convert.ToString(UR.producto2);
            string directory2 = @"E:\Programa Hacienda\Programa Hacienda\DOCUMENTOS\" + file2;
            /*---------------------------------------------------------------------------------------------------*/
            if (Convert.ToString(UR.producto2) == null)
            {
                if (!File.Exists(@"E:\Programa Hacienda\Programa Hacienda\DOCUMENTOS\" + file))
                {
                    MessageBox.Show("Manual Inexistente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    axAcroPDF1.LoadFile(directory);
                    cmdEnviar.Enabled = true;
                }
            }
            /*---------------------------------------------------------------------------------------------------*/
            if (Convert.ToString(OP.producto) == null)
            {
                if (!File.Exists(@"E:\Programa Hacienda\Programa Hacienda\DOCUMENTOS\" + file2))
                {
                    MessageBox.Show("Manual Inexistente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    axAcroPDF1.LoadFile(directory2);
                    cmdEnviar.Enabled = true;
                }
            }
            /*---------------------------------------------------------------------------------------------------*/
            ele1 = Convert.ToString(OP.choiceOP);
            ele2 = Convert.ToString(UR.choiceUR);
            if(ele1 == "oficinas")
            {
                archivo = directory;
            }
            if (ele2 == "unidad")
            {
                archivo = directory2;
            }           
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Oficinas_Principales OP = new Oficinas_Principales();
            OP.producto = null;

            Unidad_Responsable UR = new Unidad_Responsable();
            UR.producto2 = null;

            Menu_Principal MP = new Menu_Principal();
            MP.Show();
            this.Close();
        }

        private void cmdEnviar_Click(object sender, EventArgs e)
        {
            Correo email = new Correo();
            email.Show();
        }
    }
}
