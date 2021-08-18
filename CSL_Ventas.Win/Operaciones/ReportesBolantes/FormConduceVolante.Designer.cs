namespace CSL_Ventas.Win.Operaciones.ReportesBolantes
{
    partial class FormConduceVolante
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewConduceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewConduceTableAdapter = new CSL_Ventas.Win.Operaciones.DataSetReportesTableAdapters.ViewConduceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConduceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetReportes
            // 
            this.dataSetReportes.DataSetName = "DataSetReportes";
            this.dataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetConduce";
            reportDataSource1.Value = this.viewConduceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CSL_Ventas.Win.Operaciones.ReportesBolantes.ReportVolanteConduce.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(612, 404);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewConduceBindingSource
            // 
            this.viewConduceBindingSource.DataMember = "ViewConduce";
            this.viewConduceBindingSource.DataSource = this.dataSetReportes;
            // 
            // viewConduceTableAdapter
            // 
            this.viewConduceTableAdapter.ClearBeforeFill = true;
            // 
            // FormConduceVolante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 404);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Name = "FormConduceVolante";
            this.Text = "Conduce";
            this.Load += new System.EventHandler(this.FormConduce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConduceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetReportes dataSetReportes;
        private System.Windows.Forms.BindingSource viewConduceBindingSource;
        private DataSetReportesTableAdapters.ViewConduceTableAdapter viewConduceTableAdapter;
    }
}