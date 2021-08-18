namespace CSL_Ventas.Win.Almacen
{
    partial class FormSeleccionArticulos
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
            this.dataGridViewSeleccion = new System.Windows.Forms.DataGridView();
            this.buttonBuscarArticulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArticulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonQuitar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccion)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSeleccion
            // 
            this.dataGridViewSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeleccion.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewSeleccion.Name = "dataGridViewSeleccion";
            this.dataGridViewSeleccion.Size = new System.Drawing.Size(343, 182);
            this.dataGridViewSeleccion.TabIndex = 0;
            // 
            // buttonBuscarArticulo
            // 
            this.buttonBuscarArticulo.BackgroundImage = global::CSL_Ventas.Win.Properties.Resources.addfooter_32x32;
            this.buttonBuscarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBuscarArticulo.Location = new System.Drawing.Point(274, 33);
            this.buttonBuscarArticulo.Name = "buttonBuscarArticulo";
            this.buttonBuscarArticulo.Size = new System.Drawing.Size(45, 50);
            this.buttonBuscarArticulo.TabIndex = 1;
            this.buttonBuscarArticulo.UseVisualStyleBackColor = true;
            this.buttonBuscarArticulo.Click += new System.EventHandler(this.buttonBuscarArticulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Articulo:";
            // 
            // textBoxArticulo
            // 
            this.textBoxArticulo.Location = new System.Drawing.Point(83, 33);
            this.textBoxArticulo.Name = "textBoxArticulo";
            this.textBoxArticulo.ReadOnly = true;
            this.textBoxArticulo.Size = new System.Drawing.Size(185, 20);
            this.textBoxArticulo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad:";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(83, 65);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(62, 20);
            this.textBoxCantidad.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAgregar,
            this.toolStripButtonQuitar,
            this.toolStripButtonGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(367, 25);
            this.toolStrip1.TabIndex = 6;
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
            // toolStripButtonGuardar
            // 
            this.toolStripButtonGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGuardar.Image = global::CSL_Ventas.Win.Properties.Resources.edittask_16x16;
            this.toolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuardar.Name = "toolStripButtonGuardar";
            this.toolStripButtonGuardar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGuardar.Text = "Fin de Seleccion";
            this.toolStripButtonGuardar.Click += new System.EventHandler(this.toolStripButtonGuardar_Click);
            // 
            // FormSeleccionArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 300);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscarArticulo);
            this.Controls.Add(this.dataGridViewSeleccion);
            this.DoubleBuffered = true;
            this.Name = "FormSeleccionArticulos";
            this.Text = "Seleccion Articulos";
            this.Load += new System.EventHandler(this.FormSeleccionArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccion)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSeleccion;
        private System.Windows.Forms.Button buttonBuscarArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregar;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuitar;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
    }
}