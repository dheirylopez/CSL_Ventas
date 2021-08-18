namespace CSL_Ventas.Win.Operaciones.ReportesBolantes
{
    partial class FormCotizacionBolante
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetReportes = new CSL_Ventas.Win.Operaciones.DataSetReportes();
            this.viewCotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewCotizacionTableAdapter = new CSL_Ventas.Win.Operaciones.DataSetReportesTableAdapters.ViewCotizacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCotizacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCotizacion";
            reportDataSource1.Value = this.viewCotizacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CSL_Ventas.Win.Operaciones.ReportesBolantes.ReportBolanteCotizacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(624, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetReportes
            // 
            this.dataSetReportes.DataSetName = "DataSetReportes";
            this.dataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewCotizacionBindingSource
            // 
            this.viewCotizacionBindingSource.DataMember = "ViewCotizacion";
            this.viewCotizacionBindingSource.DataSource = this.dataSetReportes;
            // 
            // viewCotizacionTableAdapter
            // 
            this.viewCotizacionTableAdapter.ClearBeforeFill = true;
            // 
            // FormCotizacionBolante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 349);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormCotizacionBolante";
            this.Text = "Reporte Cotizacion";
            this.Load += new System.EventHandler(this.FormCotizacionBolante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCotizacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetReportes dataSetReportes;
        private System.Windows.Forms.BindingSource viewCotizacionBindingSource;
        private DataSetReportesTableAdapters.ViewCotizacionTableAdapter viewCotizacionTableAdapter;
    }
}