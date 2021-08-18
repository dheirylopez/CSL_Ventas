namespace CSL_Ventas.Win.Operaciones
{
    partial class FormHistoricoCotizacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewHistoricoCotizacion = new System.Windows.Forms.DataGridView();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonImsprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefrescar = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricoCotizacion)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewHistoricoCotizacion);
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 242);
            this.panel1.TabIndex = 7;
            // 
            // dataGridViewHistoricoCotizacion
            // 
            this.dataGridViewHistoricoCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoricoCotizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistoricoCotizacion.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHistoricoCotizacion.Name = "dataGridViewHistoricoCotizacion";
            this.dataGridViewHistoricoCotizacion.Size = new System.Drawing.Size(733, 242);
            this.dataGridViewHistoricoCotizacion.TabIndex = 0;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(28, 41);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(51, 16);
            this.labelBuscar.TabIndex = 6;
            this.labelBuscar.Text = "Buscar:";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(86, 39);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(629, 20);
            this.textBoxBuscar.TabIndex = 5;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonImsprimir,
            this.toolStripButtonAyuda,
            this.toolStripButtonRefrescar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonImsprimir
            // 
            this.toolStripButtonImsprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImsprimir.Image = global::CSL_Ventas.Win.Properties.Resources.print_16x16;
            this.toolStripButtonImsprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImsprimir.Name = "toolStripButtonImsprimir";
            this.toolStripButtonImsprimir.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonImsprimir.Text = "Imsprimir";
            this.toolStripButtonImsprimir.Click += new System.EventHandler(this.toolStripButtonImsprimir_Click);
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
            // FormHistoricoCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 339);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "FormHistoricoCotizacion";
            this.Text = "Historico Cotizacion";
            this.Load += new System.EventHandler(this.FormHistoricoCotizacion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricoCotizacion)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewHistoricoCotizacion;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonImsprimir;
        private System.Windows.Forms.ToolStripButton toolStripButtonAyuda;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefrescar;
    }
}