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
using System.IO;

namespace Programa_Hacienda
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }
        string manual;
        private void Insertar_Load(object sender, EventArgs e)
        {

        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(cboArea.Text)) || (string.IsNullOrWhiteSpace(cboEstado.Text)) || (string.IsNullOrWhiteSpace(cboTipo.Text)) || (string.IsNullOrWhiteSpace(cboOficina.Text)) || (string.IsNullOrWhiteSpace(dateTPFecha.Text)))
            {
                MessageBox.Show("Necesitas llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                /*--------------------------------------------------------------------------------------------------------------------------------------*/
                string cadenaConexion = @"Data Source=.; Initial catalog=Hacienda; Integrated Security=true";
                bool success = false;
                SqlConnection LaConexion = null;
                SqlTransaction LaTransaccion = null;
                int Valor_Retornado = 0;
                try
                {
                    LaConexion = new SqlConnection();
                    LaConexion.ConnectionString = cadenaConexion;
                    LaConexion.Open();

                    LaTransaccion = LaConexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    SqlCommand Comando = new SqlCommand("spInsertar", LaConexion, LaTransaccion);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Clear();

                    Comando.Parameters.AddWithValue("@Area", cboArea.Text);
                    Comando.Parameters.AddWithValue("@Oficina", cboOficina.Text);
                    Comando.Parameters.AddWithValue("@TipoManual", cboTipo.Text);
                    Comando.Parameters.AddWithValue("@Estado", cboEstado.Text);
                    Comando.Parameters.AddWithValue("@Fecha", dateTPFecha.Text);
                    SqlParameter ValorRetorno = new SqlParameter("@Comprobacion", SqlDbType.Int);
                    ValorRetorno.Direction = ParameterDirection.Output;
                    Comando.Parameters.Add(ValorRetorno);
                    Comando.ExecuteNonQuery();
                    Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                    if (Valor_Retornado == 1)
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
                        LaTransaccion.Commit();
                        LaConexion.Close();
                        MessageBox.Show("Registro guardado\nsatisfactoriamente ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cboArea.Text = "";
            cboEstado.Text = "";
            cboTipo.Text = "";
            cboOficina.Text = "";
            dateTPFecha.ResetText();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Menu_Principal MP = new Menu_Principal();
            MP.Show();
            this.Close();
        }

        private void cmdManual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTipo.Text) || string.IsNullOrWhiteSpace(cboOficina.Text))
            {
                MessageBox.Show("Tipo y Oficina son campos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OpenFileDialog OF = new OpenFileDialog();
                OF.Filter = "Pdf Files|*.pdf";
                OF.Title = "Elegir PDF";
                OF.InitialDirectory = @"C:\Users\SalaF11\Pictures";
                OF.ShowDialog();
                /*-------------------------------------------------------------------------------------------------------------------------------*/
                if (cboTipo.Text == "Manual de Organizacion")
                {
                    manual = "1";
                }
                if (cboTipo.Text == "Manual de Procedimientos")
                {
                    manual = "2";
                }
                /*-------------------------------------------------------------------------------------------------------------------------------*/

                string sourceFile = OF.FileName;
                string destinationFile = @"E:\Programa Hacienda\Programa Hacienda\DOCUMENTOS\" + cboOficina.Text + Convert.ToString(manual) + ".pdf";
                if (!File.Exists(OF.FileName))
                {
                    File.Move(sourceFile, destinationFile);
                    if (File.Exists(@"E:\Programa Hacienda\Programa Hacienda\DOCUMENTOS\" + cboOficina.Text + Convert.ToString(manual) + ".pdf"))
                    {
                        MessageBox.Show("Manual ingresado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Manual no ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DialogResult replaceresult = MessageBox.Show("¿Quieres remplazarlo?", "El manual existe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (replaceresult == DialogResult.Yes)
                    {
                        /*--------------------------------------------------------------------------------------*/
                        string cadenaConexion = @"Data Source=.; Initial catalog=Hacienda; Integrated Security=true";
                        bool success = false;
                        SqlConnection LaConexion = null;
                        SqlTransaction LaTransaccion = null;
                        int Valor_Retornado = 0;
                        try
                        {
                            LaConexion = new SqlConnection();
                            LaConexion.ConnectionString = cadenaConexion;
                            LaConexion.Open();
                            LaTransaccion = LaConexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                            SqlCommand Comando = new SqlCommand("spManual", LaConexion, LaTransaccion);
                            Comando.CommandType = CommandType.StoredProcedure;
                            Comando.Parameters.Clear();
                            Comando.Parameters.AddWithValue("@Oficina", cboOficina.Text);
                            Comando.Parameters.AddWithValue("@Tipo", cboTipo.Text);
                            SqlParameter ValorRetorno = new SqlParameter("@Comprobacion", SqlDbType.Int);
                            ValorRetorno.Direction = ParameterDirection.Output;
                            Comando.Parameters.Add(ValorRetorno);
                            Comando.ExecuteNonQuery();
                            Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                            if (Valor_Retornado == 1)
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
                                LaTransaccion.Commit();
                                LaConexion.Close();
                                File.Delete(@"E:\Programa Hacienda\Programa Hacienda\DOCUMENTOS\" + cboOficina.Text + Convert.ToString(manual) + ".pdf");
                                File.Move(sourceFile, destinationFile); ;

                            }
                            else
                            {
                                LaTransaccion.Rollback();
                                LaConexion.Close();
                            }


                        }
                    }
                    if (File.Exists(@"E:\Programa Hacienda\Programa Hacienda\DOCUMENTOS\" + cboOficina.Text + Convert.ToString(manual) + ".pdf"))
                    {
                        MessageBox.Show("Manual Ingresado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Manual no ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
