namespace Programa_Hacienda
{
    partial class Menu_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.rboHistorial = new System.Windows.Forms.RadioButton();
            this.rboUR = new System.Windows.Forms.RadioButton();
            this.rboOP = new System.Windows.Forms.RadioButton();
            this.lblMenu = new System.Windows.Forms.Label();
            this.rboInsertar = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.BackColor = System.Drawing.Color.Silver;
            this.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAceptar.FlatAppearance.BorderSize = 0;
            this.cmdAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAceptar.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAceptar.Location = new System.Drawing.Point(55, 364);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(78, 26);
            this.cmdAceptar.TabIndex = 21;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = false;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // rboHistorial
            // 
            this.rboHistorial.AutoSize = true;
            this.rboHistorial.BackColor = System.Drawing.Color.Transparent;
            this.rboHistorial.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboHistorial.Location = new System.Drawing.Point(110, 301);
            this.rboHistorial.Name = "rboHistorial";
            this.rboHistorial.Size = new System.Drawing.Size(99, 26);
            this.rboHistorial.TabIndex = 20;
            this.rboHistorial.Text = "Historial";
            this.rboHistorial.UseVisualStyleBackColor = false;
            // 
            // rboUR
            // 
            this.rboUR.AutoSize = true;
            this.rboUR.BackColor = System.Drawing.Color.Transparent;
            this.rboUR.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboUR.Location = new System.Drawing.Point(55, 188);
            this.rboUR.Name = "rboUR";
            this.rboUR.Size = new System.Drawing.Size(217, 26);
            this.rboUR.TabIndex = 19;
            this.rboUR.Text = "Unidad Responsable";
            this.rboUR.UseVisualStyleBackColor = false;
            // 
            // rboOP
            // 
            this.rboOP.AutoSize = true;
            this.rboOP.BackColor = System.Drawing.Color.Transparent;
            this.rboOP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboOP.Location = new System.Drawing.Point(55, 128);
            this.rboOP.Name = "rboOP";
            this.rboOP.Size = new System.Drawing.Size(206, 26);
            this.rboOP.TabIndex = 18;
            this.rboOP.Text = "Oficinas Principales";
            this.rboOP.UseVisualStyleBackColor = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(81, 51);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(164, 25);
            this.lblMenu.TabIndex = 17;
            this.lblMenu.Text = "Menú Principal";
            this.toolTip1.SetToolTip(this.lblMenu, "\"Insertar\" es solo para el administrador.");
            // 
            // rboInsertar
            // 
            this.rboInsertar.AutoSize = true;
            this.rboInsertar.BackColor = System.Drawing.Color.Transparent;
            this.rboInsertar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboInsertar.Location = new System.Drawing.Point(55, 246);
            this.rboInsertar.Name = "rboInsertar";
            this.rboInsertar.Size = new System.Drawing.Size(96, 26);
            this.rboInsertar.TabIndex = 22;
            this.rboInsertar.Text = "Insertar";
            this.toolTip1.SetToolTip(this.rboInsertar, "Esta opcion es solo para el Admnistrador.");
            this.rboInsertar.UseVisualStyleBackColor = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.Silver;
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalir.FlatAppearance.BorderSize = 0;
            this.cmdSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(194, 364);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(78, 26);
            this.cmdSalir.TabIndex = 23;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::Programa_Hacienda.Properties.Resources.fondogris;
            this.ClientSize = new System.Drawing.Size(335, 428);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.rboInsertar);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.rboHistorial);
            this.Controls.Add(this.rboUR);
            this.Controls.Add(this.rboOP);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.RadioButton rboHistorial;
        private System.Windows.Forms.RadioButton rboUR;
        private System.Windows.Forms.RadioButton rboOP;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.RadioButton rboInsertar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdSalir;
    }
}