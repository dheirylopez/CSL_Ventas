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

namespace CSL_Ventas.Win
{
    public partial class FormConduce : DevComponents.DotNetBar.Office2007Form
    {
        public FormConduce()
        {
            InitializeComponent();
        }
        IConduceServices _presenter = new ConduceServices();
        List<DetalleConduceGrid> _factura;
        private Empleados _empleado;
        private static FormConduce frmInstance = null;
        public static FormConduce Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormConduce();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        public Empleados empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }
        Entidad.Almacen _itemalmacen;

        private void toolStripButtonQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                var grid = dataGridViewConduce.SelectedRows[0].Index;
                _factura.RemoveAt(grid);
                if (_factura.Count() > 0)
                {
                    dataGridViewConduce.DataSource = _factura.ToList();
                }
                else
                {
                    dataGridViewConduce.DataSource = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Ocurrio un error comunicarse con el probeedor del sistema:{0}", ex.ToString()));
            }

        }

        void LimpiarFinalizarF()
        {

            dataGridViewConduce.DataSource = null;
            textBoxObservacion.Text = string.Empty;

            textBoxIDFactura.Text = string.Empty;
            textBoxCliente.Text = string.Empty;

            _factura = new List<DetalleConduceGrid>();

        }
        private void toolStripButtonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFinalizarF();
        }

        private void FormConduce_Load(object sender, EventArgs e)
        {
            _factura = new List<DetalleConduceGrid>();
            textBoxColaborador.Text = _empleado.Nombre;

        }
        IEnumerable<DetalleConduce> EntidadDetalleConduce(int idconduce)
        {

            var entidadLista = new List<DetalleConduce>();
            foreach (var item in _factura)
            {
                var entidad = new DetalleConduce();
                entidad.IdArticulo = item.IdArticulo;
                entidad.IdConduce = idconduce;
                entidad.Cantidad = item.Cantidad;

                entidadLista.Add(entidad);

            }
            return entidadLista;

        }
        private void toolStripButtonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                var ConduceEnti = new Conduce();
                ConduceEnti.Fecha = DateTime.Now;
                ConduceEnti.IdCliente = _cliente.Id;
                ConduceEnti.IdFactura = Convert.ToInt32(textBoxIDFactura.Text);
                ConduceEnti.IdEmpleado = _empleado.Id;
                _presenter.Add(ConduceEnti);

                var idconduce = _presenter.GetId();
                var detalle = EntidadDetalleConduce(idconduce.Id);
                foreach (var item in detalle)
                {
                    _presenter.AddDetalle(item);

                }

                FormConduceVolante frm = new FormConduceVolante();
                frm.id = idconduce.Id;
                frm.ShowDialog();
                LimpiarFinalizarF();

            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Ocurrio un error comunicarse con el probeedor del sistema:{0}", ex.ToString()));
            }

        }
        Clientes _cliente;

        private void buttonBuscarCotizacion_Click(object sender, EventArgs e)
        {
            try
            {
                var id = textBoxIDFactura.Text;
                var conduce = _presenter.GetIdConduce(id);
                var factura = _presenter.GetNombreId(id);
                var detalleFactura = _presenter.GetDetalleNombreId(id);
                if (conduce.Count() == 0)
                {
                    _cliente = _presenter.GetCliente(factura.IdCliente);
                    textBoxCliente.Text = _cliente.Nombre;
                    textBoxColaborador.Text = _empleado.Nombre;
                    textBoxObservacion.Text = factura.Observacion;

                    foreach (var item in detalleFactura)
                    {
                        var items = new DetalleConduceGrid();

                        items.IdArticulo = item.IdArticulo;
                        var articulo = _presenter.GetItem(item.IdArticulo);
                        items.Articulo = articulo.Nombre;
                        items.Cantidad = item.Cantidad;
                        _factura.Add(items);
                        dataGridViewConduce.DataSource = _factura.ToList();
                    }
                }
                else
                {
                    foreach (var item in conduce)
                    {
                        var detalleConduce = _presenter.GetDetalleConduece(item.Id.ToString());
                        foreach (var itemFactura in detalleFactura)
                        {
                            var exc = detalleConduce.Select(p => p.IdArticulo == itemFactura.IdArticulo);
                            if (exc == null)
                            {
                                var items = new DetalleConduceGrid();
                                items.IdArticulo = itemFactura.IdArticulo;
                                var articulo = _presenter.GetItem(itemFactura.IdArticulo);
                                items.Articulo = articulo.Nombre;
                                items.Cantidad = itemFactura.Cantidad;
                                _factura.Add(items);
                                dataGridViewConduce.DataSource = _factura.ToList();
                            }
                            else
                            {

                            }

                        }

                    }
                }
                if (_factura.Count() == 0)
                {
                    MessageBox.Show("para esta factura no tiene articulos pendientes.");
                }

            
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Se produjo un error comuniquese con su probeedor de servidio error : {0}", ex.ToString()));
            }


}

        private void toolStripButtonAyuda_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "D:/CreateSoftLopez/CreateSoft_Ventas -Manual de Usuario.pdf");
            Process.Start(path);
        }
    }
}

