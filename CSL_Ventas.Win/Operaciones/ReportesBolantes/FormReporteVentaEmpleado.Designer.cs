namespace CSL_Ventas.Win.Operaciones.ReportesBolantes
{
    partial class FormReporteVentaEmpleado
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
            this.textBoxEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelHasta = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.labelDesde = new System.Windows.Forms.Label();
            this.viewVentaEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_VentaEmpleadoTableAdapter = new CSL_Ventas.Win.Operaciones.DataSetReportesTableAdapters.View_VentaEmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewVentaEmpleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetReportes
            // 
            this.dataSetReportes.DataSetName = "DataSetReportes";
            this.dataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxEmpleado
            // 
            this.textBoxEmpleado.Location = new System.Drawing.Point(97, 7);
            this.textBoxEmpleado.Name = "textBoxEmpleado";
            this.textBoxEmpleado.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpleado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 381);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVentasEmpleado";
            reportDataSource1.Value = this.viewVentaEmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CSL_Ventas.Win.Operaciones.ReportesBolantes.ReportVentaEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(524, 362);
            this.reportViewer1.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = global::CSL_Ventas.Win.Properties.Resources.btnSearch_Image;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.Location = new System.Drawing.Point(203, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(65, 23);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasta.Location = new System.Drawing.Point(172, 37);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(45, 16);
            this.labelHasta.TabIndex = 10;
            this.labelHasta.Text = "Hasta:";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(223, 33);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(98, 23);
            this.dateTimePickerHasta.TabIndex = 9;
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(66, 32);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(100, 23);
            this.dateTimePickerDesde.TabIndex = 8;
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesde.Location = new System.Drawing.Point(12, 37);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(48, 16);
            this.labelDesde.TabIndex = 7;
            this.labelDesde.Text = "Desde:";
            // 
            // viewVentaEmpleadoBindingSource
            // 
            this.viewVentaEmpleadoBindingSource.DataMember = "View_VentaEmpleado";
            this.viewVentaEmpleadoBindingSource.DataSource = this.dataSetReportes;
            // 
            // view_VentaEmpleadoTableAdapter
            // 
            this.view_VentaEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteVentaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 449);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.labelDesde);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmpleado);
            this.DoubleBuffered = true;
            this.Name = "FormReporteVentaEmpleado";
            this.Text = "Reporte Venta Empleado";
            this.Load += new System.EventHandler(this.FormReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewVentaEmpleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.Label labelDesde;
        private DataSetReportes dataSetReportes;
        private System.Windows.Forms.BindingSource viewVentaEmpleadoBindingSource;
        private DataSetReportesTableAdapters.View_VentaEmpleadoTableAdapter view_VentaEmpleadoTableAdapter;
    }
}