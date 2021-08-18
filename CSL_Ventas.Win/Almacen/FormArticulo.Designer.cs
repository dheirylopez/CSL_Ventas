namespace CSL_Ventas.Win.Almacen
{
    partial class FormArticulo
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
            this.toolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewArticulos = new System.Windows.Forms.DataGridView();
            this.labelArticulo = new System.Windows.Forms.Label();
            this.textBoxArticulo = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager1 = new CSL_Ventas.Win.Operaciones.DataSetReportesTableAdapters.TableAdapterManager();
            this.dataSetReportes1 = new CSL_Ventas.Win.Operaciones.DataSetReportes();
            this.tableAdapterManager2 = new CSL_Ventas.Win.Operaciones.DataSetReportesTableAdapters.TableAdapterManager();
            this.view_Ganancias_GastosTableAdapter1 = new CSL_Ventas.Win.Operaciones.DataSetReportesTableAdapters.View_Ganancias_GastosTableAdapter();
            this.checkBoxCredito = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX100Credito = new System.Windows.Forms.TextBox();
            this.buttonAñadirArticulo = new System.Windows.Forms.Button();
            this.labelSelect = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGuardar,
            this.toolStripButtonEliminar,
            this.toolStripButtonAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(463, 25);
            this.toolStrip1.TabIndex = 8;
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
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminar.Image = global::CSL_Ventas.Win.Properties.Resources.close_16x164;
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEliminar.Text = "Eliminar";
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.toolStripButtonEliminar_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewArticulos);
            this.panel1.Location = new System.Drawing.Point(12, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 291);
            this.panel1.TabIndex = 9;
            // 
            // dataGridViewArticulos
            // 
            this.dataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewArticulos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewArticulos.Name = "dataGridViewArticulos";
            this.dataGridViewArticulos.Size = new System.Drawing.Size(430, 291);
            this.dataGridViewArticulos.TabIndex = 0;
            this.dataGridViewArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArticulos_CellDoubleClick);
            // 
            // labelArticulo
            // 
            this.labelArticulo.AutoSize = true;
            this.labelArticulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArticulo.Location = new System.Drawing.Point(19, 39);
            this.labelArticulo.Name = "labelArticulo";
            this.labelArticulo.Size = new System.Drawing.Size(56, 16);
            this.labelArticulo.TabIndex = 10;
            this.labelArticulo.Text = "Articulo:";
            // 
            // textBoxArticulo
            // 
            this.textBoxArticulo.Location = new System.Drawing.Point(81, 39);
            this.textBoxArticulo.Name = "textBoxArticulo";
            this.textBoxArticulo.Size = new System.Drawing.Size(121, 20);
            this.textBoxArticulo.TabIndex = 11;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(210, 39);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(38, 16);
            this.labelTipo.TabIndex = 13;
            this.labelTipo.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Buscar:";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(81, 111);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(382, 20);
            this.textBoxBuscar.TabIndex = 15;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "",
            "Creado",
            "Comprado"});
            this.comboBoxTipo.Location = new System.Drawing.Point(254, 39);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 16;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = CSL_Ventas.Win.Operaciones.DataSetReportesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataSetReportes1
            // 
            this.dataSetReportes1.DataSetName = "DataSetReportes";
            this.dataSetReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = CSL_Ventas.Win.Operaciones.DataSetReportesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_Ganancias_GastosTableAdapter1
            // 
            this.view_Ganancias_GastosTableAdapter1.ClearBeforeFill = true;
            // 
            // checkBoxCredito
            // 
            this.checkBoxCredito.AutoSize = true;
            this.checkBoxCredito.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.checkBoxCredito.Location = new System.Drawing.Point(254, 71);
            this.checkBoxCredito.Name = "checkBoxCredito";
            this.checkBoxCredito.Size = new System.Drawing.Size(68, 20);
            this.checkBoxCredito.TabIndex = 17;
            this.checkBoxCredito.Text = "Credito";
            this.checkBoxCredito.UseVisualStyleBackColor = true;
            this.checkBoxCredito.CheckedChanged += new System.EventHandler(this.checkBoxCredito_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "% Aumento X Credito:";
            this.label1.Visible = false;
            // 
            // textBoxX100Credito
            // 
            this.textBoxX100Credito.Location = new System.Drawing.Point(162, 70);
            this.textBoxX100Credito.Name = "textBoxX100Credito";
            this.textBoxX100Credito.Size = new System.Drawing.Size(74, 20);
            this.textBoxX100Credito.TabIndex = 19;
            this.textBoxX100Credito.Visible = false;
            // 
            // buttonAñadirArticulo
            // 
            this.buttonAñadirArticulo.BackgroundImage = global::CSL_Ventas.Win.Properties.Resources.application_view_columns;
            this.buttonAñadirArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAñadirArticulo.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.buttonAñadirArticulo.Location = new System.Drawing.Point(389, 28);
            this.buttonAñadirArticulo.Name = "buttonAñadirArticulo";
            this.buttonAñadirArticulo.Size = new System.Drawing.Size(53, 48);
            this.buttonAñadirArticulo.TabIndex = 20;
            this.buttonAñadirArticulo.UseVisualStyleBackColor = true;
            this.buttonAñadirArticulo.Click += new System.EventHandler(this.buttonAñadirArticulo_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelect.Location = new System.Drawing.Point(328, 92);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(0, 16);
            this.labelSelect.TabIndex = 21;
            // 
            // FormArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 455);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.buttonAñadirArticulo);
            this.Controls.Add(this.textBoxX100Credito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxCredito);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.textBoxArticulo);
            this.Controls.Add(this.labelArticulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "FormArticulo";
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.FormArticulo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewArticulos;
        private System.Windows.Forms.Label labelArticulo;
        private System.Windows.Forms.TextBox textBoxArticulo;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ToolStripButton toolStripButtonAyuda;
        private Operaciones.DataSetReportesTableAdapters.TableAdapterManager tableAdapterManager1;
        private Operaciones.DataSetReportes dataSetReportes1;
        private Operaciones.DataSetReportesTableAdapters.TableAdapterManager tableAdapterManager2;
        private Operaciones.DataSetReportesTableAdapters.View_Ganancias_GastosTableAdapter view_Ganancias_GastosTableAdapter1;
        private System.Windows.Forms.CheckBox checkBoxCredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX100Credito;
        private System.Windows.Forms.Button buttonAñadirArticulo;
        private System.Windows.Forms.Label labelSelect;
    }
}