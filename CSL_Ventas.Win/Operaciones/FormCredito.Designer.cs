namespace CSL_Ventas.Win.Operaciones
{
    partial class FormCredito
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonPagar = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelMontoPendiente = new System.Windows.Forms.Label();
            this.labelMontoInicial = new System.Windows.Forms.Label();
            this.labelTotalFactura = new System.Windows.Forms.Label();
            this.labelPago = new System.Windows.Forms.Label();
            this.textBoxIdFactura = new System.Windows.Forms.TextBox();
            this.textBoxMontoPendiente = new System.Windows.Forms.TextBox();
            this.textBoxMontoInicial = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxPago = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = global::CSL_Ventas.Win.Properties.Resources.btnSearch_Image;
            this.buttonBuscar.Location = new System.Drawing.Point(163, 12);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(29, 23);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonPagar
            // 
            this.buttonPagar.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.buttonPagar.Image = global::CSL_Ventas.Win.Properties.Resources.Check_16;
            this.buttonPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPagar.Location = new System.Drawing.Point(248, 125);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(75, 33);
            this.buttonPagar.TabIndex = 1;
            this.buttonPagar.Text = "Pagar";
            this.buttonPagar.UseVisualStyleBackColor = true;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelId.Location = new System.Drawing.Point(85, 15);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(24, 16);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Id:";
            // 
            // labelMontoPendiente
            // 
            this.labelMontoPendiente.AutoSize = true;
            this.labelMontoPendiente.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelMontoPendiente.Location = new System.Drawing.Point(1, 47);
            this.labelMontoPendiente.Name = "labelMontoPendiente";
            this.labelMontoPendiente.Size = new System.Drawing.Size(108, 16);
            this.labelMontoPendiente.TabIndex = 3;
            this.labelMontoPendiente.Text = "Monto Pendiente:";
            // 
            // labelMontoInicial
            // 
            this.labelMontoInicial.AutoSize = true;
            this.labelMontoInicial.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelMontoInicial.Location = new System.Drawing.Point(24, 76);
            this.labelMontoInicial.Name = "labelMontoInicial";
            this.labelMontoInicial.Size = new System.Drawing.Size(85, 16);
            this.labelMontoInicial.TabIndex = 4;
            this.labelMontoInicial.Text = "Monto Inicial:";
            // 
            // labelTotalFactura
            // 
            this.labelTotalFactura.AutoSize = true;
            this.labelTotalFactura.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelTotalFactura.Location = new System.Drawing.Point(20, 102);
            this.labelTotalFactura.Name = "labelTotalFactura";
            this.labelTotalFactura.Size = new System.Drawing.Size(89, 16);
            this.labelTotalFactura.TabIndex = 5;
            this.labelTotalFactura.Text = "Total Factura:";
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelPago.Location = new System.Drawing.Point(68, 130);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(41, 16);
            this.labelPago.TabIndex = 6;
            this.labelPago.Text = "Pago:";
            // 
            // textBoxIdFactura
            // 
            this.textBoxIdFactura.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxIdFactura.Location = new System.Drawing.Point(115, 12);
            this.textBoxIdFactura.Name = "textBoxIdFactura";
            this.textBoxIdFactura.Size = new System.Drawing.Size(42, 23);
            this.textBoxIdFactura.TabIndex = 7;
            // 
            // textBoxMontoPendiente
            // 
            this.textBoxMontoPendiente.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxMontoPendiente.Location = new System.Drawing.Point(115, 44);
            this.textBoxMontoPendiente.Name = "textBoxMontoPendiente";
            this.textBoxMontoPendiente.ReadOnly = true;
            this.textBoxMontoPendiente.Size = new System.Drawing.Size(100, 23);
            this.textBoxMontoPendiente.TabIndex = 8;
            // 
            // textBoxMontoInicial
            // 
            this.textBoxMontoInicial.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxMontoInicial.Location = new System.Drawing.Point(115, 70);
            this.textBoxMontoInicial.Name = "textBoxMontoInicial";
            this.textBoxMontoInicial.ReadOnly = true;
            this.textBoxMontoInicial.Size = new System.Drawing.Size(100, 23);
            this.textBoxMontoInicial.TabIndex = 9;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxTotal.Location = new System.Drawing.Point(115, 99);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotal.TabIndex = 10;
            // 
            // textBoxPago
            // 
            this.textBoxPago.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxPago.Location = new System.Drawing.Point(115, 125);
            this.textBoxPago.Name = "textBoxPago";
            this.textBoxPago.Size = new System.Drawing.Size(100, 23);
            this.textBoxPago.TabIndex = 11;
            // 
            // FormCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 167);
            this.Controls.Add(this.textBoxPago);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxMontoInicial);
            this.Controls.Add(this.textBoxMontoPendiente);
            this.Controls.Add(this.textBoxIdFactura);
            this.Controls.Add(this.labelPago);
            this.Controls.Add(this.labelTotalFactura);
            this.Controls.Add(this.labelMontoInicial);
            this.Controls.Add(this.labelMontoPendiente);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonPagar);
            this.Controls.Add(this.buttonBuscar);
            this.MaximumSize = new System.Drawing.Size(351, 206);
            this.MinimumSize = new System.Drawing.Size(351, 206);
            this.Name = "FormCredito";
            this.Text = "Pago Factura";
            this.Load += new System.EventHandler(this.FormCredito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonPagar;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelMontoPendiente;
        private System.Windows.Forms.Label labelMontoInicial;
        private System.Windows.Forms.Label labelTotalFactura;
        private System.Windows.Forms.Label labelPago;
        private System.Windows.Forms.TextBox textBoxIdFactura;
        private System.Windows.Forms.TextBox textBoxMontoPendiente;
        private System.Windows.Forms.TextBox textBoxMontoInicial;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxPago;
    }
}