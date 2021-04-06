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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }
        public string Area, TipoManual, Estado, Eleccion;
         public DateTime Fecha { get; set; }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataHistorial.spConsulta' Puede moverla o quitarla según sea necesario.
            this.spConsultaTableAdapter.Fill(this.DataHistorial.spConsulta,Area,TipoManual, Estado, Eleccion, Fecha);

            this.reportViewer1.RefreshReport();
        }
    }
}
