
namespace CSL_Ventas.Win
{
    partial class FormEmpleados
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
            this.textBoxSueldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPosicion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxNoDocumento = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.labelNombreApellido = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNDocumento = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewEmpleado = new System.Windows.Forms.DataGridView();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBoxSueldo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxPosicion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxTipoDocumento);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxDireccion);
            this.panel1.Controls.Add(this.textBoxTelefono);
            this.panel1.Controls.Add(this.textBoxNoDocumento);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.labelTipoDocumento);
            this.panel1.Controls.Add(this.labelNombreApellido);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelNDocumento);
            this.panel1.Controls.Add(this.labelDireccion);
            this.panel1.Controls.Add(this.labelTelefono);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 105);
            this.panel1.TabIndex = 12;
            // 
            // textBoxSueldo
            // 
            this.textBoxSueldo.Location = new System.Drawing.Point(620, 5);
            this.textBoxSueldo.Name = "textBoxSueldo";
            this.textBoxSueldo.Size = new System.Drawing.Size(179, 23);
            this.textBoxSueldo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sueldo:";
            // 
            // textBoxPosicion
            // 
            this.textBoxPosicion.Location = new System.Drawing.Point(156, 39);
            this.textBoxPosicion.Name = "textBoxPosicion";
            this.textBoxPosicion.Size = new System.Drawing.Size(127, 23);
            this.textBoxPosicion.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Posicion:";
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Items.AddRange(new object[] {
            "",
            "Cedula",
            "RNC"});
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(156, 71);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(127, 24);
            this.comboBoxTipoDocumento.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(620, 39);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(179, 23);
            this.textBoxEmail.TabIndex = 11;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(388, 73);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(411, 23);
            this.textBoxDireccion.TabIndex = 10;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(388, 40);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(133, 23);
            this.textBoxTelefono.TabIndex = 9;
            // 
            // textBoxNoDocumento
            // 
            this.textBoxNoDocumento.Location = new System.Drawing.Point(388, 3);
            this.textBoxNoDocumento.Name = "textBoxNoDocumento";
            this.textBoxNoDocumento.Size = new System.Drawing.Size(133, 23);
            this.textBoxNoDocumento.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(156, 3);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(127, 23);
            this.textBoxNombre.TabIndex = 7;
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(14, 74);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(124, 16);
            this.labelTipoDocumento.TabIndex = 2;
            this.labelTipoDocumento.Text = "Tipo de Documento:";
            // 
            // labelNombreApellido
            // 
            this.labelNombreApellido.AutoSize = true;
            this.labelNombreApellido.Location = new System.Drawing.Point(80, 10);
            this.labelNombreApellido.Name = "labelNombreApellido";
            this.labelNombreApellido.Size = new System.Drawing.Size(58, 16);
            this.labelNombreApellido.TabIndex = 1;
            this.labelNombreApellido.Text = "Nombre:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(547, 44);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 16);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email:";
            // 
            // labelNDocumento
            // 
            this.labelNDocumento.AutoSize = true;
            this.labelNDocumento.Location = new System.Drawing.Point(289, 6);
            this.labelNDocumento.Name = "labelNDocumento";
            this.labelNDocumento.Size = new System.Drawing.Size(93, 16);
            this.labelNDocumento.TabIndex = 3;
            this.labelNDocumento.Text = "N. Documento:";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(317, 80);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(65, 16);
            this.labelDireccion.TabIndex = 5;
            this.labelDireccion.Text = "Direccion:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(319, 42);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(63, 16);
            this.labelTelefono.TabIndex = 4;
            this.labelTelefono.Text = "Telefono:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGuardar,
            this.toolStripButtonEditar,
            this.toolStripButtonEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(846, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonGuardar
            // 
            this.toolStripButtonGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGuardar.Image = global::CSL_Ventas.Win.Properties.Resources.Save_16x16;
            this.toolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuardar.Name = "toolStripButtonGuardar";
            this.toolStripButtonGuardar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGuardar.Text = "Guardar";
            this.toolStripButtonGuardar.Click += new System.EventHandler(this.toolStripButtonGuardar_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditar.Image = global::CSL_Ventas.Win.Properties.Resources.Edit_16x16;
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditar.Text = "Editar";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminar.Image = global::CSL_Ventas.Win.Properties.Resources.Delete_16x16;
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEliminar.Text = "Eliminar";
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.toolStripButtonEliminar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridViewEmpleado);
            this.panel2.Location = new System.Drawing.Point(12, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 241);
            this.panel2.TabIndex = 19;
            // 
            // dataGridViewEmpleado
            // 
            this.dataGridViewEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmpleado.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmpleado.MultiSelect = false;
            this.dataGridViewEmpleado.Name = "dataGridViewEmpleado";
            this.dataGridViewEmpleado.Size = new System.Drawing.Size(822, 241);
            this.dataGridViewEmpleado.TabIndex = 0;
            this.dataGridViewEmpleado.DoubleClick += new System.EventHandler(this.dataGridViewEmpleado_DoubleClick);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(95, 154);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(739, 20);
            this.textBoxBuscar.TabIndex = 18;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelBuscar.Location = new System.Drawing.Point(26, 154);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(51, 16);
            this.labelBuscar.TabIndex = 17;
            this.labelBuscar.Text = "Buscar:";
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 435);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPosicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxNoDocumento;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.Label labelNombreApellido;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNDocumento;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewEmpleado;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxSueldo;
        private System.Windows.Forms.Label label2;
    }
}