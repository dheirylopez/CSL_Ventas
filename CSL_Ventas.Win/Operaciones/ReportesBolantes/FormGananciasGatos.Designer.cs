namespace CSL_Ventas.Win.Operaciones.ReportesBolantes
{
    partial class FormGananciasGatos
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelDesde = new System.Windows.Forms.Label();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.labelHasta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewerGanancias = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetReportes = new CSL_Ventas.Win.Operaciones.DataSetReportes();
            this.viewGananciasGastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Ganancias_GastosTableAdapter = new CSL_Ventas.Win.Operaciones.DataSetReportesTableAdapters.View_Ganancias_GastosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGananciasGastosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Image = global::CSL_Ventas.Win.Properties.Resources.btnSearch_Image;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.Location = new System.Drawing.Point(338, 12);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(26, 23);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesde.Location = new System.Drawing.Point(12, 19);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(48, 16);
            this.labelDesde.TabIndex = 1;
            this.labelDesde.Text = "Desde:";
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(66, 14);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(100, 23);
            this.dateTimePickerDesde.TabIndex = 3;
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(234, 14);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(98, 23);
            this.dateTimePickerHasta.TabIndex = 4;
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasta.Location = new System.Drawing.Point(172, 19);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(45, 16);
            this.labelHasta.TabIndex = 5;
            this.labelHasta.Text = "Hasta:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewerGanancias);
            this.panel1.Location = new System.Drawing.Point(-1, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 458);
            this.panel1.TabIndex = 6;
            // 
            // reportViewerGanancias
            // 
            this.reportViewerGanancias.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetGanacias";
            reportDataSource1.Value = this.viewGananciasGastosBindingSource;
            this.reportViewerGanancias.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerGanancias.LocalReport.ReportEmbeddedResource = "CSL_Ventas.Win.Operaciones.ReportesBolantes.ReportGananciasGastos.rdlc";
            this.reportViewerGanancias.Location = new System.Drawing.Point(0, 0);
            this.reportViewerGanancias.Name = "reportViewerGanancias";
            this.reportViewerGanancias.Size = new System.Drawing.Size(855, 458);
            this.reportViewerGanancias.TabIndex = 0;
            // 
            // dataSetReportes
            // 
            this.dataSetReportes.DataSetName = "DataSetReportes";
            this.dataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewGananciasGastosBindingSource
            // 
            this.viewGananciasGastosBindingSource.DataMember = "View_Ganancias_Gastos";
            this.viewGananciasGastosBindingSource.DataSource = this.dataSetReportes;
            // 
            // view_Ganancias_GastosTableAdapter
            // 
            this.view_Ganancias_GastosTableAdapter.ClearBeforeFill = true;
            // 
            // FormGananciasGatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.labelDesde);
            this.Controls.Add(this.buttonBuscar);
            this.DoubleBuffered = true;
            this.Name = "FormGananciasGatos";
            this.Text = "Ganancias Gatos";
            this.Load += new System.EventHandler(this.FormGananciasGatos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGananciasGastosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGanancias;
        private System.Windows.Forms.BindingSource viewGananciasGastosBindingSource;
        private DataSetReportes dataSetReportes;
        private DataSetReportesTableAdapters.View_Ganancias_GastosTableAdapter view_Ganancias_GastosTableAdapter;
    }
}