namespace CSL_Ventas.Win.Operaciones.ReportesBolantes
{
    partial class FormFactura
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
            this.dataSetReportes = new CSL_Ventas.Win.Operaciones.DataSetReportes();
            this.dataSetReportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.volanteFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.volanteFacturaTableAdapter = new CSL_Ventas.Win.Operaciones.DataSetReportesTableAdapters.VolanteFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volanteFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetReportes
            // 
            this.dataSetReportes.DataSetName = "DataSetReportes";
            this.dataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetReportesBindingSource
            // 
            this.dataSetReportesBindingSource.DataSource = this.dataSetReportes;
            this.dataSetReportesBindingSource.Position = 0;
            // 
            // reportViewerFactura
            // 
            this.reportViewerFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewerFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVolanteFactura";
            reportDataSource1.Value = this.volanteFacturaBindingSource;
            this.reportViewerFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerFactura.LocalReport.ReportEmbeddedResource = "CSL_Ventas.Win.Operaciones.ReportesBolantes.ReportVolante.rdlc";
            this.reportViewerFactura.Location = new System.Drawing.Point(0, 0);
            this.reportViewerFactura.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewerFactura.Name = "reportViewerFactura";
            this.reportViewerFactura.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewerFactura.Size = new System.Drawing.Size(651, 389);
            this.reportViewerFactura.TabIndex = 0;
            // 
            // volanteFacturaBindingSource
            // 
            this.volanteFacturaBindingSource.DataMember = "VolanteFactura";
            this.volanteFacturaBindingSource.DataSource = this.dataSetReportesBindingSource;
            // 
            // volanteFacturaTableAdapter
            // 
            this.volanteFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 389);
            this.Controls.Add(this.reportViewerFactura);
            this.DoubleBuffered = true;
            this.Name = "FormFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volanteFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFactura;
        private System.Windows.Forms.BindingSource dataSetReportesBindingSource;
        private DataSetReportes dataSetReportes;
        private System.Windows.Forms.BindingSource volanteFacturaBindingSource;
        private DataSetReportesTableAdapters.VolanteFacturaTableAdapter volanteFacturaTableAdapter;
    }
}