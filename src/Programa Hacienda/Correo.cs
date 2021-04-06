using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Programa_Hacienda
{
    public partial class Correo : Form
    {
        public Correo()
        {
            InitializeComponent();
        }
        private void cmdEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFrom.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtTo.Text))
            {
                MessageBox.Show("Ambos correos y contraseña \nson necesarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MailMessage _Correo = new MailMessage();
                _Correo.From = new MailAddress(txtFrom.Text);
                _Correo.To.Add(txtTo.Text);
                _Correo.Subject = txtAsunto.Text;
                _Correo.Body = txtCont.Text;
                _Correo.IsBodyHtml = false;
                _Correo.Priority = MailPriority.Normal;
                Manual manual = new Manual();
                if (manual.Adj == true)
                {
                    Attachment _attachment = new Attachment(@Convert.ToString(manual.archivo));
                    _Correo.Attachments.Add(_attachment);
                    manual.Adj = false;
                }


                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                NetworkCredential credentials = new NetworkCredential(txtFrom.Text, txtContraseña.Text, "");
                smtp.Credentials = credentials;
                try
                {
                    smtp.Send(_Correo);
                    MessageBox.Show("Correo enviado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch
                {
                    MessageBox.Show("No se pudo enviar el correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _Correo.Dispose();

            }
        }
    }
}
