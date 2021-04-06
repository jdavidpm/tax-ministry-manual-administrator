namespace Programa_Hacienda
{
    partial class Correo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correo));
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblPara = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.lblContenido = new System.Windows.Forms.Label();
            this.cmdEnviar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(197, 35);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(299, 22);
            this.txtFrom.TabIndex = 51;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.BackColor = System.Drawing.Color.Transparent;
            this.lblDe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(84, 34);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(36, 21);
            this.lblDe.TabIndex = 50;
            this.lblDe.Text = "De:";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(197, 101);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(299, 22);
            this.txtTo.TabIndex = 53;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.BackColor = System.Drawing.Color.Transparent;
            this.lblPara.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara.Location = new System.Drawing.Point(84, 100);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(50, 21);
            this.lblPara.TabIndex = 52;
            this.lblPara.Text = "Para:";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(113, 147);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(427, 22);
            this.txtAsunto.TabIndex = 55;
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.BackColor = System.Drawing.Color.Transparent;
            this.lblAsunto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(37, 148);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(70, 21);
            this.lblAsunto.TabIndex = 54;
            this.lblAsunto.Text = "Asunto:";
            // 
            // txtCont
            // 
            this.txtCont.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCont.Location = new System.Drawing.Point(41, 225);
            this.txtCont.Multiline = true;
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(499, 139);
            this.txtCont.TabIndex = 57;
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.BackColor = System.Drawing.Color.Transparent;
            this.lblContenido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(37, 201);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(98, 21);
            this.lblContenido.TabIndex = 56;
            this.lblContenido.Text = "Contenido:";
            // 
            // cmdEnviar
            // 
            this.cmdEnviar.BackColor = System.Drawing.Color.Silver;
            this.cmdEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdEnviar.FlatAppearance.BorderSize = 0;
            this.cmdEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEnviar.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnviar.Location = new System.Drawing.Point(245, 385);
            this.cmdEnviar.Name = "cmdEnviar";
            this.cmdEnviar.Size = new System.Drawing.Size(90, 31);
            this.cmdEnviar.TabIndex = 58;
            this.cmdEnviar.Text = "Enviar";
            this.cmdEnviar.UseVisualStyleBackColor = false;
            this.cmdEnviar.Click += new System.EventHandler(this.cmdEnviar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(197, 68);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(299, 22);
            this.txtContraseña.TabIndex = 60;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(84, 67);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(107, 21);
            this.lblContraseña.TabIndex = 59;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // Correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::Programa_Hacienda.Properties.Resources.fondogris;
            this.ClientSize = new System.Drawing.Size(582, 428);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.cmdEnviar);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Correo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Button cmdEnviar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
    }
}