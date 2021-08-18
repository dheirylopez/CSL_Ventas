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
    public partial class FormCotizacion : DevComponents.DotNetBar.Office2007Form, IContract
    {
        public FormCotizacion()
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
        private Clientes _cliente;
        public Clientes clienteSelec
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        private static FormCotizacion frmInstance = null;
        public static FormCotizacion Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormCotizacion();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        int idCt = 0;
        List<DetalleCotizacionGrid> _Cotizacion;
        double subtotal;
        double itebistotal;
        double total;
        double _subtotalDes;
        double _itebistotalDes;
        double _totalDes;

        double descuento;
        Entidad.Almacen _itemalmacen;
        ICotizacionServices _presenter = new CotizacionServices();
        int articulo;
        private void toolStripButtonAgregar_Click(object sender, EventArgs e)
        {
            var items = new DetalleCotizacionGrid();

            if (textBoxCantidad.Text != string.Empty && textBoxPrecio.Text != string.Empty)
            {
                items.Articulo = _inventario.Articulo;
                items.IdArticulo = _inventario.IdArticulo;
                if (textBoxItebis.Visible == false)
                {
                    items.Cantidad = Convert.ToInt32(textBoxCantidad.Text);

                    items.PrecioU = Convert.ToInt32(textBoxPrecio.Text);
                    items.Itebis = 0;
                    subtotal = ((items.PrecioU * items.Cantidad)) + subtotal;
                    textBoxSubTotal.Text = subtotal.ToString();
                    itebistotal = 0;
                }
                else
                {

                    items.Cantidad = Convert.ToInt32(textBoxCantidad.Text);
                    items.PrecioU = Convert.ToInt32(textBoxPrecio.Text);
                    items.Itebis = (items.PrecioU * 0.18) * items.Cantidad;
                    subtotal = ((items.PrecioU * items.Cantidad)) + subtotal;
                    textBoxSubTotal.Text = subtotal.ToString();
                    itebistotal = items.Itebis + itebistotal;
                    textBoxItebis.Text = itebistotal.ToString();
                }

                total = (subtotal + itebistotal) - descuento;
                textBoxTotal.Text = total.ToString();
                _Cotizacion.Add(items);
                dataGridViewCotizacion.DataSource = _Cotizacion.ToList();
                Limpiar();
            }
            else
            {
                MessageBox.Show("debe seleccionar un articulo y colocarle una cantidad");
            }
        }
        void Limpiar()
        {
            textBoxCantidad.Text = string.Empty;
            textBoxPrecio.Text = string.Empty;
            textBoxArticulo.Text = string.Empty;
            labelCantidadAlmacen.Text = "Cantidad en Almacen:";
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
            else if (checkBoxEstatusItebis.Checked == true)
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



        private void FormCotizacion_Load(object sender, EventArgs e)
        {
            _Cotizacion = new List<DetalleCotizacionGrid>();


            textBoxColaborador.Text = _empleado.Nombre;
        }

        private void toolStripButtonQuitar_Click(object sender, EventArgs e)
        {
            var grid = dataGridViewCotizacion.SelectedRows[0].Index;
            if (textBoxItebis.Visible == false)
            {
                var cantidad = Convert.ToInt32(dataGridViewCotizacion.SelectedRows[0].Cells[2].Value.ToString());
                var preciou = Convert.ToInt32(dataGridViewCotizacion.SelectedRows[0].Cells[3].Value.ToString());
                var itebi = Convert.ToDecimal(dataGridViewCotizacion.SelectedRows[0].Cells[4].Value.ToString());
                var _subtotal = cantidad * preciou;

                subtotal = subtotal - _subtotal;
                itebistotal = 0;
                total = (subtotal + itebistotal) - descuento;
                textBoxSubTotal.Text = subtotal.ToString();
                textBoxItebis.Text = itebistotal.ToString();
                textBoxTotal.Text = total.ToString();

            }
            else
            {
                var cantidad = Convert.ToInt32(dataGridViewCotizacion.SelectedRows[0].Cells[2].Value.ToString());
                var preciou = Convert.ToInt32(dataGridViewCotizacion.SelectedRows[0].Cells[3].Value.ToString());
                var itebi = Convert.ToDecimal(dataGridViewCotizacion.SelectedRows[0].Cells[4].Value.ToString());
                var _subtotal = cantidad * preciou;
                var _itebis = (preciou * 0.18) * cantidad;
                subtotal = subtotal - _subtotal;
                itebistotal = itebistotal - _itebis;
                total = (subtotal + itebistotal) - descuento;
                textBoxSubTotal.Text = subtotal.ToString();
                textBoxItebis.Text = itebistotal.ToString();
                textBoxTotal.Text = total.ToString();
            }
            _Cotizacion.RemoveAt(grid);
            if (_Cotizacion.Count() > 0)
            {
                dataGridViewCotizacion.DataSource = _Cotizacion;
            }
            else
            {
                dataGridViewCotizacion.DataSource = null;
            }

        }

        private void checkBoxEstatusItebis_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEstatusItebis.Checked == true)
            {
                labelItebis.Visible = false;
                textBoxItebis.Visible = false;
            }
            else
            {
                labelItebis.Visible = true;
                textBoxItebis.Visible = true;
            }

        }


        void LimpiarFinalizarF()
        {
            textBoxCantidad.Text = string.Empty;
            textBoxPrecio.Text = string.Empty;
            dataGridViewCotizacion.DataSource = null;
            textBoxObservacion.Text = string.Empty;
            textBoxDescuento.Text = string.Empty;
            textBoxTotal.Text = string.Empty;
            textBoxSubTotal.Text = string.Empty;
            textBoxItebis.Text = string.Empty;
            textBoxCliente.Text = string.Empty;
            checkBoxEstatusItebis.Checked = false;

            subtotal = 0;
            itebistotal = 0;
            total = 0;
            descuento = 0;
            textBoxArticulo.Text = string.Empty;
            labelCantidadAlmacen.Text = "Cantidad en Almacen:";
            _Cotizacion = new List<DetalleCotizacionGrid>();

        }
        private void toolStripButtonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFinalizarF();
        }
        Cotizacion entidadcotizacion()
        {
            var entidad = new Cotizacion();
            if (descuento > 0)
            {
                subtotal = _subtotalDes;
                itebistotal = _itebistotalDes;
                total = _totalDes;
            }
            entidad.Descuento = Convert.ToInt32(Math.Round(descuento));
            entidad.Fecha = DateTime.Now;
            entidad.IdCliente = _cliente.Id;
            entidad.IdEmpleado = _empleado.Id;
            entidad.Itebis = Convert.ToInt32(Math.Round(itebistotal));
            entidad.SubTotal = Convert.ToInt32(Math.Round(subtotal));
            entidad.Total = Convert.ToInt32(Math.Round(total));

            entidad.Observacion = textBoxObservacion.Text;
            entidad.Estatus = 1;
            return entidad;
        }
        IEnumerable<DetalleCotizacion> EntidadDetalleCotizacion(int idFactura)
        {

            var entidadLista = new List<DetalleCotizacion>();
            foreach (var item in _Cotizacion)
            {
                var entidad = new DetalleCotizacion();
                entidad.IdArticulo = item.IdArticulo;
                entidad.IdCotizacion = idFactura;
                entidad.PrecioU = item.PrecioU;
                entidad.Cantidad = item.Cantidad;
                entidad.Itebi = (float)item.Itebis;
                entidadLista.Add(entidad);

            }
            return entidadLista;

        }
        private void toolStripButtonImpimir_Click(object sender, EventArgs e)
        {
            try
            {
                var cotizacionEnti = entidadcotizacion();
                _presenter.Add(cotizacionEnti);

                var idcotizacion = _presenter.GetId();
                var detalle = EntidadDetalleCotizacion(idcotizacion.Id);
                foreach (var item in detalle)
                {
                    _presenter.AddDetalle(item);

                }

                FormCotizacionBolante frm = new FormCotizacionBolante();
                idCt = idcotizacion.Id;
                frm.id = idCt;
                frm.ShowDialog();
                LimpiarFinalizarF();


            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Ocurrio un error comunicarse con el probeedor del sistema:{0}", ex.ToString()));
            }
        }

        private void toolStripButtonAyuda_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "D:/CreateSoftLopez/CreateSoft_Ventas -Manual de Usuario.pdf");
            Process.Start(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInventarioFacturacion inv = new FormInventarioFacturacion();
            inv.contrato = this;
            inv.Show();
        }

        public void Ejecutar(Inventario informacion)
        {
            _inventario = informacion;

            textBoxArticulo.Text = _inventario.Articulo;
            labelCantidadAlmacen.Text = string.Format("Cantidad en Almacen: {0} ", _inventario.Cantidad);
            textBoxPrecio.Text = _inventario.PrecioV.ToString();
        }



        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPrecio.Text != string.Empty)
            {
                var precioventa = Convert.ToDouble(textBoxPrecio.Text);
                if (precioventa < Convert.ToInt32(_inventario.PrecioC))
                {
                    MessageBox.Show("El precio que desea colocar no puede procesarse para este articulo");
                    textBoxPrecio.Text = _inventario.PrecioV.ToString();
                }
                else
                {
                    textBoxPrecio.Text = precioventa.ToString();
                }
            }
        }
        public void Ejecutar(Clientes informacion)
        {
            _cliente = informacion;

            textBoxCliente.Text = _cliente.Nombre;

        }
        public void Ejecutar(Items informacion)
        {
            throw new NotImplementedException();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            FormClientesFactura clin = new FormClientesFactura();
            clin.contrato = this;
            clin.Show();
        }
    }
}
