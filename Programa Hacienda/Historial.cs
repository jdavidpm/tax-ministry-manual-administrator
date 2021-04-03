using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Programa_Hacienda
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }
       
        int eleccion = 0;
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            
            if (cboArea.Enabled == true)
            {
                eleccion = 1;
            }
            if (dateTPHistorial.Enabled == true)
            {
                eleccion = 2;
            }
            if ((dateTPHistorial.Enabled == true) && (cboArea.Enabled == true) || ((string.IsNullOrWhiteSpace(cboArea.Text) || string.IsNullOrWhiteSpace(cboTipo.Text) || string.IsNullOrWhiteSpace(cboEstado.Text)) && (dateTPHistorial.Enabled == false)))
            {
                MessageBox.Show("Selecciona algunos de los campos completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                /*--------------------------------------------------------------------------------------*/
                string cadenaConexion = @"Data Source=.; Initial catalog=Hacienda; Integrated Security=true";
                bool success = false;
                SqlConnection LaConexion = null;
                SqlTransaction LaTransaccion = null;
                try
                {
                    LaConexion = new SqlConnection();
                    LaConexion.ConnectionString = cadenaConexion;
                    LaConexion.Open();

                    LaTransaccion = LaConexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    SqlCommand Comando = new SqlCommand("spConsulta", LaConexion, LaTransaccion);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("@Area", cboArea.Text);
                    Comando.Parameters.AddWithValue("@TipoManual", cboTipo.Text);
                    Comando.Parameters.AddWithValue("@Estado", cboEstado.Text);
                    Comando.Parameters.AddWithValue("@Eleccion", Convert.ToString(eleccion));
                    Comando.Parameters.AddWithValue("@Fecha", dateTPHistorial.Text);
                    Comando.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (success)
                    {
                        Reporte reporte = new Reporte();
                        reporte.Area = cboArea.Text;
                        reporte.TipoManual = cboTipo.Text;
                        reporte.Estado = cboEstado.Text;
                        reporte.Eleccion = Convert.ToString(eleccion);
                        reporte.Fecha = dateTPHistorial.Value;
                        reporte.ShowDialog();

                    }
                    else
                    {
                        LaTransaccion.Rollback();
                        LaConexion.Close();
                    }


                }
            }

            
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            historial.ResetMouseEventArgs();
            cboArea.Text = "";
            cboEstado.Text = "";
            cboTipo.Text = "";
            dateTPHistorial.ResetText();
            dateTPHistorial.Enabled = true;
            cboArea.Enabled = true;
            cboTipo.Enabled = true;
            cboEstado.Enabled = true;
            
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Menu_Principal MP = new Menu_Principal();
            MP.Show();
            this.Close();
        }
        private void Historial_Load(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(cboArea.Text) && (string.IsNullOrEmpty(cboEstado.Text)) && (string.IsNullOrEmpty(cboTipo.Text))))
            {
                dateTPHistorial.Enabled = true;
            }
        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dateTPHistorial.Enabled = false;
          
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTPHistorial.Enabled = false;
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTPHistorial.Enabled = false;
        }

        private void dateTPHistorial_ValueChanged(object sender, EventArgs e)
        {
            cboArea.Enabled = false;
            cboEstado.Enabled = false;
            cboTipo.Enabled = false;
        }
        public Control panel { get; set; }

       
    }
}
