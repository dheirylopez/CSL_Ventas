using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Servicios;

namespace CSL_Ventas.Win.Almacen
{
    public partial class FormSeleccionArticulos : DevComponents.DotNetBar.OfficeForm, IContract
    {
        IAlmacenServices _presenter = new AlmacenServices();
        public FormSeleccionArticulos()
        {
            InitializeComponent();
        }


        private void buttonBuscarArticulo_Click(object sender, EventArgs e)
        {
            FormInventarioFacturacion inv = new FormInventarioFacturacion();
            inv.contrato = this;
            inv.Show();

        }
        public int id;
        private Inventario _inventario;
        public Inventario inventario
        {
            get { return _inventario; }
            set { _inventario = value; }
        }
        List<DetalleFacturaGrid> _factura;

        public void Ejecutar(Inventario informacion)
        {
            _inventario = informacion;

            textBoxArticulo.Text = _inventario.Articulo;

        }

        public void Ejecutar(Clientes informacion)
        {
            throw new NotImplementedException();
        }

        public void Ejecutar(Items informacion)
        {
            throw new NotImplementedException();
        }

        private void toolStripButtonAgregar_Click(object sender, EventArgs e)
        {
            var items = new DetalleFacturaGrid();
            if (textBoxCantidad.Text != string.Empty && inventario != null)
            {

                items.IdArticulo = inventario.IdArticulo;
                items.Articulo = inventario.Articulo;
                items.Cantidad = Convert.ToInt32(textBoxCantidad.Text);


                _factura.Add(items);
                dataGridViewSeleccion.DataSource = _factura.ToList();
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

            textBoxArticulo.Text = string.Empty;

        }
        void LimpiarFinalizarF()
        {
            textBoxCantidad.Text = string.Empty;

            textBoxArticulo.Text = string.Empty;

            _factura = new List<DetalleFacturaGrid>();

        }
        private void FormSeleccionArticulos_Load(object sender, EventArgs e)
        {
            _factura = new List<DetalleFacturaGrid>();
        }
        IEnumerable<DetalleItems> DetalleItem(int id)
        {

            var entidadLista = new List<DetalleItems>();
            foreach (var item in _factura)
            {
                var entidad = new DetalleItems();

                entidad.IdItems = id;
                entidad.IdArticulo = item.IdArticulo;
                entidad.Cantidad = item.Cantidad;

                entidadLista.Add(entidad);

            }
            return entidadLista;

        }
        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {

            var detalle = DetalleItem(id);
            foreach (var item in detalle)
            {
                _presenter.AddDetalle(item);

            }
            Limpiar();
            LimpiarFinalizarF();
            this.Close();
        }

        private void toolStripButtonQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                var grid = dataGridViewSeleccion.SelectedRows[0].Index;
                var articulo = dataGridViewSeleccion.SelectedRows[0].Cells[1].Value.ToString();
                var cantidad = Convert.ToInt32(dataGridViewSeleccion.SelectedRows[0].Cells[2].Value.ToString());


                _factura.RemoveAt(grid);
                if (_factura.Count() > 0)
                {
                    dataGridViewSeleccion.DataSource = _factura;

                }
                else
                {
                    dataGridViewSeleccion.DataSource = null;
                }
}
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

}
    }
}
