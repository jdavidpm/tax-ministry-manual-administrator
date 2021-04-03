namespace Programa_Hacienda
{
    partial class Oficinas_Principales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oficinas_Principales));
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cbomp = new System.Windows.Forms.ComboBox();
            this.cbomo = new System.Windows.Forms.ComboBox();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblMO = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lblOP = new System.Windows.Forms.Label();
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
            this.cmdAceptar.Location = new System.Drawing.Point(91, 209);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(71, 31);
            this.cmdAceptar.TabIndex = 26;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = false;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cbomp
            // 
            this.cbomp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomp.FormattingEnabled = true;
            this.cbomp.Items.AddRange(new object[] {
            "",
            "1002",
            "2002",
            "3002",
            "4002"});
            this.cbomp.Location = new System.Drawing.Point(323, 140);
            this.cbomp.Name = "cbomp";
            this.cbomp.Size = new System.Drawing.Size(121, 24);
            this.cbomp.TabIndex = 25;
            this.cbomp.SelectedIndexChanged += new System.EventHandler(this.cbomp_SelectedIndexChanged);
            // 
            // cbomo
            // 
            this.cbomo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomo.FormattingEnabled = true;
            this.cbomo.Items.AddRange(new object[] {
            "",
            "1001",
            "2001",
            "3001",
            "4001"});
            this.cbomo.Location = new System.Drawing.Point(41, 140);
            this.cbomo.Name = "cbomo";
            this.cbomo.Size = new System.Drawing.Size(121, 24);
            this.cbomo.TabIndex = 24;
            this.cbomo.SelectedIndexChanged += new System.EventHandler(this.cbomo_SelectedIndexChanged);
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.BackColor = System.Drawing.Color.Transparent;
            this.lblMP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP.Location = new System.Drawing.Point(279, 91);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(218, 21);
            this.lblMP.TabIndex = 23;
            this.lblMP.Text = "Manual de Procedimientos";
            // 
            // lblMO
            // 
            this.lblMO.AutoSize = true;
            this.lblMO.BackColor = System.Drawing.Color.Transparent;
            this.lblMO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMO.Location = new System.Drawing.Point(12, 91);
            this.lblMO.Name = "lblMO";
            this.lblMO.Size = new System.Drawing.Size(204, 21);
            this.lblMO.TabIndex = 22;
            this.lblMO.Text = "Manual de Organización";
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
            this.cmdSalir.Location = new System.Drawing.Point(323, 209);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(71, 31);
            this.cmdSalir.TabIndex = 21;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.BackColor = System.Drawing.Color.Transparent;
            this.lblOP.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP.Location = new System.Drawing.Point(152, 25);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(211, 25);
            this.lblOP.TabIndex = 20;
            this.lblOP.Text = "Oficinas Principales";
            // 
            // Oficinas_Principales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::Programa_Hacienda.Properties.Resources.fondogris;
            this.ClientSize = new System.Drawing.Size(517, 276);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.cbomp);
            this.Controls.Add(this.cbomo);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.lblMO);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.lblOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Oficinas_Principales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oficinas Principales";
            this.Load += new System.EventHandler(this.Oficinas_Principales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.ComboBox cbomp;
        private System.Windows.Forms.ComboBox cbomo;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label lblMO;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblOP;
    }
}