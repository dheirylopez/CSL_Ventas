namespace CSL_Ventas.Win.Operaciones
{
    partial class FormCierreCaja
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
            this.textBoxMontoInicial = new System.Windows.Forms.TextBox();
            this.textBoxColaborador = new System.Windows.Forms.TextBox();
            this.labelMontoInicial = new System.Windows.Forms.Label();
            this.labelColaborador = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonAbrirCaja = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdCaja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMontoInicial
            // 
            this.textBoxMontoInicial.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxMontoInicial.Location = new System.Drawing.Point(155, 46);
            this.textBoxMontoInicial.Name = "textBoxMontoInicial";
            this.textBoxMontoInicial.Size = new System.Drawing.Size(100, 23);
            this.textBoxMontoInicial.TabIndex = 0;
            // 
            // textBoxColaborador
            // 
            this.textBoxColaborador.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxColaborador.Location = new System.Drawing.Point(155, 109);
            this.textBoxColaborador.Name = "textBoxColaborador";
            this.textBoxColaborador.ReadOnly = true;
            this.textBoxColaborador.Size = new System.Drawing.Size(100, 23);
            this.textBoxColaborador.TabIndex = 1;
            // 
            // labelMontoInicial
            // 
            this.labelMontoInicial.AutoSize = true;
            this.labelMontoInicial.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelMontoInicial.Location = new System.Drawing.Point(16, 47);
            this.labelMontoInicial.Name = "labelMontoInicial";
            this.labelMontoInicial.Size = new System.Drawing.Size(133, 16);
            this.labelMontoInicial.TabIndex = 2;
            this.labelMontoInicial.Text = "Monto Inicial de Caja:";
            // 
            // labelColaborador
            // 
            this.labelColaborador.AutoSize = true;
            this.labelColaborador.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelColaborador.Location = new System.Drawing.Point(66, 111);
            this.labelColaborador.Name = "labelColaborador";
            this.labelColaborador.Size = new System.Drawing.Size(83, 16);
            this.labelColaborador.TabIndex = 3;
            this.labelColaborador.Text = "Colaborador:";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.buttonCerrar.Location = new System.Drawing.Point(277, 44);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 4;
            this.buttonCerrar.Text = "Cerrar Caja";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonAbrirCaja
            // 
            this.buttonAbrirCaja.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.buttonAbrirCaja.Location = new System.Drawing.Point(277, 82);
            this.buttonAbrirCaja.Name = "buttonAbrirCaja";
            this.buttonAbrirCaja.Size = new System.Drawing.Size(75, 23);
            this.buttonAbrirCaja.TabIndex = 5;
            this.buttonAbrirCaja.Text = "Abrir Caja";
            this.buttonAbrirCaja.UseVisualStyleBackColor = true;
            this.buttonAbrirCaja.Click += new System.EventHandler(this.buttonAbrirCaja_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelId.Location = new System.Drawing.Point(125, 18);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(24, 16);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "Id:";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxId.Location = new System.Drawing.Point(155, 17);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(32, 23);
            this.textBoxId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(41, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero de Caja:";
            // 
            // textBoxIdCaja
            // 
            this.textBoxIdCaja.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxIdCaja.Location = new System.Drawing.Point(155, 78);
            this.textBoxIdCaja.Name = "textBoxIdCaja";
            this.textBoxIdCaja.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdCaja.TabIndex = 10;
            // 
            // FormCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 156);
            this.Controls.Add(this.textBoxIdCaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonAbrirCaja);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.labelColaborador);
            this.Controls.Add(this.labelMontoInicial);
            this.Controls.Add(this.textBoxColaborador);
            this.Controls.Add(this.textBoxMontoInicial);
            this.DoubleBuffered = true;
            this.Name = "FormCierreCaja";
            this.Text = "Cierre de Caja";
            this.Load += new System.EventHandler(this.FormCierreCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMontoInicial;
        private System.Windows.Forms.TextBox textBoxColaborador;
        private System.Windows.Forms.Label labelMontoInicial;
        private System.Windows.Forms.Label labelColaborador;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonAbrirCaja;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdCaja;
    }
}