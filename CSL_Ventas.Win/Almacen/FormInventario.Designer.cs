namespace CSL_Ventas.Win.Almacen
{
    partial class FormInventario
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewInventario = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReporte = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefrescar = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(83, 39);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(539, 20);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewInventario);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 310);
            this.panel1.TabIndex = 2;
            // 
            // dataGridViewInventario
            // 
            this.dataGridViewInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventario.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInventario.Name = "dataGridViewInventario";
            this.dataGridViewInventario.Size = new System.Drawing.Size(626, 310);
            this.dataGridViewInventario.TabIndex = 0;
            this.dataGridViewInventario.DoubleClick += new System.EventHandler(this.dataGridViewInventario_DoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAyuda,
            this.toolStripButtonReporte,
            this.toolStripButtonRefrescar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(650, 25);
            this.toolStrip1.TabIndex = 9;
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
            // toolStripButtonReporte
            // 
            this.toolStripButtonReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReporte.Image = global::CSL_Ventas.Win.Properties.Resources.chart_16x16;
            this.toolStripButtonReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReporte.Name = "toolStripButtonReporte";
            this.toolStripButtonReporte.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReporte.Text = "Reporte";
            this.toolStripButtonReporte.Click += new System.EventHandler(this.toolStripButtonReporte_Click);
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
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 398);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewInventario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAyuda;
        private System.Windows.Forms.ToolStripButton toolStripButtonReporte;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefrescar;
    }
}