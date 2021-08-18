namespace CSL_Ventas.Win.Operaciones
{
    partial class FormReporteCierre
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
            this.reportViewerCierreDia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetReportes = new CSL_Ventas.Win.Operaciones.DataSetReportes();
            this.CierreDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CierreDiaTableAdapter = new CSL_Ventas.Win.Operaciones.DataSetReportesTableAdapters.CierreDiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CierreDiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerCierreDia
            // 
            this.reportViewerCierreDia.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCierrededia";
            reportDataSource1.Value = this.CierreDiaBindingSource;
            this.reportViewerCierreDia.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCierreDia.LocalReport.ReportEmbeddedResource = "CSL_Ventas.Win.Operaciones.ReportesBolantes.Report1CierreDia.rdlc";
            this.reportViewerCierreDia.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCierreDia.Name = "reportViewerCierreDia";
            this.reportViewerCierreDia.Size = new System.Drawing.Size(520, 349);
            this.reportViewerCierreDia.TabIndex = 0;
            // 
            // DataSetReportes
            // 
            this.DataSetReportes.DataSetName = "DataSetReportes";
            this.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CierreDiaBindingSource
            // 
            this.CierreDiaBindingSource.DataMember = "CierreDia";
            this.CierreDiaBindingSource.DataSource = this.DataSetReportes;
            // 
            // CierreDiaTableAdapter
            // 
            this.CierreDiaTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 349);
            this.Controls.Add(this.reportViewerCierreDia);
            this.DoubleBuffered = true;
            this.Name = "FormReporteCierre";
            this.Text = "Reporte Cierre";
            this.Load += new System.EventHandler(this.FormReporteCierre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CierreDiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCierreDia;
        private System.Windows.Forms.BindingSource CierreDiaBindingSource;
        private DataSetReportes DataSetReportes;
        private DataSetReportesTableAdapters.CierreDiaTableAdapter CierreDiaTableAdapter;
    }
}