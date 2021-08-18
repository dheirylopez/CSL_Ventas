namespace CSL_Ventas.Win.Operaciones
{
    partial class FormCotizacion
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
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxDescuento = new System.Windows.Forms.TextBox();
            this.textBoxItebis = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.labelItebis = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.labelObservacion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewCotizacion = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonQuitar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonImpimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxArticulo = new System.Windows.Forms.TextBox();
            this.labelCantidadAlmacen = new System.Windows.Forms.Label();
            this.checkBoxEstatusItebis = new System.Windows.Forms.CheckBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxColaborador = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelArticulo = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelColaborador = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCotizacion)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(720, 357);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 24;
            // 
            // textBoxDescuento
            // 
            this.textBoxDescuento.Location = new System.Drawing.Point(720, 325);
            this.textBoxDescuento.Name = "textBoxDescuento";
            this.textBoxDescuento.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescuento.TabIndex = 23;
            this.textBoxDescuento.TextChanged += new System.EventHandler(this.textBoxDescuento_TextChanged);
            // 
            // textBoxItebis
            // 
            this.textBoxItebis.Location = new System.Drawing.Point(521, 357);
            this.textBoxItebis.Name = "textBoxItebis";
            this.textBoxItebis.Size = new System.Drawing.Size(100, 20);
            this.textBoxItebis.TabIndex = 22;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(521, 326);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubTotal.TabIndex = 21;
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.Location = new System.Drawing.Point(85, 329);
            this.textBoxObservacion.Multiline = true;
            this.textBoxObservacion.Name = "textBoxObservacion";
            this.textBoxObservacion.Size = new System.Drawing.Size(337, 49);
            this.textBoxObservacion.TabIndex = 20;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelTotal.Location = new System.Drawing.Point(672, 358);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(42, 16);
            this.labelTotal.TabIndex = 19;
            this.labelTotal.Text = "Total:";
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelDescuento.Location = new System.Drawing.Point(642, 329);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(72, 16);
            this.labelDescuento.TabIndex = 18;
            this.labelDescuento.Text = "Descuento:";
            // 
            // labelItebis
            // 
            this.labelItebis.AutoSize = true;
            this.labelItebis.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelItebis.Location = new System.Drawing.Point(473, 359);
            this.labelItebis.Name = "labelItebis";
            this.labelItebis.Size = new System.Drawing.Size(44, 16);
            this.labelItebis.TabIndex = 17;
            this.labelItebis.Text = "Itebis:";
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelSubTotal.Location = new System.Drawing.Point(448, 329);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(69, 16);
            this.labelSubTotal.TabIndex = 16;
            this.labelSubTotal.Text = "Sub-Total:";
            // 
            // labelObservacion
            // 
            this.labelObservacion.AutoSize = true;
            this.labelObservacion.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelObservacion.Location = new System.Drawing.Point(-1, 330);
            this.labelObservacion.Name = "labelObservacion";
            this.labelObservacion.Size = new System.Drawing.Size(83, 16);
            this.labelObservacion.TabIndex = 15;
            this.labelObservacion.Text = "Observacion:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewCotizacion);
            this.panel2.Location = new System.Drawing.Point(1, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 182);
            this.panel2.TabIndex = 14;
            // 
            // dataGridViewCotizacion
            // 
            this.dataGridViewCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCotizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCotizacion.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCotizacion.Name = "dataGridViewCotizacion";
            this.dataGridViewCotizacion.Size = new System.Drawing.Size(822, 182);
            this.dataGridViewCotizacion.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAgregar,
            this.toolStripButtonQuitar,
            this.toolStripButtonLimpiar,
            this.toolStripButtonImpimir,
            this.toolStripButtonAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(835, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAgregar
            // 
            this.toolStripButtonAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAgregar.Image = global::CSL_Ventas.Win.Properties.Resources.additem_16x16;
            this.toolStripButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregar.Name = "toolStripButtonAgregar";
            this.toolStripButtonAgregar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAgregar.Text = "Agregar";
            this.toolStripButtonAgregar.Click += new System.EventHandler(this.toolStripButtonAgregar_Click);
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
            // toolStripButtonImpimir
            // 
            this.toolStripButtonImpimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImpimir.Image = global::CSL_Ventas.Win.Properties.Resources.print_16x16;
            this.toolStripButtonImpimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImpimir.Name = "toolStripButtonImpimir";
            this.toolStripButtonImpimir.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonImpimir.Text = "Imsprimir";
            this.toolStripButtonImpimir.Click += new System.EventHandler(this.toolStripButtonImpimir_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxCliente);
            this.panel1.Controls.Add(this.buttonCliente);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxArticulo);
            this.panel1.Controls.Add(this.labelCantidadAlmacen);
            this.panel1.Controls.Add(this.checkBoxEstatusItebis);
            this.panel1.Controls.Add(this.textBoxPrecio);
            this.panel1.Controls.Add(this.textBoxCantidad);
            this.panel1.Controls.Add(this.textBoxColaborador);
            this.panel1.Controls.Add(this.labelPrecio);
            this.panel1.Controls.Add(this.labelCantidad);
            this.panel1.Controls.Add(this.labelArticulo);
            this.panel1.Controls.Add(this.labelCliente);
            this.panel1.Controls.Add(this.labelColaborador);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 86);
            this.panel1.TabIndex = 13;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(70, 49);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(239, 23);
            this.textBoxCliente.TabIndex = 24;
            // 
            // buttonCliente
            // 
            this.buttonCliente.Image = global::CSL_Ventas.Win.Properties.Resources.Team_32x32;
            this.buttonCliente.Location = new System.Drawing.Point(315, 44);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(75, 36);
            this.buttonCliente.TabIndex = 23;
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // button1
            // 
            this.button1.Image = global::CSL_Ventas.Win.Properties.Resources.ConvertToParagraphs_32x32;
            this.button1.Location = new System.Drawing.Point(430, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxArticulo
            // 
            this.textBoxArticulo.Location = new System.Drawing.Point(282, 12);
            this.textBoxArticulo.Name = "textBoxArticulo";
            this.textBoxArticulo.ReadOnly = true;
            this.textBoxArticulo.Size = new System.Drawing.Size(139, 23);
            this.textBoxArticulo.TabIndex = 17;
            // 
            // labelCantidadAlmacen
            // 
            this.labelCantidadAlmacen.AutoSize = true;
            this.labelCantidadAlmacen.Location = new System.Drawing.Point(651, 22);
            this.labelCantidadAlmacen.Name = "labelCantidadAlmacen";
            this.labelCantidadAlmacen.Size = new System.Drawing.Size(134, 16);
            this.labelCantidadAlmacen.TabIndex = 16;
            this.labelCantidadAlmacen.Text = "Cantidad en Almacen:";
            // 
            // checkBoxEstatusItebis
            // 
            this.checkBoxEstatusItebis.AutoSize = true;
            this.checkBoxEstatusItebis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEstatusItebis.Location = new System.Drawing.Point(624, 53);
            this.checkBoxEstatusItebis.Name = "checkBoxEstatusItebis";
            this.checkBoxEstatusItebis.Size = new System.Drawing.Size(116, 20);
            this.checkBoxEstatusItebis.TabIndex = 12;
            this.checkBoxEstatusItebis.Text = "Status de Itebis";
            this.checkBoxEstatusItebis.UseVisualStyleBackColor = true;
            this.checkBoxEstatusItebis.CheckedChanged += new System.EventHandler(this.checkBoxEstatusItebis_CheckedChanged);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(571, 16);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(76, 23);
            this.textBoxPrecio.TabIndex = 10;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBoxPrecio_TextChanged);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(488, 49);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 23);
            this.textBoxCantidad.TabIndex = 9;
            // 
            // textBoxColaborador
            // 
            this.textBoxColaborador.Location = new System.Drawing.Point(98, 15);
            this.textBoxColaborador.Name = "textBoxColaborador";
            this.textBoxColaborador.ReadOnly = true;
            this.textBoxColaborador.Size = new System.Drawing.Size(99, 23);
            this.textBoxColaborador.TabIndex = 7;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(517, 19);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(48, 16);
            this.labelPrecio.TabIndex = 5;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(410, 52);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(63, 16);
            this.labelCantidad.TabIndex = 4;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // labelArticulo
            // 
            this.labelArticulo.AutoSize = true;
            this.labelArticulo.Location = new System.Drawing.Point(214, 16);
            this.labelArticulo.Name = "labelArticulo";
            this.labelArticulo.Size = new System.Drawing.Size(56, 16);
            this.labelArticulo.TabIndex = 3;
            this.labelArticulo.Text = "Articulo:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(9, 53);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(52, 16);
            this.labelCliente.TabIndex = 2;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelColaborador
            // 
            this.labelColaborador.AutoSize = true;
            this.labelColaborador.Location = new System.Drawing.Point(6, 15);
            this.labelColaborador.Name = "labelColaborador";
            this.labelColaborador.Size = new System.Drawing.Size(83, 16);
            this.labelColaborador.TabIndex = 1;
            this.labelColaborador.Text = "Colaborador:";
            // 
            // FormCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 382);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxDescuento);
            this.Controls.Add(this.textBoxItebis);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.textBoxObservacion);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDescuento);
            this.Controls.Add(this.labelItebis);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.labelObservacion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormCotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.FormCotizacion_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCotizacion)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxDescuento;
        private System.Windows.Forms.TextBox textBoxItebis;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.TextBox textBoxObservacion;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.Label labelItebis;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label labelObservacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewCotizacion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregar;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuitar;
        private System.Windows.Forms.ToolStripButton toolStripButtonLimpiar;
        private System.Windows.Forms.ToolStripButton toolStripButtonImpimir;
        private System.Windows.Forms.ToolStripButton toolStripButtonAyuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxColaborador;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelArticulo;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelColaborador;
        private System.Windows.Forms.CheckBox checkBoxEstatusItebis;
        private System.Windows.Forms.Label labelCantidadAlmacen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxArticulo;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.TextBox textBoxCliente;
    }
}