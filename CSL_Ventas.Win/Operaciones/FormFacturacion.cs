using CSL_Ventas.Win.Almacen;
using CSL_Ventas.Win.Operaciones.ReportesBolantes;
using Entidad;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSL_Ventas.Win.Operaciones
{
    public partial class FormFacturacion : DevComponents.DotNetBar.Office2007Form, IContract
    {
        public FormFacturacion()
        {

            InitializeComponent();

        }
        private Empleados _empleado;
        public Empleados empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        private Inventario _inventario;
        public Inventario inventario
        {
            get { return _inventario; }
            set { _inventario = value; }
        }

        private caja _caja;
        public caja caja
        {
            get { return _caja; }
            set { _caja = value; }
        }
        private Clientes _cliente;
        public Clientes clienteSelec
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        IFacturaServices _presenter = new FacturaServices();

        private static FormFacturacion frmInstance = null;
        public static FormFacturacion Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormFacturacion();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        int idft = 0;
        List<DetalleFacturaGrid> _factura;
        double subtotal;
        double itebistotal;
        double total;
        double _subtotalDes;
        double _itebistotalDes;
        double _totalDes;
        double descuento;
        Entidad.Almacen _itemalmacen;
        NCF _nfc;
        int articulo;

        private void Form1_Load(object sender, EventArgs e)
        {
            _factura = new List<DetalleFacturaGrid>();
            comboBoxColaborador.DataSource = _presenter.GetEmpleados();
            comboBoxColaborador.DisplayMember = "Nombre";
            comboBoxColaborador.ValueMember = "Id";
        }
        void Limpiar()
        {
            textBoxCantidad.Text = string.Empty;
            textBoxPrecio.Text = string.Empty;
            textBoxArticulo.Text = string.Empty;
            labelCantidadAlmacen.Text = "Cantidad en Almacen:";
        }
        void LimpiarFinalizarF()
        {
            textBoxCantidad.Text = string.Empty;
            textBoxPrecio.Text = string.Empty;
            dataGridViewFacturacion.DataSource = null;
            textBoxObservacion.Text = string.Empty;
            textBoxEfectivo.Text = string.Empty;
            textBoxCambio.Text = string.Empty;
            textBoxPagoInicial.Text = string.Empty;
            textBoxPagoPendiente.Text = string.Empty;
            textBoxDescuento.Text = string.Empty;
            textBoxTotal.Text = string.Empty;
            textBoxSubTotal.Text = string.Empty;
            textBoxItebis.Text = string.Empty;
            comboBoxTipoNCF.SelectedIndex = 0;
            textBoxNCF.Text = string.Empty;
            textBoxCliente.Text = string.Empty;
            textBoxIDCotizacion.Text = string.Empty;
            comboBoxFormaPago.Text = string.Empty;
            textBoxArticulo.Text = string.Empty;
            textBoxPagoPendiente.Text = string.Empty;
            subtotal = 0;
            itebistotal = 0;
            total = 0;
            descuento = 0;
            labelCantidadAlmacen.Text = "Cantidad en Almacen:";
            _factura = new List<DetalleFacturaGrid>();

        }
        private void toolStripButtonAgregar_Click(object sender, EventArgs e)
        {
            var validacionCierre = _presenter.GetIdCierre(DateTime.Now.Date);
            
            if ( validacionCierre != null  )
            {
                if (validacionCierre.Estatus != 0 )
                {

               
                MessageBox.Show("Se efectuó el cierre debe aperturar para poder agregar una nueva factura. Nota: No es una buena práctica después del cierre aperturar el Cierre.");
                }
            }
            else
            {
                var items = new DetalleFacturaGrid();

                if (textBoxPrecio.Text != string.Empty)
                {
                    var precioventa = Convert.ToDouble(textBoxPrecio.Text);
                    if (precioventa < Convert.ToInt32(_inventario.PrecioC))
                    {
                        MessageBox.Show("El precio que desea es menor al precio de elaboracion del articulo.");
                        textBoxPrecio.Text = _inventario.PrecioV.ToString();
                    }
                    else
                    {
                        textBoxPrecio.Text = precioventa.ToString();

                        if (comboBoxTipoNCF.Text == "Factura Proforma")
                        {
                            if (textBoxCantidad.Text != string.Empty && textBoxPrecio.Text != string.Empty && inventario != null)
                            {

                                items.IdArticulo = inventario.IdArticulo;
                                items.Articulo = inventario.Articulo;
                                items.Cantidad = Convert.ToInt32(textBoxCantidad.Text);
                                items.PrecioU = Convert.ToDouble(textBoxPrecio.Text);
                                items.Itebis = 0;
                                subtotal = ((items.PrecioU * items.Cantidad)) + subtotal;
                                textBoxSubTotal.Text = subtotal.ToString();
                                itebistotal = 0;
                                textBoxItebis.Text = itebistotal.ToString();
                                total = (subtotal + itebistotal) - descuento;
                                textBoxTotal.Text = total.ToString();
                                _factura.Add(items);
                                dataGridViewFacturacion.DataSource = _factura.ToList();
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("debe seleccionar un articulo y colocarle una cantidad");
                            }
                        }
                        else
                        {
                            if (textBoxCantidad.Text != string.Empty && textBoxPrecio.Text != string.Empty && inventario != null)
                            {
                                items.IdArticulo = inventario.IdArticulo;
                                items.Articulo = inventario.Articulo;
                                items.Cantidad = Convert.ToInt32(textBoxCantidad.Text);
                                items.PrecioU = Convert.ToDouble(textBoxPrecio.Text);
                                items.Itebis = (items.PrecioU * 0.18) * items.Cantidad;
                                subtotal = ((items.PrecioU * items.Cantidad)) + subtotal;
                                textBoxSubTotal.Text = subtotal.ToString();
                                itebistotal = items.Itebis + itebistotal;
                                textBoxItebis.Text = itebistotal.ToString();
                                total = (subtotal + itebistotal) - descuento;
                                textBoxTotal.Text = total.ToString();
                                _factura.Add(items);
                                dataGridViewFacturacion.DataSource = _factura.ToList();
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("debe seleccionar un articulo y colocarle una cantidad");
                            }
                        }

                    }
                }

            }

        }


        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {



        }

        private void buttonBuscarCotizacion_Click(object sender, EventArgs e)
        {
            var id = textBoxIDCotizacion.Text;
            var cotizacion = _presenter.GetNombreId(id);
            var detalleCotizacion = _presenter.GetDetalleNombreId(id);

            textBoxCliente.Text = _cliente.Nombre;
            textBoxObservacion.Text = cotizacion.Observacion;

            foreach (var item in detalleCotizacion)
            {
                var items = new DetalleFacturaGrid();

                items.IdArticulo = item.IdArticulo;
                var articulo = _presenter.GetItem(item.IdArticulo);
                items.Articulo = articulo.Nombre;
                _itemalmacen = _presenter.GetItemAlmacen(item.IdArticulo);
                var cantidad = Convert.ToInt32(item.Cantidad);
                if (cantidad > _itemalmacen.Cantidad)
                {
                    items.Cantidad = _itemalmacen.Cantidad;
                }
                else
                {
                    items.Cantidad = item.Cantidad;
                }
                if (items.Cantidad == 0)
                {
                    items.PrecioU = 0;
                }
                else
                {
                    items.PrecioU = item.PrecioU;
                }

                items.Itebis = (item.PrecioU * 0.18) * items.Cantidad;
                subtotal = ((items.PrecioU * items.Cantidad)) + subtotal;
                textBoxSubTotal.Text = subtotal.ToString();
                itebistotal = items.Itebis + itebistotal;
                textBoxItebis.Text = itebistotal.ToString();
                total = (subtotal + itebistotal) - descuento;
                textBoxTotal.Text = total.ToString();
                _factura.Add(items);
                dataGridViewFacturacion.DataSource = _factura.ToList();
            }

            MessageBox.Show("Verifique la factura, cada articulo y su cantidad pueden haberse reducido. Debe Colocar el descuento.");

        }
        Factura entidadFactura()
        {
            var entidad = new Factura();
            if (descuento > 0)
            {
                subtotal = _subtotalDes;
                itebistotal = _itebistotalDes;
                total = _totalDes;
            }
            entidad.Descuento = Convert.ToInt32(descuento);
            entidad.Fecha = Convert.ToDateTime(DateTime.Now.Date.ToString("yyy/MM/dd"));
            entidad.IdCliente = _cliente.Id;
            entidad.IdEmpleado = Convert.ToInt32(comboBoxColaborador.SelectedValue);
            entidad.Itebis = itebistotal;
            entidad.SubTotal =subtotal;
            entidad.Total = total;
            entidad.NCF = textBoxNCF.Text;
            entidad.Observacion = textBoxObservacion.Text;
            entidad.Estatus = 1;
            entidad.Tipo_NCF = comboBoxTipoNCF.Text;
            entidad.Forma_Pago = comboBoxFormaPago.Text;
            entidad.Tipo_Factura = comboBoxTipoFactura.Text;
            entidad.Pago_Inicial = 0;
            entidad.Pago_Pendiente = 0;
            entidad.MontoPagado = 0;
            entidad.Cambio = 0;
            if (textBoxPagoInicial.Text != string.Empty && textBoxPagoPendiente.Text != string.Empty)
            {
                entidad.Pago_Inicial = Convert.ToDouble(textBoxPagoInicial.Text);
                entidad.Pago_Pendiente = Convert.ToDouble(textBoxPagoPendiente.Text);

            }
            else if (textBoxEfectivo.Text != string.Empty && textBoxCambio.Text != string.Empty)
            {
                entidad.MontoPagado = Convert.ToDouble(textBoxEfectivo.Text);
                entidad.Cambio = Convert.ToDouble(textBoxCambio.Text);

            }


            return entidad;
        }
        IEnumerable<DetalleFactura> EntidadDetalleFactua(int idFactura)
        {

            var entidadLista = new List<DetalleFactura>();
            foreach (var item in _factura)
            {
                var entidad = new DetalleFactura();
                entidad.IdArticulo = item.IdArticulo;
                entidad.IdFactura = idFactura;
                entidad.PrecioU = (float)item.PrecioU;
                entidad.Cantidad = item.Cantidad;
                entidad.Itebi = (float)item.Itebis;
                entidadLista.Add(entidad);

            }
            return entidadLista;

        }
        NCF ActualizarNCF(NCF item)
        {
            var entidad = new NCF();
            entidad.Codigo = item.Codigo;
            entidad.Estatus = 0;
            entidad.FechaEmision = item.FechaEmision;
            entidad.FechaUso = DateTime.Now;
            entidad.FechaVencimiento = item.FechaVencimiento;
            entidad.id = item.id;
            entidad.Tipo = item.Tipo;

            return entidad;
        }
        Entidad.Almacen ActualizarAlmacen(Entidad.Almacen item, int canti)
        {
            var entidad = new Entidad.Almacen();
            entidad.Id = item.Id;
            entidad.IdItems = item.IdItems;
            entidad.IdProveedor = item.IdProveedor;
            entidad.IdUsuario = item.IdUsuario;
            entidad.PrecioC = item.PrecioC;
            entidad.PrecioV = item.PrecioV;
            entidad.Cantidad = item.Cantidad - canti;
            entidad.Fecha = item.Fecha;
            return entidad;
        }
        private void toolStripButtonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTipoNCF.Text == "Factura Proforma")
                {
                    if (_cliente != null && comboBoxTipoNCF.SelectedIndex > 0)
                    {
                        var facturaEnti = entidadFactura();
                        _presenter.Add(facturaEnti);

                        var idfactura = _presenter.GetId();
                        var detalle = EntidadDetalleFactua(idfactura.Id);
                        foreach (var item in detalle)
                        {
                            _presenter.AddDetalle(item);
                            _itemalmacen = _presenter.GetItemAlmacen(item.IdArticulo);
                            var entidadAlmacen = ActualizarAlmacen(_itemalmacen, item.Cantidad);
                            _presenter.UpdateAlmacen(entidadAlmacen);
                            var conbo = _presenter.GetDetalleItems(_itemalmacen.IdItems);
                            if (conbo != null)
                            {
                                foreach (var itemcombo in conbo)
                                {
                                    _itemalmacen = _presenter.GetItemAlmacen(itemcombo.IdArticulo);
                                    var entidadAlmacenComb = ActualizarAlmacen(_itemalmacen, itemcombo.Cantidad);
                                    _presenter.UpdateAlmacen(entidadAlmacenComb);
                                }
                            }

                        }

                        FormFacturaProforma frm = new FormFacturaProforma();
                        idft = idfactura.Id;
                        frm.id = idft;
                        frm.ShowDialog();
                        LimpiarFinalizarF();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("debe seleccionar el tipo de Comprobante fiscal y el cliente al que le realizara la factura"));
                    }

                }
                else
                {
                    if (_cliente != null && comboBoxTipoNCF.SelectedIndex > 0)
                    {
                        var facturaEnti = entidadFactura();
                        _presenter.Add(facturaEnti);
                        var entidadNCF = ActualizarNCF(_presenter.GetNCF(_nfc.id.ToString()));
                        _presenter.UpdateNCF(entidadNCF);
                        var idfactura = _presenter.GetId();
                        var detalle = EntidadDetalleFactua(idfactura.Id);
                        foreach (var item in detalle)
                        {
                            _presenter.AddDetalle(item);
                            _itemalmacen = _presenter.GetItemAlmacen(item.IdArticulo);
                            var entidadAlmacen = ActualizarAlmacen(_itemalmacen, item.Cantidad);
                            _presenter.UpdateAlmacen(entidadAlmacen);
                            var combo = _presenter.GetDetalleItems(_itemalmacen.IdItems);
                            if (combo != null)
                            {
                                foreach (var itemcombo in combo)
                                {
                                    _itemalmacen = _presenter.GetItemAlmacen(itemcombo.IdArticulo);
                                    var entidadAlmacenComb = ActualizarAlmacen(_itemalmacen, itemcombo.Cantidad);
                                    _presenter.UpdateAlmacen(entidadAlmacenComb);
                                }
                            }

                        }

                        FormFactura frm = new FormFactura();
                        idft = idfactura.Id;
                        frm.id = idft;
                        frm.ShowDialog();
                        LimpiarFinalizarF();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("debe seleccionar el tipo de Comprobante fiscal y el cliente al que le realizara la factura"));
                    }


                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Ocurrio un error comunicarse con el probeedor del sistema:{0}", ex.ToString()));
            }

        }

        private void toolStripButtonAnular_Click(object sender, EventArgs e)
        {
            var id = _presenter.GetId();
            var msj = MessageBox.Show(string.Format("Desera anular la factura con el numero {0}", id.Id), "Informacion", MessageBoxButtons.YesNo);
            if (msj == DialogResult.Yes)
            {
                var factura = _presenter.GetNombreIdFactura(id.Id.ToString());

                factura.Id = id.Id;
                factura.Estatus = 0;
                _presenter.Update(factura);
                var ncf = _presenter.GetNCFCodigo(factura.NCF);
                var entidadNCF = ActualizarNCF(ncf);
                entidadNCF.Estatus = 1;
                _presenter.UpdateNCF(entidadNCF);
                _nfc = _presenter.GetNCFCodigo(factura.NCF);

                if (_nfc != null)
                {
                    textBoxNCF.Text = _nfc.Codigo;
                }
                else
                {
                    MessageBox.Show("No tien NCF disponible proceda a agregar mas para poder facturar.");

                }
            }
            else
            {

            }

        }

        private void textBoxDescuento_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDescuento.Text == string.Empty)
            {
                textBoxDescuento.Text = "0";
                textBoxSubTotal.Text = subtotal.ToString();
                textBoxItebis.Text = itebistotal.ToString();
                textBoxTotal.Text = total.ToString();
            }
            else if (comboBoxTipoNCF.Text == "Factura Proforma")
            {
                descuento = (Convert.ToDouble(textBoxDescuento.Text) / 100) * subtotal;
                _subtotalDes = subtotal - descuento;

                _totalDes = _subtotalDes;

                textBoxSubTotal.Text = _subtotalDes.ToString();

                textBoxTotal.Text = _totalDes.ToString();
            }
            else
            {

                descuento = (Convert.ToDouble(textBoxDescuento.Text) / 100) * subtotal;
                _subtotalDes = subtotal - descuento;
                _itebistotalDes = _subtotalDes * 0.18;
                _totalDes = _subtotalDes + _itebistotalDes;

                textBoxSubTotal.Text = _subtotalDes.ToString();
                textBoxItebis.Text = _itebistotalDes.ToString();
                textBoxTotal.Text = _totalDes.ToString();
            }

        }

        private void toolStripButtonQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                var grid = dataGridViewFacturacion.SelectedRows[0].Index;
                if (comboBoxTipoNCF.Text == "Factura Proforma")
                {

                    var cantidad = Convert.ToInt32(dataGridViewFacturacion.SelectedRows[0].Cells[2].Value.ToString());
                    var preciou = Convert.ToInt32(dataGridViewFacturacion.SelectedRows[0].Cells[3].Value.ToString());
                    var itebi = Convert.ToDecimal(dataGridViewFacturacion.SelectedRows[0].Cells[4].Value.ToString());
                    var _subtotal = cantidad * preciou;

                    subtotal = subtotal - _subtotal;
                    itebistotal = 0;
                    total = (subtotal + itebistotal) - descuento;
                    textBoxSubTotal.Text = subtotal.ToString();
                    textBoxItebis.Text = itebistotal.ToString();
                    textBoxTotal.Text = total.ToString();
                    _factura.RemoveAt(grid);
                    if (_factura.Count() > 0)
                    {
                        dataGridViewFacturacion.DataSource = _factura;

                    }
                    else
                    {
                        dataGridViewFacturacion.DataSource = null;
                    }
                }
                else
                {

                    var cantidad = Convert.ToInt32(dataGridViewFacturacion.SelectedRows[0].Cells[2].Value.ToString());
                    var preciou = Convert.ToInt32(dataGridViewFacturacion.SelectedRows[0].Cells[3].Value.ToString());
                    var itebi = Convert.ToDecimal(dataGridViewFacturacion.SelectedRows[0].Cells[4].Value.ToString());
                    var _subtotal = cantidad * preciou;
                    var _itebis = (preciou * 0.18) * cantidad;
                    subtotal = subtotal - _subtotal;
                    itebistotal = itebistotal - _itebis;
                    total = (subtotal + itebistotal) - descuento;
                    textBoxSubTotal.Text = subtotal.ToString();
                    textBoxItebis.Text = itebistotal.ToString();
                    textBoxTotal.Text = total.ToString();
                    _factura.RemoveAt(grid);
                    if (_factura.Count() > 0)
                    {
                        dataGridViewFacturacion.DataSource = _factura;

                    }
                    else
                    {
                        dataGridViewFacturacion.DataSource = null;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }


        private void toolStripButtonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFinalizarF();
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text != string.Empty)
            {
                var cantidad = Convert.ToInt32(textBoxCantidad.Text);
                if (cantidad > _inventario.Cantidad)
                {
                    MessageBox.Show("La cantidad que intenta colocar sobrepasa la de almacen.");
                    textBoxCantidad.Text = _inventario.Cantidad.ToString();
                }
                else
                {
                    textBoxCantidad.Text = cantidad.ToString();
                }
            }
        }

        private void comboBoxTipoNCF_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipo = Convert.ToInt32(comboBoxTipoNCF.SelectedIndex);
            if (comboBoxTipoNCF.Text == "Factura Proforma")
            {

            }
            else
            {
                if (tipo > 0)
                {
                    _nfc = _presenter.GetId(1, comboBoxTipoNCF.Text);

                    if (_nfc != null)
                    {
                        textBoxNCF.Text = _nfc.Codigo;
                    }
                    else
                    {
                        MessageBox.Show("No tiene NCF disponible proceda a agregar mas para poder facturar.");

                    }
                }
            }


        }

        private void toolStripButtonRefrescar_Click(object sender, EventArgs e)
        {
            _factura = new List<DetalleFacturaGrid>();


            comboBoxColaborador.DataSource = _presenter.GetEmpleados();
            comboBoxColaborador.DisplayMember = "Nombre";
            comboBoxColaborador.ValueMember = "Id";
        }

        private void toolStripButtonAyuda_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "D:/CreateSoftLopez/CreateSoft_Ventas -Manual de Usuario.pdf");
            Process.Start(path);
        }
        public void Ejecutar(Inventario informacion)
        {
            _inventario = informacion;

            textBoxArticulo.Text = _inventario.Articulo;
            labelCantidadAlmacen.Text = string.Format("Cantidad en Almacen: {0} ", _inventario.Cantidad);
            textBoxPrecio.Text = _inventario.PrecioV.ToString();
        }
        public void Ejecutar(Clientes informacion)
        {
            _cliente = informacion;

            textBoxCliente.Text = _cliente.Nombre;

        }
        private void buttonArticulo_Click(object sender, EventArgs e)
        {
            FormInventarioFacturacion inv = new FormInventarioFacturacion();
            inv.contrato = this;
            inv.Show();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            FormClientesFactura clin = new FormClientesFactura();
            clin.contrato = this;
            clin.Show();
        }

        public void Ejecutar(Items informacion)
        {
            throw new NotImplementedException();
        }

     
        private void textBoxEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPagoInicial.Text != string.Empty && textBoxEfectivo.Text != string.Empty)
                {
                    decimal _cambio;
             
                    _cambio = Convert.ToDecimal(textBoxEfectivo.Text) - Convert.ToDecimal(textBoxPagoInicial.Text);
                    textBoxCambio.Text = Convert.ToDecimal(_cambio).ToString();
                }
                else if (textBoxTotal.Text != string.Empty && textBoxEfectivo.Text != string.Empty)
                {
                    decimal _cambio;
                    _cambio = Convert.ToDecimal(textBoxEfectivo.Text) - Convert.ToDecimal(textBoxTotal.Text);
                    textBoxCambio.Text = Convert.ToDecimal(_cambio).ToString();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void textBoxPagoInicial_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (textBoxTotal.Text != string.Empty && textBoxPagoInicial.Text != string.Empty)
                {
                    decimal _pagpPendiente;
                    _pagpPendiente = Convert.ToDecimal(textBoxTotal.Text) - Convert.ToDecimal(textBoxPagoInicial.Text);
                    textBoxPagoPendiente.Text = Convert.ToString(_pagpPendiente);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonCompletarFactura_Click(object sender, EventArgs e)
        {
            FormCredito credito = new FormCredito();
            credito.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCierreCaja Cierre = new FormCierreCaja();
            Cierre.empleado = empleado;
            Cierre.ShowDialog();
        }
    }
}

