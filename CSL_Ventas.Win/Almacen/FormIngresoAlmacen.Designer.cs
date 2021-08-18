namespace CSL_Ventas.Win.Almacen
{
    partial class FormIngresoAlmacen
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
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefrescar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxColaborador = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxPrecioCompra = new System.Windows.Forms.TextBox();
            this.comboBoxProbeedor = new System.Windows.Forms.ComboBox();
            this.textBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxArticulo = new System.Windows.Forms.TextBox();
            this.buttonArticulo = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAgregar,
            this.toolStripButton1,
            this.toolStripButtonRefrescar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(824, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAgregar
            // 
            this.toolStripButtonAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAgregar.Image = global::CSL_Ventas.Win.Properties.Resources.Save_16x16;
            this.toolStripButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregar.Name = "toolStripButtonAgregar";
            this.toolStripButtonAgregar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAgregar.Text = "Guardar";
            this.toolStripButtonAgregar.Click += new System.EventHandler(this.toolStripButtonAgregar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::CSL_Ventas.Win.Properties.Resources.about_16x16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.ToolTipText = "Ayuda";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonRefrescar
            // 
            this.toolStripButtonRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefrescar.Image = global::CSL_Ventas.Win.Properties.Resources.convert_16x16;
            this.toolStripButtonRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefrescar.Name = "toolStripButtonRefrescar";
            this.toolStripButtonRefrescar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefrescar.Text = "Refrescar";
            this.toolStripButtonRefrescar.Click += new System.EventHandler(this.toolStripButtonRefrescar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Colaborador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Probeedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Articulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Canitdad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(614, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Precio Compra:";
            // 
            // textBoxColaborador
            // 
            this.textBoxColaborador.Location = new System.Drawing.Point(92, 50);
            this.textBoxColaborador.Name = "textBoxColaborador";
            this.textBoxColaborador.ReadOnly = true;
            this.textBoxColaborador.Size = new System.Drawing.Size(121, 20);
            this.textBoxColaborador.TabIndex = 17;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(280, 83);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(121, 20);
            this.textBoxCantidad.TabIndex = 19;
            // 
            // textBoxPrecioCompra
            // 
            this.textBoxPrecioCompra.Location = new System.Drawing.Point(719, 83);
            this.textBoxPrecioCompra.Name = "textBoxPrecioCompra";
            this.textBoxPrecioCompra.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioCompra.TabIndex = 20;
            // 
            // comboBoxProbeedor
            // 
            this.comboBoxProbeedor.FormattingEnabled = true;
            this.comboBoxProbeedor.Location = new System.Drawing.Point(92, 79);
            this.comboBoxProbeedor.Name = "comboBoxProbeedor";
            this.comboBoxProbeedor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProbeedor.TabIndex = 22;
            // 
            // textBoxPrecioVenta
            // 
            this.textBoxPrecioVenta.Location = new System.Drawing.Point(508, 83);
            this.textBoxPrecioVenta.Name = "textBoxPrecioVenta";
            this.textBoxPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioVenta.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Precio Venta:";
            // 
            // textBoxArticulo
            // 
            this.textBoxArticulo.Enabled = false;
            this.textBoxArticulo.Location = new System.Drawing.Point(280, 46);
            this.textBoxArticulo.Name = "textBoxArticulo";
            this.textBoxArticulo.Size = new System.Drawing.Size(328, 20);
            this.textBoxArticulo.TabIndex = 25;
            // 
            // buttonArticulo
            // 
            this.buttonArticulo.Image = global::CSL_Ventas.Win.Properties.Resources.ConvertToParagraphs_32x32;
            this.buttonArticulo.Location = new System.Drawing.Point(626, 33);
            this.buttonArticulo.Name = "buttonArticulo";
            this.buttonArticulo.Size = new System.Drawing.Size(66, 42);
            this.buttonArticulo.TabIndex = 26;
            this.buttonArticulo.UseVisualStyleBackColor = true;
            this.buttonArticulo.Click += new System.EventHandler(this.buttonArticulo_Click);
            // 
            // FormIngresoAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 132);
            this.Controls.Add(this.buttonArticulo);
            this.Controls.Add(this.textBoxArticulo);
            this.Controls.Add(this.textBoxPrecioVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxProbeedor);
            this.Controls.Add(this.textBoxPrecioCompra);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxColaborador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 171);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(840, 171);
            this.Name = "FormIngresoAlmacen";
            this.Text = "Ingreso Almacen";
            this.Load += new System.EventHandler(this.FormIngresoAlmacen_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxColaborador;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxPrecioCompra;
        private System.Windows.Forms.ComboBox comboBoxProbeedor;
        private System.Windows.Forms.TextBox textBoxPrecioVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefrescar;
        private System.Windows.Forms.TextBox textBoxArticulo;
        private System.Windows.Forms.Button buttonArticulo;
    }
}