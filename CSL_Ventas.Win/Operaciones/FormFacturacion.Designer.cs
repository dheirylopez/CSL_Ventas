namespace CSL_Ventas.Win.Operaciones
{
    partial class FormFacturacion
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
            this.comboBoxTipoFactura = new System.Windows.Forms.ComboBox();
            this.labelTipoFactura = new System.Windows.Forms.Label();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.comboBoxColaborador = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoNCF = new System.Windows.Forms.ComboBox();
            this.comboBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.labelTipoNCF = new System.Windows.Forms.Label();
            this.textBoxNCF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFormaPago = new System.Windows.Forms.Label();
            this.buttonBuscarCotizacion = new System.Windows.Forms.Button();
            this.textBoxIDCotizacion = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelColaborador = new System.Windows.Forms.Label();
            this.labelCotizacion = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxArticulo = new System.Windows.Forms.TextBox();
            this.buttonArticulo = new System.Windows.Forms.Button();
            this.labelArticulo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonQuitar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnular = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefrescar = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewFacturacion = new System.Windows.Forms.DataGridView();
            this.labelObservacion = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.labelItebis = new System.Windows.Forms.Label();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.textBoxItebis = new System.Windows.Forms.TextBox();
            this.textBoxDescuento = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxPagoInicial = new System.Windows.Forms.TextBox();
            this.labelPagoInicial = new System.Windows.Forms.Label();
            this.textBoxPagoPendiente = new System.Windows.Forms.TextBox();
            this.labelPagoPendiente = new System.Windows.Forms.Label();
            this.textBoxEfectivo = new System.Windows.Forms.TextBox();
            this.labelEfectivo = new System.Windows.Forms.Label();
            this.textBoxCambio = new System.Windows.Forms.TextBox();
            this.labelCambio = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCantidadAlmacen = new System.Windows.Forms.Label();
            this.buttonCompletarFactura = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturacion)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxTipoFactura);
            this.panel1.Controls.Add(this.labelTipoFactura);
            this.panel1.Controls.Add(this.buttonCliente);
            this.panel1.Controls.Add(this.textBoxCliente);
            this.panel1.Controls.Add(this.comboBoxColaborador);
            this.panel1.Controls.Add(this.comboBoxTipoNCF);
            this.panel1.Controls.Add(this.comboBoxFormaPago);
            this.panel1.Controls.Add(this.labelTipoNCF);
            this.panel1.Controls.Add(this.textBoxNCF);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelFormaPago);
            this.panel1.Controls.Add(this.buttonBuscarCotizacion);
            this.panel1.Controls.Add(this.textBoxIDCotizacion);
            this.panel1.Controls.Add(this.labelCliente);
            this.panel1.Controls.Add(this.labelColaborador);
            this.panel1.Controls.Add(this.labelCotizacion);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 106);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxTipoFactura
            // 
            this.comboBoxTipoFactura.FormattingEnabled = true;
            this.comboBoxTipoFactura.Items.AddRange(new object[] {
            "",
            "Contado",
            "Credito"});
            this.comboBoxTipoFactura.Location = new System.Drawing.Point(975, 64);
            this.comboBoxTipoFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTipoFactura.Name = "comboBoxTipoFactura";
            this.comboBoxTipoFactura.Size = new System.Drawing.Size(213, 27);
            this.comboBoxTipoFactura.TabIndex = 30;
            // 
            // labelTipoFactura
            // 
            this.labelTipoFactura.AutoSize = true;
            this.labelTipoFactura.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelTipoFactura.Location = new System.Drawing.Point(853, 70);
            this.labelTipoFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoFactura.Name = "labelTipoFactura";
            this.labelTipoFactura.Size = new System.Drawing.Size(109, 21);
            this.labelTipoFactura.TabIndex = 29;
            this.labelTipoFactura.Text = "Tipo Factura:";
            // 
            // buttonCliente
            // 
            this.buttonCliente.Image = global::CSL_Ventas.Win.Properties.Resources.Team_32x32;
            this.buttonCliente.Location = new System.Drawing.Point(557, 11);
            this.buttonCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(100, 44);
            this.buttonCliente.TabIndex = 22;
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(376, 17);
            this.textBoxCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(155, 27);
            this.textBoxCliente.TabIndex = 21;
            // 
            // comboBoxColaborador
            // 
            this.comboBoxColaborador.FormattingEnabled = true;
            this.comboBoxColaborador.Location = new System.Drawing.Point(133, 64);
            this.comboBoxColaborador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxColaborador.Name = "comboBoxColaborador";
            this.comboBoxColaborador.Size = new System.Drawing.Size(283, 27);
            this.comboBoxColaborador.TabIndex = 20;

            // 
            // comboBoxTipoNCF
            // 
            this.comboBoxTipoNCF.FormattingEnabled = true;
            this.comboBoxTipoNCF.Items.AddRange(new object[] {
            "",
            "Factura Proforma",
            "Factura de  crédito fiscal",
            "Facturas para consumidores Finales",
            "Nota de Débito",
            "Nota de Crédito",
            "Proveedores Informales",
            "Registro Único de Ingresos",
            "Gastos Menores",
            "Regímenes Especiales de Tributación",
            "Comprobrantes Gubernamentales"});
            this.comboBoxTipoNCF.Location = new System.Drawing.Point(776, 10);
            this.comboBoxTipoNCF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTipoNCF.Name = "comboBoxTipoNCF";
            this.comboBoxTipoNCF.Size = new System.Drawing.Size(213, 27);
            this.comboBoxTipoNCF.TabIndex = 17;
            this.comboBoxTipoNCF.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoNCF_SelectedIndexChanged);
            // 
            // comboBoxFormaPago
            // 
            this.comboBoxFormaPago.FormattingEnabled = true;
            this.comboBoxFormaPago.Items.AddRange(new object[] {
            "",
            "Efectivo",
            "Tarjeta",
            "Banco",
            "Credito"});
            this.comboBoxFormaPago.Location = new System.Drawing.Point(601, 64);
            this.comboBoxFormaPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFormaPago.Name = "comboBoxFormaPago";
            this.comboBoxFormaPago.Size = new System.Drawing.Size(213, 27);
            this.comboBoxFormaPago.TabIndex = 28;
            // 
            // labelTipoNCF
            // 
            this.labelTipoNCF.AutoSize = true;
            this.labelTipoNCF.Location = new System.Drawing.Point(680, 15);
            this.labelTipoNCF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoNCF.Name = "labelTipoNCF";
            this.labelTipoNCF.Size = new System.Drawing.Size(83, 21);
            this.labelTipoNCF.TabIndex = 16;
            this.labelTipoNCF.Text = "Tipo NCF:";
            // 
            // textBoxNCF
            // 
            this.textBoxNCF.Location = new System.Drawing.Point(1053, 10);
            this.textBoxNCF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNCF.Name = "textBoxNCF";
            this.textBoxNCF.ReadOnly = true;
            this.textBoxNCF.Size = new System.Drawing.Size(217, 27);
            this.textBoxNCF.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(999, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "NCF:";
            // 
            // labelFormaPago
            // 
            this.labelFormaPago.AutoSize = true;
            this.labelFormaPago.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelFormaPago.Location = new System.Drawing.Point(451, 69);
            this.labelFormaPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormaPago.Name = "labelFormaPago";
            this.labelFormaPago.Size = new System.Drawing.Size(127, 21);
            this.labelFormaPago.TabIndex = 27;
            this.labelFormaPago.Text = "Forma de Pago:";
            // 
            // buttonBuscarCotizacion
            // 
            this.buttonBuscarCotizacion.Image = global::CSL_Ventas.Win.Properties.Resources.btnSearch_Image;
            this.buttonBuscarCotizacion.Location = new System.Drawing.Point(265, 14);
            this.buttonBuscarCotizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuscarCotizacion.Name = "buttonBuscarCotizacion";
            this.buttonBuscarCotizacion.Size = new System.Drawing.Size(32, 27);
            this.buttonBuscarCotizacion.TabIndex = 12;
            this.buttonBuscarCotizacion.UseVisualStyleBackColor = true;
            this.buttonBuscarCotizacion.Click += new System.EventHandler(this.buttonBuscarCotizacion_Click);
            // 
            // textBoxIDCotizacion
            // 
            this.textBoxIDCotizacion.Location = new System.Drawing.Point(135, 14);
            this.textBoxIDCotizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIDCotizacion.Name = "textBoxIDCotizacion";
            this.textBoxIDCotizacion.Size = new System.Drawing.Size(121, 27);
            this.textBoxIDCotizacion.TabIndex = 8;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(305, 20);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(67, 21);
            this.labelCliente.TabIndex = 2;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelColaborador
            // 
            this.labelColaborador.AutoSize = true;
            this.labelColaborador.Location = new System.Drawing.Point(13, 69);
            this.labelColaborador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColaborador.Name = "labelColaborador";
            this.labelColaborador.Size = new System.Drawing.Size(105, 21);
            this.labelColaborador.TabIndex = 1;
            this.labelColaborador.Text = "Colaborador:";
            // 
            // labelCotizacion
            // 
            this.labelCotizacion.AutoSize = true;
            this.labelCotizacion.Location = new System.Drawing.Point(29, 17);
            this.labelCotizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCotizacion.Name = "labelCotizacion";
            this.labelCotizacion.Size = new System.Drawing.Size(92, 21);
            this.labelCotizacion.TabIndex = 0;
            this.labelCotizacion.Text = "Cotizacion:";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(355, 59);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(89, 27);
            this.textBoxCantidad.TabIndex = 24;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(256, 64);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(81, 21);
            this.labelCantidad.TabIndex = 23;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // textBoxArticulo
            // 
            this.textBoxArticulo.Location = new System.Drawing.Point(103, 21);
            this.textBoxArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxArticulo.Name = "textBoxArticulo";
            this.textBoxArticulo.ReadOnly = true;
            this.textBoxArticulo.Size = new System.Drawing.Size(155, 27);
            this.textBoxArticulo.TabIndex = 19;
            // 
            // buttonArticulo
            // 
            this.buttonArticulo.Image = global::CSL_Ventas.Win.Properties.Resources.ConvertToParagraphs_32x32;
            this.buttonArticulo.Location = new System.Drawing.Point(479, 14);
            this.buttonArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonArticulo.Name = "buttonArticulo";
            this.buttonArticulo.Size = new System.Drawing.Size(100, 44);
            this.buttonArticulo.TabIndex = 18;
            this.buttonArticulo.UseVisualStyleBackColor = true;
            this.buttonArticulo.Click += new System.EventHandler(this.buttonArticulo_Click);
            // 
            // labelArticulo
            // 
            this.labelArticulo.AutoSize = true;
            this.labelArticulo.Location = new System.Drawing.Point(19, 26);
            this.labelArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArticulo.Name = "labelArticulo";
            this.labelArticulo.Size = new System.Drawing.Size(73, 21);
            this.labelArticulo.TabIndex = 3;
            this.labelArticulo.Text = "Articulo:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAgregar,
            this.toolStripButtonQuitar,
            this.toolStripButtonLimpiar,
            this.toolStripButtonImprimir,
            this.toolStripButtonAyuda,
            this.toolStripButtonAnular,
            this.toolStripButtonRefrescar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1297, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAgregar
            // 
            this.toolStripButtonAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAgregar.Image = global::CSL_Ventas.Win.Properties.Resources.additem_16x16;
            this.toolStripButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregar.Name = "toolStripButtonAgregar";
            this.toolStripButtonAgregar.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonAgregar.Text = "Agregar";
            this.toolStripButtonAgregar.Click += new System.EventHandler(this.toolStripButtonAgregar_Click);
            // 
            // toolStripButtonQuitar
            // 
            this.toolStripButtonQuitar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonQuitar.Image = global::CSL_Ventas.Win.Properties.Resources.deletelist_16x162;
            this.toolStripButtonQuitar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuitar.Name = "toolStripButtonQuitar";
            this.toolStripButtonQuitar.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonQuitar.Text = "Quitar";
            this.toolStripButtonQuitar.Click += new System.EventHandler(this.toolStripButtonQuitar_Click);
            // 
            // toolStripButtonLimpiar
            // 
            this.toolStripButtonLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLimpiar.Image = global::CSL_Ventas.Win.Properties.Resources.clear_16x16;
            this.toolStripButtonLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLimpiar.Name = "toolStripButtonLimpiar";
            this.toolStripButtonLimpiar.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonLimpiar.Text = "Limpiar";
            this.toolStripButtonLimpiar.Click += new System.EventHandler(this.toolStripButtonLimpiar_Click);
            // 
            // toolStripButtonImprimir
            // 
            this.toolStripButtonImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImprimir.Image = global::CSL_Ventas.Win.Properties.Resources.print_16x16;
            this.toolStripButtonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImprimir.Name = "toolStripButtonImprimir";
            this.toolStripButtonImprimir.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonImprimir.Text = "Imsprimir";
            this.toolStripButtonImprimir.Click += new System.EventHandler(this.toolStripButtonImprimir_Click);
            // 
            // toolStripButtonAyuda
            // 
            this.toolStripButtonAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAyuda.Image = global::CSL_Ventas.Win.Properties.Resources.about_16x161;
            this.toolStripButtonAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAyuda.Name = "toolStripButtonAyuda";
            this.toolStripButtonAyuda.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonAyuda.Text = "Ayuda";
            this.toolStripButtonAyuda.Click += new System.EventHandler(this.toolStripButtonAyuda_Click);
            // 
            // toolStripButtonAnular
            // 
            this.toolStripButtonAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAnular.Image = global::CSL_Ventas.Win.Properties.Resources.hide_16x161;
            this.toolStripButtonAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnular.Name = "toolStripButtonAnular";
            this.toolStripButtonAnular.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonAnular.Text = "Anular";
            this.toolStripButtonAnular.Click += new System.EventHandler(this.toolStripButtonAnular_Click);
            // 
            // toolStripButtonRefrescar
            // 
            this.toolStripButtonRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefrescar.Image = global::CSL_Ventas.Win.Properties.Resources.convert_16x161;
            this.toolStripButtonRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefrescar.Name = "toolStripButtonRefrescar";
            this.toolStripButtonRefrescar.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonRefrescar.Text = "Refrescar";
            this.toolStripButtonRefrescar.Click += new System.EventHandler(this.toolStripButtonRefrescar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewFacturacion);
            this.panel2.Location = new System.Drawing.Point(0, 160);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 347);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewFacturacion
            // 
            this.dataGridViewFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFacturacion.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFacturacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFacturacion.Name = "dataGridViewFacturacion";
            this.dataGridViewFacturacion.RowHeadersWidth = 51;
            this.dataGridViewFacturacion.Size = new System.Drawing.Size(669, 347);
            this.dataGridViewFacturacion.TabIndex = 0;
            // 
            // labelObservacion
            // 
            this.labelObservacion.AutoSize = true;
            this.labelObservacion.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelObservacion.Location = new System.Drawing.Point(20, 524);
            this.labelObservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObservacion.Name = "labelObservacion";
            this.labelObservacion.Size = new System.Drawing.Size(107, 21);
            this.labelObservacion.TabIndex = 2;
            this.labelObservacion.Text = "Observacion:";
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelSubTotal.Location = new System.Drawing.Point(1049, 463);
            this.labelSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(87, 21);
            this.labelSubTotal.TabIndex = 3;
            this.labelSubTotal.Text = "Sub-Total:";
            // 
            // labelItebis
            // 
            this.labelItebis.AutoSize = true;
            this.labelItebis.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelItebis.Location = new System.Drawing.Point(1083, 430);
            this.labelItebis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItebis.Name = "labelItebis";
            this.labelItebis.Size = new System.Drawing.Size(58, 21);
            this.labelItebis.TabIndex = 4;
            this.labelItebis.Text = "Itebis:";
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelDescuento.Location = new System.Drawing.Point(1045, 402);
            this.labelDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(95, 21);
            this.labelDescuento.TabIndex = 5;
            this.labelDescuento.Text = "Descuento:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelTotal.Location = new System.Drawing.Point(1085, 487);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(54, 21);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total:";
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.Location = new System.Drawing.Point(135, 523);
            this.textBoxObservacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxObservacion.Multiline = true;
            this.textBoxObservacion.Name = "textBoxObservacion";
            this.textBoxObservacion.Size = new System.Drawing.Size(533, 59);
            this.textBoxObservacion.TabIndex = 7;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(1151, 458);
            this.textBoxSubTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.ReadOnly = true;
            this.textBoxSubTotal.Size = new System.Drawing.Size(132, 22);
            this.textBoxSubTotal.TabIndex = 8;
            // 
            // textBoxItebis
            // 
            this.textBoxItebis.Location = new System.Drawing.Point(1151, 427);
            this.textBoxItebis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxItebis.Name = "textBoxItebis";
            this.textBoxItebis.ReadOnly = true;
            this.textBoxItebis.Size = new System.Drawing.Size(132, 22);
            this.textBoxItebis.TabIndex = 9;
            // 
            // textBoxDescuento
            // 
            this.textBoxDescuento.Location = new System.Drawing.Point(1149, 398);
            this.textBoxDescuento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDescuento.Name = "textBoxDescuento";
            this.textBoxDescuento.Size = new System.Drawing.Size(133, 22);
            this.textBoxDescuento.TabIndex = 10;
            this.textBoxDescuento.TextChanged += new System.EventHandler(this.textBoxDescuento_TextChanged);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(1149, 486);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(132, 22);
            this.textBoxTotal.TabIndex = 11;
            // 
            // textBoxPagoInicial
            // 
            this.textBoxPagoInicial.Location = new System.Drawing.Point(467, 139);
            this.textBoxPagoInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPagoInicial.Name = "textBoxPagoInicial";
            this.textBoxPagoInicial.Size = new System.Drawing.Size(133, 27);
            this.textBoxPagoInicial.TabIndex = 13;
            this.textBoxPagoInicial.TextChanged += new System.EventHandler(this.textBoxPagoInicial_TextChanged);
            // 
            // labelPagoInicial
            // 
            this.labelPagoInicial.AutoSize = true;
            this.labelPagoInicial.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelPagoInicial.Location = new System.Drawing.Point(347, 142);
            this.labelPagoInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPagoInicial.Name = "labelPagoInicial";
            this.labelPagoInicial.Size = new System.Drawing.Size(101, 21);
            this.labelPagoInicial.TabIndex = 12;
            this.labelPagoInicial.Text = "Pago Inicial:";
            // 
            // textBoxPagoPendiente
            // 
            this.textBoxPagoPendiente.Location = new System.Drawing.Point(467, 172);
            this.textBoxPagoPendiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPagoPendiente.Name = "textBoxPagoPendiente";
            this.textBoxPagoPendiente.ReadOnly = true;
            this.textBoxPagoPendiente.Size = new System.Drawing.Size(133, 27);
            this.textBoxPagoPendiente.TabIndex = 15;
            // 
            // labelPagoPendiente
            // 
            this.labelPagoPendiente.AutoSize = true;
            this.labelPagoPendiente.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelPagoPendiente.Location = new System.Drawing.Point(317, 170);
            this.labelPagoPendiente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPagoPendiente.Name = "labelPagoPendiente";
            this.labelPagoPendiente.Size = new System.Drawing.Size(130, 21);
            this.labelPagoPendiente.TabIndex = 14;
            this.labelPagoPendiente.Text = "Pago Pendiente:";
            // 
            // textBoxEfectivo
            // 
            this.textBoxEfectivo.Location = new System.Drawing.Point(104, 142);
            this.textBoxEfectivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEfectivo.Name = "textBoxEfectivo";
            this.textBoxEfectivo.Size = new System.Drawing.Size(133, 27);
            this.textBoxEfectivo.TabIndex = 17;
            this.textBoxEfectivo.TextChanged += new System.EventHandler(this.textBoxEfectivo_TextChanged);
            // 
            // labelEfectivo
            // 
            this.labelEfectivo.AutoSize = true;
            this.labelEfectivo.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelEfectivo.Location = new System.Drawing.Point(11, 144);
            this.labelEfectivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEfectivo.Name = "labelEfectivo";
            this.labelEfectivo.Size = new System.Drawing.Size(75, 21);
            this.labelEfectivo.TabIndex = 16;
            this.labelEfectivo.Text = "Efectivo:";
            // 
            // textBoxCambio
            // 
            this.textBoxCambio.Location = new System.Drawing.Point(105, 175);
            this.textBoxCambio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCambio.Name = "textBoxCambio";
            this.textBoxCambio.ReadOnly = true;
            this.textBoxCambio.Size = new System.Drawing.Size(133, 27);
            this.textBoxCambio.TabIndex = 19;
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelCambio.Location = new System.Drawing.Point(13, 180);
            this.labelCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(71, 21);
            this.labelCambio.TabIndex = 18;
            this.labelCambio.Text = "Cambio:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxPrecio);
            this.panel3.Controls.Add(this.textBoxPagoPendiente);
            this.panel3.Controls.Add(this.textBoxCambio);
            this.panel3.Controls.Add(this.labelPagoPendiente);
            this.panel3.Controls.Add(this.labelCambio);
            this.panel3.Controls.Add(this.textBoxPagoInicial);
            this.panel3.Controls.Add(this.labelPagoInicial);
            this.panel3.Controls.Add(this.labelPrecio);
            this.panel3.Controls.Add(this.textBoxEfectivo);
            this.panel3.Controls.Add(this.labelCantidadAlmacen);
            this.panel3.Controls.Add(this.labelEfectivo);
            this.panel3.Controls.Add(this.textBoxCantidad);
            this.panel3.Controls.Add(this.buttonArticulo);
            this.panel3.Controls.Add(this.labelCantidad);
            this.panel3.Controls.Add(this.textBoxArticulo);
            this.panel3.Controls.Add(this.labelArticulo);
            this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(684, 171);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 218);
            this.panel3.TabIndex = 25;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(351, 21);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(119, 27);
            this.textBoxPrecio.TabIndex = 31;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(272, 23);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(61, 21);
            this.labelPrecio.TabIndex = 30;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelCantidadAlmacen
            // 
            this.labelCantidadAlmacen.AutoSize = true;
            this.labelCantidadAlmacen.Location = new System.Drawing.Point(25, 64);
            this.labelCantidadAlmacen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidadAlmacen.Name = "labelCantidadAlmacen";
            this.labelCantidadAlmacen.Size = new System.Drawing.Size(173, 21);
            this.labelCantidadAlmacen.TabIndex = 29;
            this.labelCantidadAlmacen.Text = "Cantidad en Almacen:";
            // 
            // buttonCompletarFactura
            // 
            this.buttonCompletarFactura.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.buttonCompletarFactura.Location = new System.Drawing.Point(684, 396);
            this.buttonCompletarFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCompletarFactura.Name = "buttonCompletarFactura";
            this.buttonCompletarFactura.Size = new System.Drawing.Size(132, 55);
            this.buttonCompletarFactura.TabIndex = 26;
            this.buttonCompletarFactura.Text = "Pago Pendiente";
            this.buttonCompletarFactura.UseVisualStyleBackColor = true;
            this.buttonCompletarFactura.Click += new System.EventHandler(this.buttonCompletarFactura_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.button2.Location = new System.Drawing.Point(684, 463);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 32);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cierre de Caja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 585);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCompletarFactura);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxDescuento);
            this.Controls.Add(this.textBoxItebis);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.textBoxObservacion);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDescuento);
            this.Controls.Add(this.labelItebis);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.labelObservacion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFacturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturacion)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregar;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnular;
        private System.Windows.Forms.ToolStripButton toolStripButtonLimpiar;
        private System.Windows.Forms.ToolStripButton toolStripButtonImprimir;
        private System.Windows.Forms.Button buttonBuscarCotizacion;
        private System.Windows.Forms.TextBox textBoxIDCotizacion;
        private System.Windows.Forms.Label labelArticulo;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelColaborador;
        private System.Windows.Forms.Label labelCotizacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewFacturacion;
        private System.Windows.Forms.Label labelObservacion;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label labelItebis;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxObservacion;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.TextBox textBoxItebis;
        private System.Windows.Forms.TextBox textBoxDescuento;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.ToolStripButton toolStripButtonAyuda;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuitar;
        private System.Windows.Forms.TextBox textBoxNCF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipoNCF;
        private System.Windows.Forms.Label labelTipoNCF;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefrescar;
        private System.Windows.Forms.Button buttonArticulo;
        private System.Windows.Forms.TextBox textBoxArticulo;
        private System.Windows.Forms.ComboBox comboBoxColaborador;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxPagoInicial;
        private System.Windows.Forms.Label labelPagoInicial;
        private System.Windows.Forms.TextBox textBoxPagoPendiente;
        private System.Windows.Forms.Label labelPagoPendiente;
        private System.Windows.Forms.TextBox textBoxEfectivo;
        private System.Windows.Forms.Label labelEfectivo;
        private System.Windows.Forms.TextBox textBoxCambio;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.ComboBox comboBoxFormaPago;
        private System.Windows.Forms.Label labelFormaPago;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCantidadAlmacen;
        private System.Windows.Forms.ComboBox comboBoxTipoFactura;
        private System.Windows.Forms.Label labelTipoFactura;
        private System.Windows.Forms.Button buttonCompletarFactura;
        private System.Windows.Forms.Button button2;
    }
}

