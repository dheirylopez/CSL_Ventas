namespace CSL_Ventas.Win
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFormEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFormClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFormProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFormCompania = new System.Windows.Forms.ToolStripMenuItem();
            this.SubSubMenuFormCompania = new System.Windows.Forms.ToolStripMenuItem();
            this.SubSubMenuFormSucursal = new System.Windows.Forms.ToolStripMenuItem();
            this.SubSubMenuFormComprobanteFiscal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFormFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.SubSubMenuFormFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.SubSubMenuFormHistoricoFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFormCotizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.SubSubMenuFormCotizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.SubSubMenuFormHistoricoCotizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFormConduce = new System.Windows.Forms.ToolStripMenuItem();
            this.SubSubMenuFormConduce = new System.Windows.Forms.ToolStripMenuItem();
            this.SubSubMenuFormHistoricoConduce = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFormArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFormIngresoAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFormInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuReporteVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuReporteGananciaPerdida = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMantenimiento,
            this.MenuOperaciones,
            this.MenuAlmacen,
            this.MenuReporte});
            this.menuStrip1.Location = new System.Drawing.Point(5, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuMantenimiento
            // 
            this.MenuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuFormEmpleados,
            this.SubMenuFormClientes,
            this.SubMenuFormProveedores,
            this.SubMenuFormCompania});
            this.MenuMantenimiento.Enabled = false;
            this.MenuMantenimiento.Name = "MenuMantenimiento";
            this.MenuMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.MenuMantenimiento.Text = "Mantenimiento";
            // 
            // SubMenuFormEmpleados
            // 
            this.SubMenuFormEmpleados.Enabled = false;
            this.SubMenuFormEmpleados.Name = "SubMenuFormEmpleados";
            this.SubMenuFormEmpleados.Size = new System.Drawing.Size(139, 22);
            this.SubMenuFormEmpleados.Text = "Empleados";
            this.SubMenuFormEmpleados.Click += new System.EventHandler(this.SubMenuFormEmpleados_Click);
            // 
            // SubMenuFormClientes
            // 
            this.SubMenuFormClientes.Enabled = false;
            this.SubMenuFormClientes.Name = "SubMenuFormClientes";
            this.SubMenuFormClientes.Size = new System.Drawing.Size(139, 22);
            this.SubMenuFormClientes.Text = "Clientes";
            this.SubMenuFormClientes.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // SubMenuFormProveedores
            // 
            this.SubMenuFormProveedores.Enabled = false;
            this.SubMenuFormProveedores.Name = "SubMenuFormProveedores";
            this.SubMenuFormProveedores.Size = new System.Drawing.Size(139, 22);
            this.SubMenuFormProveedores.Text = "Proveedores";
            this.SubMenuFormProveedores.Click += new System.EventHandler(this.nFCToolStripMenuItem_Click);
            // 
            // SubMenuFormCompania
            // 
            this.SubMenuFormCompania.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubSubMenuFormCompania,
            this.SubSubMenuFormSucursal,
            this.SubSubMenuFormComprobanteFiscal});
            this.SubMenuFormCompania.Enabled = false;
            this.SubMenuFormCompania.Name = "SubMenuFormCompania";
            this.SubMenuFormCompania.Size = new System.Drawing.Size(139, 22);
            this.SubMenuFormCompania.Text = "Compañias";
            // 
            // SubSubMenuFormCompania
            // 
            this.SubSubMenuFormCompania.Enabled = false;
            this.SubSubMenuFormCompania.Name = "SubSubMenuFormCompania";
            this.SubSubMenuFormCompania.Size = new System.Drawing.Size(180, 22);
            this.SubSubMenuFormCompania.Text = "Compañia";
            this.SubSubMenuFormCompania.Click += new System.EventHandler(this.SubSubMenuFormCompania_Click);
            // 
            // SubSubMenuFormSucursal
            // 
            this.SubSubMenuFormSucursal.Enabled = false;
            this.SubSubMenuFormSucursal.Name = "SubSubMenuFormSucursal";
            this.SubSubMenuFormSucursal.Size = new System.Drawing.Size(180, 22);
            this.SubSubMenuFormSucursal.Text = "Sucursal";
            // 
            // SubSubMenuFormComprobanteFiscal
            // 
            this.SubSubMenuFormComprobanteFiscal.Enabled = false;
            this.SubSubMenuFormComprobanteFiscal.Name = "SubSubMenuFormComprobanteFiscal";
            this.SubSubMenuFormComprobanteFiscal.Size = new System.Drawing.Size(180, 22);
            this.SubSubMenuFormComprobanteFiscal.Text = "Comprobante Fiscal";
            this.SubSubMenuFormComprobanteFiscal.Click += new System.EventHandler(this.nFCToolStripMenuItem1_Click);
            // 
            // MenuOperaciones
            // 
            this.MenuOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuFormFacturacion,
            this.SubMenuFormCotizacion,
            this.SubMenuFormConduce});
            this.MenuOperaciones.Enabled = false;
            this.MenuOperaciones.Name = "MenuOperaciones";
            this.MenuOperaciones.Size = new System.Drawing.Size(85, 20);
            this.MenuOperaciones.Text = "Operaciones";
            // 
            // SubMenuFormFacturacion
            // 
            this.SubMenuFormFacturacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubSubMenuFormFacturacion,
            this.SubSubMenuFormHistoricoFacturacion});
            this.SubMenuFormFacturacion.Enabled = false;
            this.SubMenuFormFacturacion.Name = "SubMenuFormFacturacion";
            this.SubMenuFormFacturacion.Size = new System.Drawing.Size(136, 22);
            this.SubMenuFormFacturacion.Text = "Facturación";
            // 
            // SubSubMenuFormFacturacion
            // 
            this.SubSubMenuFormFacturacion.Enabled = false;
            this.SubSubMenuFormFacturacion.Name = "SubSubMenuFormFacturacion";
            this.SubSubMenuFormFacturacion.Size = new System.Drawing.Size(187, 22);
            this.SubSubMenuFormFacturacion.Text = "Facturación";
            this.SubSubMenuFormFacturacion.Click += new System.EventHandler(this.SubSubMenuFormFacturacion_Click);
            // 
            // SubSubMenuFormHistoricoFacturacion
            // 
            this.SubSubMenuFormHistoricoFacturacion.Enabled = false;
            this.SubSubMenuFormHistoricoFacturacion.Name = "SubSubMenuFormHistoricoFacturacion";
            this.SubSubMenuFormHistoricoFacturacion.Size = new System.Drawing.Size(187, 22);
            this.SubSubMenuFormHistoricoFacturacion.Text = "Histórico Facturación";
            this.SubSubMenuFormHistoricoFacturacion.Click += new System.EventHandler(this.SubSubMenuFormHistoricoFacturacion_Click);
            // 
            // SubMenuFormCotizacion
            // 
            this.SubMenuFormCotizacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubSubMenuFormCotizacion,
            this.SubSubMenuFormHistoricoCotizacion});
            this.SubMenuFormCotizacion.Enabled = false;
            this.SubMenuFormCotizacion.Name = "SubMenuFormCotizacion";
            this.SubMenuFormCotizacion.Size = new System.Drawing.Size(136, 22);
            this.SubMenuFormCotizacion.Text = "Cotización";
            // 
            // SubSubMenuFormCotizacion
            // 
            this.SubSubMenuFormCotizacion.Enabled = false;
            this.SubSubMenuFormCotizacion.Name = "SubSubMenuFormCotizacion";
            this.SubSubMenuFormCotizacion.Size = new System.Drawing.Size(181, 22);
            this.SubSubMenuFormCotizacion.Text = "Cotización";
            this.SubSubMenuFormCotizacion.Click += new System.EventHandler(this.SubSubMenuFormCotizacion_Click);
            // 
            // SubSubMenuFormHistoricoCotizacion
            // 
            this.SubSubMenuFormHistoricoCotizacion.Enabled = false;
            this.SubSubMenuFormHistoricoCotizacion.Name = "SubSubMenuFormHistoricoCotizacion";
            this.SubSubMenuFormHistoricoCotizacion.Size = new System.Drawing.Size(181, 22);
            this.SubSubMenuFormHistoricoCotizacion.Text = "Histórico Cotización";
            this.SubSubMenuFormHistoricoCotizacion.Click += new System.EventHandler(this.SubSubMenuFormHistoricoCotizacion_Click);
            // 
            // SubMenuFormConduce
            // 
            this.SubMenuFormConduce.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubSubMenuFormConduce,
            this.SubSubMenuFormHistoricoConduce});
            this.SubMenuFormConduce.Enabled = false;
            this.SubMenuFormConduce.Name = "SubMenuFormConduce";
            this.SubMenuFormConduce.Size = new System.Drawing.Size(136, 22);
            this.SubMenuFormConduce.Text = "Conduce";
            this.SubMenuFormConduce.Click += new System.EventHandler(this.conduceToolStripMenuItem_Click);
            // 
            // SubSubMenuFormConduce
            // 
            this.SubSubMenuFormConduce.Enabled = false;
            this.SubSubMenuFormConduce.Name = "SubSubMenuFormConduce";
            this.SubSubMenuFormConduce.Size = new System.Drawing.Size(173, 22);
            this.SubSubMenuFormConduce.Text = "Conduce";
            this.SubSubMenuFormConduce.Click += new System.EventHandler(this.SubSubMenuFormConduce_Click);
            // 
            // SubSubMenuFormHistoricoConduce
            // 
            this.SubSubMenuFormHistoricoConduce.Enabled = false;
            this.SubSubMenuFormHistoricoConduce.Name = "SubSubMenuFormHistoricoConduce";
            this.SubSubMenuFormHistoricoConduce.Size = new System.Drawing.Size(173, 22);
            this.SubSubMenuFormHistoricoConduce.Text = "Histórico Conduce";
            this.SubSubMenuFormHistoricoConduce.Click += new System.EventHandler(this.SubSubMenuFormHistoricoConduce_Click);
            // 
            // MenuAlmacen
            // 
            this.MenuAlmacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuFormArticulo,
            this.SubMenuFormIngresoAlmacen,
            this.SubMenuFormInventario});
            this.MenuAlmacen.Enabled = false;
            this.MenuAlmacen.Name = "MenuAlmacen";
            this.MenuAlmacen.Size = new System.Drawing.Size(66, 20);
            this.MenuAlmacen.Text = "Almacén";
            // 
            // SubMenuFormArticulo
            // 
            this.SubMenuFormArticulo.Enabled = false;
            this.SubMenuFormArticulo.Name = "SubMenuFormArticulo";
            this.SubMenuFormArticulo.Size = new System.Drawing.Size(163, 22);
            this.SubMenuFormArticulo.Text = "Agregar artículo";
            this.SubMenuFormArticulo.Click += new System.EventHandler(this.agregarArtículoToolStripMenuItem_Click);
            // 
            // SubMenuFormIngresoAlmacen
            // 
            this.SubMenuFormIngresoAlmacen.Enabled = false;
            this.SubMenuFormIngresoAlmacen.Name = "SubMenuFormIngresoAlmacen";
            this.SubMenuFormIngresoAlmacen.Size = new System.Drawing.Size(163, 22);
            this.SubMenuFormIngresoAlmacen.Text = "Ingreso Almacén";
            this.SubMenuFormIngresoAlmacen.Click += new System.EventHandler(this.ingresoAlmacénToolStripMenuItem_Click);
            // 
            // SubMenuFormInventario
            // 
            this.SubMenuFormInventario.Enabled = false;
            this.SubMenuFormInventario.Name = "SubMenuFormInventario";
            this.SubMenuFormInventario.Size = new System.Drawing.Size(163, 22);
            this.SubMenuFormInventario.Text = "Inventario";
            this.SubMenuFormInventario.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // MenuReporte
            // 
            this.MenuReporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuReporteVenta,
            this.SubMenuReporteGananciaPerdida});
            this.MenuReporte.Enabled = false;
            this.MenuReporte.Name = "MenuReporte";
            this.MenuReporte.Size = new System.Drawing.Size(65, 20);
            this.MenuReporte.Text = "Reportes";
            // 
            // SubMenuReporteVenta
            // 
            this.SubMenuReporteVenta.Enabled = false;
            this.SubMenuReporteVenta.Name = "SubMenuReporteVenta";
            this.SubMenuReporteVenta.Size = new System.Drawing.Size(229, 22);
            this.SubMenuReporteVenta.Text = "Reporte de Venta";
            this.SubMenuReporteVenta.Click += new System.EventHandler(this.reportesDeVentasToolStripMenuItem_Click);
            // 
            // SubMenuReporteGananciaPerdida
            // 
            this.SubMenuReporteGananciaPerdida.Enabled = false;
            this.SubMenuReporteGananciaPerdida.Name = "SubMenuReporteGananciaPerdida";
            this.SubMenuReporteGananciaPerdida.Size = new System.Drawing.Size(229, 22);
            this.SubMenuReporteGananciaPerdida.Text = "Reporte Ganancias y Perdidas";
            this.SubMenuReporteGananciaPerdida.Click += new System.EventHandler(this.SubMenuReporteGananciaPerdida_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFormEmpleados;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFormClientes;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFormProveedores;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFormCompania;
        private System.Windows.Forms.ToolStripMenuItem SubSubMenuFormCompania;
        private System.Windows.Forms.ToolStripMenuItem SubSubMenuFormSucursal;
        private System.Windows.Forms.ToolStripMenuItem SubSubMenuFormComprobanteFiscal;
        private System.Windows.Forms.ToolStripMenuItem MenuOperaciones;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFormFacturacion;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFormCotizacion;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFormConduce;
        private System.Windows.Forms.ToolStripMenuItem MenuAlmacen;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFormArticulo;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFormIngresoAlmacen;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFormInventario;
        private System.Windows.Forms.ToolStripMenuItem MenuReporte;
        private System.Windows.Forms.ToolStripMenuItem SubMenuReporteVenta;
        private System.Windows.Forms.ToolStripMenuItem SubMenuReporteGananciaPerdida;
        private System.Windows.Forms.ToolStripMenuItem SubSubMenuFormFacturacion;
        private System.Windows.Forms.ToolStripMenuItem SubSubMenuFormHistoricoFacturacion;
        private System.Windows.Forms.ToolStripMenuItem SubSubMenuFormCotizacion;
        private System.Windows.Forms.ToolStripMenuItem SubSubMenuFormHistoricoCotizacion;
        private System.Windows.Forms.ToolStripMenuItem SubSubMenuFormConduce;
        private System.Windows.Forms.ToolStripMenuItem SubSubMenuFormHistoricoConduce;
    }
}



