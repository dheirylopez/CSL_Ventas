namespace CSL_Ventas.Win
{
    partial class FormClientesFactura
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
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelBuscar.Location = new System.Drawing.Point(14, 14);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(51, 16);
            this.labelBuscar.TabIndex = 9;
            this.labelBuscar.Text = "Buscar:";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(71, 14);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(554, 20);
            this.textBoxBuscar.TabIndex = 10;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewCliente);
            this.panel2.Location = new System.Drawing.Point(12, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 318);
            this.panel2.TabIndex = 11;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCliente.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.Size = new System.Drawing.Size(785, 318);
            this.dataGridViewCliente.TabIndex = 0;
            this.dataGridViewCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(654, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // FormClientesFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.labelBuscar);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(825, 437);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(825, 437);
            this.MinimizeBox = false;
            this.Name = "FormClientesFactura";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Label label1;
    }
}