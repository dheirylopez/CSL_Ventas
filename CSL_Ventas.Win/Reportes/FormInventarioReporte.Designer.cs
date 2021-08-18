namespace CSL_Ventas.Win.Reportes
{
    partial class FormInventarioReporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReportes = new CSL_Ventas.Win.Operaciones.DataSetReportes();
            this.view_InventarioTableAdapter = new CSL_Ventas.Win.Operaciones.DataSetReportesTableAdapters.View_InventarioTableAdapter();
            this.viewFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
            this.reportViewerInventario = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.viewInventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFacturaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewInventarioBindingSource
            // 
            this.viewInventarioBindingSource.DataMember = "View_Inventario";
            this.viewInventarioBindingSource.DataSource = this.dataSetReportes;
            // 
            // dataSetReportes
            // 
            this.dataSetReportes.DataSetName = "DataSetReportes";
            this.dataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_InventarioTableAdapter
            // 
            this.view_InventarioTableAdapter.ClearBeforeFill = true;
            // 
            // viewFacturaBindingSource
            // 
            this.viewFacturaBindingSource.DataMember = "View_Factura";
            this.viewFacturaBindingSource.DataSource = this.dataSetReportes;
            // 
            // view_FacturaTableAdapter
            // 
     
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewerInventario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 372);
            this.panel1.TabIndex = 1;
            // 
            // reportViewerInventario
            // 
            this.reportViewerInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFactura";
            reportDataSource1.Value = this.viewFacturaBindingSource;
            reportDataSource2.Name = "DataSetInventario";
            reportDataSource2.Value = this.viewInventarioBindingSource;
            this.reportViewerInventario.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerInventario.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerInventario.LocalReport.ReportEmbeddedResource = "CSL_Ventas.Win.Reportes.ReportInventario.rdlc";
            this.reportViewerInventario.Location = new System.Drawing.Point(0, 0);
            this.reportViewerInventario.Name = "reportViewerInventario";
            this.reportViewerInventario.Size = new System.Drawing.Size(589, 372);
            this.reportViewerInventario.TabIndex = 1;
            // 
            // FormInventarioReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 372);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormInventarioReporte";
            this.Text = "Inventario Reporte";
            this.Load += new System.EventHandler(this.FormInventarioReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewInventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFacturaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Operaciones.DataSetReportes dataSetReportes;
        private System.Windows.Forms.BindingSource viewInventarioBindingSource;
        private Operaciones.DataSetReportesTableAdapters.View_InventarioTableAdapter view_InventarioTableAdapter;
        private System.Windows.Forms.BindingSource viewFacturaBindingSource;
   
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerInventario;
    }
}