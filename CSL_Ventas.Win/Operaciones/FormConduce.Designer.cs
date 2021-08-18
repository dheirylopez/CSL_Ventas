namespace CSL_Ventas.Win
{
    partial class FormConduce
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
            this.toolStripButtonQuitar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBuscarCotizacion = new System.Windows.Forms.Button();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxIDFactura = new System.Windows.Forms.TextBox();
            this.textBoxColaborador = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelColaborador = new System.Windows.Forms.Label();
            this.labelCotizacion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewConduce = new System.Windows.Forms.DataGridView();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.labelObservacion = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConduce)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonQuitar,
            this.toolStripButtonLimpiar,
            this.toolStripButtonImprimir,
            this.toolStripButtonAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonQuitar
            // 
            this.toolStripButtonQuitar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonQuitar.Image = global::CSL_Ventas.Win.Properties.Resources.deletelist_16x162;
            this.toolStripButtonQuitar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuitar.Name = "toolStripButtonQuitar";
            this.toolStripButtonQuitar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonQuitar.Text = "Quitar";
            this.toolStripButtonQuitar.Click += new System.EventHandler(this.toolStripButtonQuitar_Click);
            // 
            // toolStripButtonLimpiar
            // 
            this.toolStripButtonLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLimpiar.Image = global::CSL_Ventas.Win.Properties.Resources.clear_16x16;
            this.toolStripButtonLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLimpiar.Name = "toolStripButtonLimpiar";
            this.toolStripButtonLimpiar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLimpiar.Text = "Limpiar";
            this.toolStripButtonLimpiar.Click += new System.EventHandler(this.toolStripButtonLimpiar_Click);
            // 
            // toolStripButtonImprimir
            // 
            this.toolStripButtonImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImprimir.Image = global::CSL_Ventas.Win.Properties.Resources.print_16x16;
            this.toolStripButtonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImprimir.Name = "toolStripButtonImprimir";
            this.toolStripButtonImprimir.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonImprimir.Text = "Imsprimir";
            this.toolStripButtonImprimir.Click += new System.EventHandler(this.toolStripButtonImprimir_Click);
            // 
            // toolStripButtonAyuda
            // 
            this.toolStripButtonAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAyuda.Image = global::CSL_Ventas.Win.Properties.Resources.about_16x161;
            this.toolStripButtonAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAyuda.Name = "toolStripButtonAyuda";
            this.toolStripButtonAyuda.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAyuda.Text = "Ayuda";
            this.toolStripButtonAyuda.Click += new System.EventHandler(this.toolStripButtonAyuda_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBuscarCotizacion);
            this.panel1.Controls.Add(this.textBoxCliente);
            this.panel1.Controls.Add(this.textBoxIDFactura);
            this.panel1.Controls.Add(this.textBoxColaborador);
            this.panel1.Controls.Add(this.labelCliente);
            this.panel1.Controls.Add(this.labelColaborador);
            this.panel1.Controls.Add(this.labelCotizacion);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 47);
            this.panel1.TabIndex = 2;
            // 
            // buttonBuscarCotizacion
            // 
            this.buttonBuscarCotizacion.Image = global::CSL_Ventas.Win.Properties.Resources.btnSearch_Image;
            this.buttonBuscarCotizacion.Location = new System.Drawing.Point(199, 11);
            this.buttonBuscarCotizacion.Name = "buttonBuscarCotizacion";
            this.buttonBuscarCotizacion.Size = new System.Drawing.Size(24, 22);
            this.buttonBuscarCotizacion.TabIndex = 12;
            this.buttonBuscarCotizacion.UseVisualStyleBackColor = true;
            this.buttonBuscarCotizacion.Click += new System.EventHandler(this.buttonBuscarCotizacion_Click);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(481, 10);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(135, 23);
            this.textBoxCliente.TabIndex = 10;
            // 
            // textBoxIDFactura
            // 
            this.textBoxIDFactura.Location = new System.Drawing.Point(101, 11);
            this.textBoxIDFactura.Name = "textBoxIDFactura";
            this.textBoxIDFactura.Size = new System.Drawing.Size(92, 23);
            this.textBoxIDFactura.TabIndex = 8;
            // 
            // textBoxColaborador
            // 
            this.textBoxColaborador.Location = new System.Drawing.Point(320, 10);
            this.textBoxColaborador.Name = "textBoxColaborador";
            this.textBoxColaborador.ReadOnly = true;
            this.textBoxColaborador.Size = new System.Drawing.Size(92, 23);
            this.textBoxColaborador.TabIndex = 7;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(423, 14);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(52, 16);
            this.labelCliente.TabIndex = 2;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelColaborador
            // 
            this.labelColaborador.AutoSize = true;
            this.labelColaborador.Location = new System.Drawing.Point(229, 14);
            this.labelColaborador.Name = "labelColaborador";
            this.labelColaborador.Size = new System.Drawing.Size(83, 16);
            this.labelColaborador.TabIndex = 1;
            this.labelColaborador.Text = "Colaborador:";
            // 
            // labelCotizacion
            // 
            this.labelCotizacion.AutoSize = true;
            this.labelCotizacion.Location = new System.Drawing.Point(22, 14);
            this.labelCotizacion.Name = "labelCotizacion";
            this.labelCotizacion.Size = new System.Drawing.Size(56, 16);
            this.labelCotizacion.TabIndex = 0;
            this.labelCotizacion.Text = "Factura:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewConduce);
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 182);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewConduce
            // 
            this.dataGridViewConduce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConduce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewConduce.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewConduce.Name = "dataGridViewConduce";
            this.dataGridViewConduce.Size = new System.Drawing.Size(799, 182);
            this.dataGridViewConduce.TabIndex = 0;
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.Location = new System.Drawing.Point(98, 274);
            this.textBoxObservacion.Multiline = true;
            this.textBoxObservacion.Name = "textBoxObservacion";
            this.textBoxObservacion.Size = new System.Drawing.Size(713, 49);
            this.textBoxObservacion.TabIndex = 9;
            // 
            // labelObservacion
            // 
            this.labelObservacion.AutoSize = true;
            this.labelObservacion.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelObservacion.Location = new System.Drawing.Point(12, 275);
            this.labelObservacion.Name = "labelObservacion";
            this.labelObservacion.Size = new System.Drawing.Size(83, 16);
            this.labelObservacion.TabIndex = 8;
            this.labelObservacion.Text = "Observacion:";
            // 
            // FormConduce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 336);
            this.Controls.Add(this.textBoxObservacion);
            this.Controls.Add(this.labelObservacion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "FormConduce";
            this.Text = "Conduce";
            this.Load += new System.EventHandler(this.FormConduce_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConduce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuitar;
        private System.Windows.Forms.ToolStripButton toolStripButtonLimpiar;
        private System.Windows.Forms.ToolStripButton toolStripButtonImprimir;
        private System.Windows.Forms.ToolStripButton toolStripButtonAyuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBuscarCotizacion;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxIDFactura;
        private System.Windows.Forms.TextBox textBoxColaborador;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelColaborador;
        private System.Windows.Forms.Label labelCotizacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewConduce;
        private System.Windows.Forms.TextBox textBoxObservacion;
        private System.Windows.Forms.Label labelObservacion;
    }
}