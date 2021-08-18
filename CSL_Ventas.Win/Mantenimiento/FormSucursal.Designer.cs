
namespace CSL_Ventas.Win
{
    partial class FormSucursal
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewSucursal = new System.Windows.Forms.DataGridView();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCompania = new System.Windows.Forms.ComboBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxRNL = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.labelNombreApellido = new System.Windows.Forms.Label();
            this.labelNDocumento = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSucursal)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridViewSucursal);
            this.panel2.Location = new System.Drawing.Point(10, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 241);
            this.panel2.TabIndex = 19;
            // 
            // dataGridViewSucursal
            // 
            this.dataGridViewSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSucursal.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSucursal.MultiSelect = false;
            this.dataGridViewSucursal.Name = "dataGridViewSucursal";
            this.dataGridViewSucursal.Size = new System.Drawing.Size(824, 241);
            this.dataGridViewSucursal.TabIndex = 0;
            this.dataGridViewSucursal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSucursal_CellDoubleClick);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(85, 164);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(749, 20);
            this.textBoxBuscar.TabIndex = 18;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelBuscar.Location = new System.Drawing.Point(16, 164);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(51, 16);
            this.labelBuscar.TabIndex = 17;
            this.labelBuscar.Text = "Buscar:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboBoxCompania);
            this.panel1.Controls.Add(this.textBoxDireccion);
            this.panel1.Controls.Add(this.textBoxTelefono);
            this.panel1.Controls.Add(this.textBoxRNL);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.labelTipoDocumento);
            this.panel1.Controls.Add(this.labelNombreApellido);
            this.panel1.Controls.Add(this.labelNDocumento);
            this.panel1.Controls.Add(this.labelDireccion);
            this.panel1.Controls.Add(this.labelTelefono);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(10, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 127);
            this.panel1.TabIndex = 16;
            // 
            // comboBoxCompania
            // 
            this.comboBoxCompania.FormattingEnabled = true;
            this.comboBoxCompania.Items.AddRange(new object[] {
            "",
            "Cedula",
            "RNC"});
            this.comboBoxCompania.Location = new System.Drawing.Point(153, 92);
            this.comboBoxCompania.Name = "comboBoxCompania";
            this.comboBoxCompania.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCompania.TabIndex = 12;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(385, 94);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(365, 23);
            this.textBoxDireccion.TabIndex = 10;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(385, 61);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 23);
            this.textBoxTelefono.TabIndex = 9;
            // 
            // textBoxRNL
            // 
            this.textBoxRNL.Location = new System.Drawing.Point(153, 60);
            this.textBoxRNL.Name = "textBoxRNL";
            this.textBoxRNL.Size = new System.Drawing.Size(100, 23);
            this.textBoxRNL.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(153, 24);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 23);
            this.textBoxNombre.TabIndex = 7;
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(65, 95);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(70, 16);
            this.labelTipoDocumento.TabIndex = 2;
            this.labelTipoDocumento.Text = "Compania:";
            // 
            // labelNombreApellido
            // 
            this.labelNombreApellido.AutoSize = true;
            this.labelNombreApellido.Location = new System.Drawing.Point(77, 31);
            this.labelNombreApellido.Name = "labelNombreApellido";
            this.labelNombreApellido.Size = new System.Drawing.Size(58, 16);
            this.labelNombreApellido.TabIndex = 1;
            this.labelNombreApellido.Text = "Nombre:";
            // 
            // labelNDocumento
            // 
            this.labelNDocumento.AutoSize = true;
            this.labelNDocumento.Location = new System.Drawing.Point(100, 63);
            this.labelNDocumento.Name = "labelNDocumento";
            this.labelNDocumento.Size = new System.Drawing.Size(35, 16);
            this.labelNDocumento.TabIndex = 3;
            this.labelNDocumento.Text = "RNL:";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(314, 101);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(65, 16);
            this.labelDireccion.TabIndex = 5;
            this.labelDireccion.Text = "Direccion:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(316, 63);
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
            this.toolStrip1.TabIndex = 20;
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
            // FormSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 435);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormSucursal";
            this.Text = "Sucursal";
            this.Load += new System.EventHandler(this.FormSucursal_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSucursal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewSucursal;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxRNL;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombreApellido;
        private System.Windows.Forms.Label labelNDocumento;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ComboBox comboBoxCompania;
        private System.Windows.Forms.Label labelTipoDocumento;
    }
}