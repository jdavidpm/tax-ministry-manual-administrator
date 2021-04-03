namespace Programa_Hacienda
{
    partial class Reporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            this.spConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataHistorial = new Programa_Hacienda.DataHistorial();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spConsultaTableAdapter = new Programa_Hacienda.DataHistorialTableAdapters.spConsultaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // spConsultaBindingSource
            // 
            this.spConsultaBindingSource.DataMember = "spConsulta";
            this.spConsultaBindingSource.DataSource = this.DataHistorial;
            // 
            // DataHistorial
            // 
            this.DataHistorial.DataSetName = "DataHistorial";
            this.DataHistorial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spConsultaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Programa_Hacienda.ReporteHistorial.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(723, 605);
            this.reportViewer1.TabIndex = 0;
            // 
            // spConsultaTableAdapter
            // 
            this.spConsultaTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(723, 605);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spConsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spConsultaBindingSource;
        private DataHistorial DataHistorial;
        private DataHistorialTableAdapters.spConsultaTableAdapter spConsultaTableAdapter;
    }
}