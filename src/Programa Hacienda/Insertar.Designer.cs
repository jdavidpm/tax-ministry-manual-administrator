namespace Programa_Hacienda
{
    partial class Insertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insertar));
            this.lblInsertar = new System.Windows.Forms.Label();
            this.dateTPFecha = new System.Windows.Forms.DateTimePicker();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblManual = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblOficina = new System.Windows.Forms.Label();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdManual = new System.Windows.Forms.Button();
            this.cboOficina = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblInsertar
            // 
            this.lblInsertar.AutoSize = true;
            this.lblInsertar.BackColor = System.Drawing.Color.Transparent;
            this.lblInsertar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertar.Location = new System.Drawing.Point(356, 28);
            this.lblInsertar.Name = "lblInsertar";
            this.lblInsertar.Size = new System.Drawing.Size(87, 25);
            this.lblInsertar.TabIndex = 31;
            this.lblInsertar.Text = "Insertar";
            // 
            // dateTPFecha
            // 
            this.dateTPFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPFecha.Location = new System.Drawing.Point(411, 160);
            this.dateTPFecha.Name = "dateTPFecha";
            this.dateTPFecha.Size = new System.Drawing.Size(123, 22);
            this.dateTPFecha.TabIndex = 46;
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
            this.cboEstado.Location = new System.Drawing.Point(645, 96);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 24);
            this.cboEstado.TabIndex = 45;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(571, 94);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 21);
            this.lblEstado.TabIndex = 44;
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
            this.cboTipo.Location = new System.Drawing.Point(411, 96);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(123, 24);
            this.cboTipo.TabIndex = 43;
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.BackColor = System.Drawing.Color.Transparent;
            this.lblManual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual.Location = new System.Drawing.Point(244, 94);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(135, 21);
            this.lblManual.TabIndex = 42;
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
            this.cboArea.Location = new System.Drawing.Point(102, 96);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(121, 24);
            this.cboArea.TabIndex = 41;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(22, 95);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(53, 21);
            this.lblArea.TabIndex = 40;
            this.lblArea.Text = "Area:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(244, 163);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(161, 21);
            this.lblFecha.TabIndex = 47;
            this.lblFecha.Text = "Fecha de Inserción:";
            // 
            // lblOficina
            // 
            this.lblOficina.AutoSize = true;
            this.lblOficina.BackColor = System.Drawing.Color.Transparent;
            this.lblOficina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOficina.Location = new System.Drawing.Point(22, 161);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(70, 21);
            this.lblOficina.TabIndex = 48;
            this.lblOficina.Text = "Oficina:";
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
            this.cmdAceptar.Location = new System.Drawing.Point(248, 235);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(128, 29);
            this.cmdAceptar.TabIndex = 50;
            this.cmdAceptar.Text = "Insertar datos";
            this.cmdAceptar.UseVisualStyleBackColor = false;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
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
            this.cmdLimpiar.Location = new System.Drawing.Point(26, 235);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(73, 29);
            this.cmdLimpiar.TabIndex = 52;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = false;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
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
            this.cmdSalir.Location = new System.Drawing.Point(693, 235);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(73, 29);
            this.cmdSalir.TabIndex = 51;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdManual
            // 
            this.cmdManual.BackColor = System.Drawing.Color.Silver;
            this.cmdManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdManual.FlatAppearance.BorderSize = 0;
            this.cmdManual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdManual.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdManual.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdManual.Location = new System.Drawing.Point(406, 235);
            this.cmdManual.Name = "cmdManual";
            this.cmdManual.Size = new System.Drawing.Size(128, 29);
            this.cmdManual.TabIndex = 53;
            this.cmdManual.Text = "Insertar manual";
            this.cmdManual.UseVisualStyleBackColor = false;
            this.cmdManual.Click += new System.EventHandler(this.cmdManual_Click);
            // 
            // cboOficina
            // 
            this.cboOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOficina.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOficina.FormattingEnabled = true;
            this.cboOficina.Items.AddRange(new object[] {
            "",
            "100",
            "110",
            "111",
            "112",
            "200",
            "210",
            "211",
            "212",
            "300",
            "310",
            "311",
            "312",
            "400",
            "410",
            "411",
            "412"});
            this.cboOficina.Location = new System.Drawing.Point(102, 164);
            this.cboOficina.Name = "cboOficina";
            this.cboOficina.Size = new System.Drawing.Size(121, 24);
            this.cboOficina.TabIndex = 54;
            // 
            // Insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::Programa_Hacienda.Properties.Resources.fondogris;
            this.ClientSize = new System.Drawing.Size(831, 305);
            this.Controls.Add(this.cboOficina);
            this.Controls.Add(this.cmdManual);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.lblOficina);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dateTPFecha);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblManual);
            this.Controls.Add(this.cboArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblInsertar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Insertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar";
            this.Load += new System.EventHandler(this.Insertar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsertar;
        private System.Windows.Forms.DateTimePicker dateTPFecha;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblOficina;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdManual;
        private System.Windows.Forms.ComboBox cboOficina;
    }
}