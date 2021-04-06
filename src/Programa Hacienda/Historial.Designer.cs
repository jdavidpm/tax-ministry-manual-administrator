namespace Programa_Hacienda
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.lblO = new System.Windows.Forms.Label();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.dateTPHistorial = new System.Windows.Forms.DateTimePicker();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblManual = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.toolTipHistorial = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.BackColor = System.Drawing.Color.Transparent;
            this.lblO.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO.Location = new System.Drawing.Point(416, 164);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(26, 23);
            this.lblO.TabIndex = 41;
            this.lblO.Text = "Ó";
            this.toolTipHistorial.SetToolTip(this.lblO, "Area, Tipo de Manual y Estado, son un campo, por lo que no puedes elegirlos si es" +
        "cogiste fecha.");
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.BackColor = System.Drawing.Color.Silver;
            this.cmdLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLimpiar.FlatAppearance.BorderSize = 0;
            this.cmdLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLimpiar.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(56, 238);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(73, 29);
            this.cmdLimpiar.TabIndex = 40;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = false;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // dateTPHistorial
            // 
            this.dateTPHistorial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPHistorial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPHistorial.Location = new System.Drawing.Point(339, 200);
            this.dateTPHistorial.Name = "dateTPHistorial";
            this.dateTPHistorial.Size = new System.Drawing.Size(200, 22);
            this.dateTPHistorial.TabIndex = 39;
            this.dateTPHistorial.ValueChanged += new System.EventHandler(this.dateTPHistorial_ValueChanged);
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
            this.cmdSalir.Location = new System.Drawing.Point(704, 238);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(73, 29);
            this.cmdSalir.TabIndex = 38;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
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
            this.cmdAceptar.Location = new System.Drawing.Point(404, 238);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(73, 29);
            this.cmdAceptar.TabIndex = 37;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = false;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(657, 41);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 24);
            this.cboEstado.TabIndex = 36;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(583, 40);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 21);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "Estado:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "",
            "Manual de Organizacion",
            "Manual de Procedimientos"});
            this.cboTipo.Location = new System.Drawing.Point(394, 40);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(149, 24);
            this.cboTipo.TabIndex = 34;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.BackColor = System.Drawing.Color.Transparent;
            this.lblManual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual.Location = new System.Drawing.Point(253, 43);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(135, 21);
            this.lblManual.TabIndex = 33;
            this.lblManual.Text = "Tipo de Manual:";
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Items.AddRange(new object[] {
            "",
            "Oficina Principal",
            "Unidad Responsable"});
            this.cboArea.Location = new System.Drawing.Point(105, 40);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(121, 24);
            this.cboArea.TabIndex = 32;
            this.cboArea.SelectedIndexChanged += new System.EventHandler(this.cboArea_SelectedIndexChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(30, 43);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(53, 21);
            this.lblArea.TabIndex = 31;
            this.lblArea.Text = "Area:";
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.BackColor = System.Drawing.Color.Transparent;
            this.lblHistorial.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(378, 23);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(90, 25);
            this.lblHistorial.TabIndex = 30;
            this.lblHistorial.Text = "Historial";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Controls.Add(this.cboArea);
            this.groupBox1.Controls.Add(this.lblManual);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 100);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::Programa_Hacienda.Properties.Resources.fondogris;
            this.ClientSize = new System.Drawing.Size(840, 284);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.dateTPHistorial);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.lblHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.DateTimePicker dateTPHistorial;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.ToolTip toolTipHistorial;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}