namespace CSL_Ventas.Win
{
    partial class FormAgUsuario
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
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxEstatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(405, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAgregar
            // 
            this.toolStripButtonAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAgregar.Image = global::CSL_Ventas.Win.Properties.Resources.Save_16x16;
            this.toolStripButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregar.Name = "toolStripButtonAgregar";
            this.toolStripButtonAgregar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAgregar.Text = "agregar";
            this.toolStripButtonAgregar.Click += new System.EventHandler(this.toolStripButtonAgregar_Click);
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleado.Location = new System.Drawing.Point(53, 35);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(64, 14);
            this.labelEmpleado.TabIndex = 1;
            this.labelEmpleado.Text = "Empleado:";
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(123, 33);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(121, 22);
            this.comboBoxEmpleado.TabIndex = 2;
            // 
            // textBoxClave
            // 
            this.textBoxClave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClave.Location = new System.Drawing.Point(123, 64);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.ReadOnly = true;
            this.textBoxClave.Size = new System.Drawing.Size(121, 22);
            this.textBoxClave.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clave:";
            // 
            // checkBoxEstatus
            // 
            this.checkBoxEstatus.AutoSize = true;
            this.checkBoxEstatus.Checked = true;
            this.checkBoxEstatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEstatus.Font = new System.Drawing.Font("Tahoma", 9F);
            this.checkBoxEstatus.Location = new System.Drawing.Point(250, 34);
            this.checkBoxEstatus.Name = "checkBoxEstatus";
            this.checkBoxEstatus.Size = new System.Drawing.Size(66, 18);
            this.checkBoxEstatus.TabIndex = 7;
            this.checkBoxEstatus.Text = "Estatus";
            this.checkBoxEstatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Confirmar Clave:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(123, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 8;
            // 
            // FormAgUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxEstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.comboBoxEmpleado);
            this.Controls.Add(this.labelEmpleado);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgUsuario";
            this.Text = ".::Agregar Usuarios::.";
            this.Load += new System.EventHandler(this.FormAgUsuario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregar;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.ComboBox comboBoxEmpleado;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxEstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}