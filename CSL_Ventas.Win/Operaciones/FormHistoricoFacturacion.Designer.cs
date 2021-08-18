namespace CSL_Ventas.Win
{
    partial class FormHistoricoFacturacion
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonVentaEmpleado = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFactura = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefrescar = new System.Windows.Forms.ToolStripButton();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewHistoricoFactracion = new System.Windows.Forms.DataGridView();
            this.checkBoxProforma = new System.Windows.Forms.CheckBox();
            this.checkBoxCredito = new System.Windows.Forms.CheckBox();
            this.checkBoxContado = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricoFactracion)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAyuda,
            this.toolStripButtonVentaEmpleado,
            this.toolStripButtonFactura,
            this.toolStripButtonRefrescar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(761, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAyuda
            // 
            this.toolStripButtonAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAyuda.Image = global::CSL_Ventas.Win.Properties.Resources.about_16x16;
            this.toolStripButtonAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAyuda.Name = "toolStripButtonAyuda";
            this.toolStripButtonAyuda.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAyuda.Text = "Ayuda";
            this.toolStripButtonAyuda.Click += new System.EventHandler(this.toolStripButtonAyuda_Click);
            // 
            // toolStripButtonVentaEmpleado
            // 
            this.toolStripButtonVentaEmpleado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonVentaEmpleado.Image = global::CSL_Ventas.Win.Properties.Resources.chart_16x16;
            this.toolStripButtonVentaEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVentaEmpleado.Name = "toolStripButtonVentaEmpleado";
            this.toolStripButtonVentaEmpleado.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonVentaEmpleado.Text = "Reporte de Venta Por empleado";
            this.toolStripButtonVentaEmpleado.Click += new System.EventHandler(this.toolStripButtonVentaEmpleado_Click);
            // 
            // toolStripButtonFactura
            // 
            this.toolStripButtonFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFactura.Image = global::CSL_Ventas.Win.Properties.Resources.print_16x16;
            this.toolStripButtonFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFactura.Name = "toolStripButtonFactura";
            this.toolStripButtonFactura.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFactura.Text = "Imprimir una Factura";
            this.toolStripButtonFactura.Click += new System.EventHandler(this.toolStripButtonFactura_Click);
            // 
            // toolStripButtonRefrescar
            // 
            this.toolStripButtonRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefrescar.Image = global::CSL_Ventas.Win.Properties.Resources.convert_16x161;
            this.toolStripButtonRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefrescar.Name = "toolStripButtonRefrescar";
            this.toolStripButtonRefrescar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefrescar.Text = "Refrescar";
            this.toolStripButtonRefrescar.Click += new System.EventHandler(this.toolStripButtonRefrescar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(66, 42);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(459, 20);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(8, 44);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(51, 16);
            this.labelBuscar.TabIndex = 2;
            this.labelBuscar.Text = "Buscar:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewHistoricoFactracion);
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 218);
            this.panel1.TabIndex = 3;
            // 
            // dataGridViewHistoricoFactracion
            // 
            this.dataGridViewHistoricoFactracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoricoFactracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistoricoFactracion.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHistoricoFactracion.Name = "dataGridViewHistoricoFactracion";
            this.dataGridViewHistoricoFactracion.Size = new System.Drawing.Size(737, 218);
            this.dataGridViewHistoricoFactracion.TabIndex = 0;
            // 
            // checkBoxProforma
            // 
            this.checkBoxProforma.AutoSize = true;
            this.checkBoxProforma.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.checkBoxProforma.Location = new System.Drawing.Point(531, 44);
            this.checkBoxProforma.Name = "checkBoxProforma";
            this.checkBoxProforma.Size = new System.Drawing.Size(127, 20);
            this.checkBoxProforma.TabIndex = 4;
            this.checkBoxProforma.Text = "Factura Proforma";
            this.checkBoxProforma.UseVisualStyleBackColor = true;
            // 
            // checkBoxCredito
            // 
            this.checkBoxCredito.AutoSize = true;
            this.checkBoxCredito.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.checkBoxCredito.Location = new System.Drawing.Point(11, 91);
            this.checkBoxCredito.Name = "checkBoxCredito";
            this.checkBoxCredito.Size = new System.Drawing.Size(115, 20);
            this.checkBoxCredito.TabIndex = 5;
            this.checkBoxCredito.Text = "Factura Credito";
            this.checkBoxCredito.UseVisualStyleBackColor = true;
            this.checkBoxCredito.CheckedChanged += new System.EventHandler(this.checkBoxCredito_CheckedChanged);
            // 
            // checkBoxContado
            // 
            this.checkBoxContado.AutoSize = true;
            this.checkBoxContado.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.checkBoxContado.Location = new System.Drawing.Point(11, 68);
            this.checkBoxContado.Name = "checkBoxContado";
            this.checkBoxContado.Size = new System.Drawing.Size(121, 20);
            this.checkBoxContado.TabIndex = 6;
            this.checkBoxContado.Text = "Factura Contado";
            this.checkBoxContado.UseVisualStyleBackColor = true;
            this.checkBoxContado.CheckedChanged += new System.EventHandler(this.checkBoxContado_CheckedChanged);
            // 
            // FormHistoricoFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 349);
            this.Controls.Add(this.checkBoxContado);
            this.Controls.Add(this.checkBoxCredito);
            this.Controls.Add(this.checkBoxProforma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "FormHistoricoFacturacion";
            this.Text = "Historico Facturacion";
            this.Load += new System.EventHandler(this.FormHistoricoFacturacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricoFactracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewHistoricoFactracion;
        private System.Windows.Forms.ToolStripButton toolStripButtonAyuda;
        private System.Windows.Forms.ToolStripButton toolStripButtonVentaEmpleado;
        private System.Windows.Forms.ToolStripButton toolStripButtonFactura;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefrescar;
        private System.Windows.Forms.CheckBox checkBoxProforma;
        private System.Windows.Forms.CheckBox checkBoxCredito;
        private System.Windows.Forms.CheckBox checkBoxContado;
    }
}