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

namespace CSL_Ventas.Win.Almacen
{
    public partial class FormIngresoAlmacen : DevComponents.DotNetBar.OfficeForm, IContract
    {
        public FormIngresoAlmacen()
        {
            InitializeComponent();
        }
        Items _items;
        public Items Items
        {
            get { return _items; }
            set { _items = value; }
        }
        private Empleados _empleado;
        public Empleados empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }
        private static FormIngresoAlmacen frmInstance = null;
        public static FormIngresoAlmacen Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormIngresoAlmacen();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        IAlmacenServices _presenter = new AlmacenServices();
        private void FormIngresoAlmacen_Load(object sender, EventArgs e)
        {
            comboBoxProbeedor.DataSource = _presenter.GetProveedpr();
            comboBoxProbeedor.DisplayMember = "Nombre";
            comboBoxProbeedor.ValueMember = "Id";

            textBoxColaborador.Text = _empleado.Nombre;
        }

        void Limpiar()
        {

            textBoxArticulo.Text= string.Empty;
            textBoxPrecioVenta.Text = string.Empty;
            textBoxPrecioCompra.Text = string.Empty;
            textBoxCantidad.Text = string.Empty;
            comboBoxProbeedor.Text = string.Empty;
        }

        private void toolStripButtonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_items.Id > 0
               && textBoxPrecioVenta.Text != string.Empty && textBoxPrecioCompra.Text != string.Empty &&
               textBoxCantidad.Text != string.Empty && Convert.ToInt32(comboBoxProbeedor.SelectedValue) > 0)
                {
                    var entidad = new Entidad.Almacen();
                    entidad.Cantidad = Convert.ToInt32(textBoxCantidad.Text);
                    entidad.Fecha = DateTime.Now;
                    entidad.IdItems = _items.Id;
                    entidad.IdProveedor = Convert.ToInt32(comboBoxProbeedor.SelectedValue);
                    entidad.IdUsuario = _empleado.Id;
                    entidad.PrecioC = textBoxPrecioCompra.Text;
                    entidad.PrecioV = textBoxPrecioVenta.Text;

                    var aumentoProducto = _presenter.GetarticuloAlmacen(entidad.IdItems.ToString());

                    if (aumentoProducto != null)
                    {
                        entidad.Cantidad = aumentoProducto.Cantidad + Convert.ToInt32(textBoxCantidad.Text);
                        entidad.Fecha = DateTime.Now;
                        entidad.IdItems = _items.Id;
                        entidad.IdProveedor = Convert.ToInt32(comboBoxProbeedor.SelectedValue);
                        entidad.IdUsuario = _empleado.Id;
                        entidad.PrecioC = textBoxPrecioCompra.Text;
                        entidad.PrecioV = textBoxPrecioVenta.Text;
                        entidad.Id = aumentoProducto.Id;
                        _presenter.Update(entidad);
                        var historico = new HistoricoAlmacen();
                        historico.IdAlmacen = entidad.Id;
                        historico.Cantidad = Convert.ToInt32(textBoxCantidad.Text);
                        historico.Fecha = DateTime.Now;
                        _presenter.AddHistoricoAlmacen(historico);
                        MessageBox.Show("El registro fue actualizado satisfactoriamente.");
                    }
                    else
                    {
                        _presenter.Add(entidad);
                        MessageBox.Show("El registro se ingreso satisfactoriamente.");
                    }
                }
                else
                {
                    MessageBox.Show("debe llenar todos los campos requeridos.");
                }

                Limpiar();


            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }
        }

        private void toolStripButtonRefrescar_Click(object sender, EventArgs e)
        {
            comboBoxProbeedor.DataSource = _presenter.GetProveedpr();
            comboBoxProbeedor.DisplayMember = "Nombre";
            comboBoxProbeedor.ValueMember = "Id";

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "D:/CreateSoftLopez/CreateSoft_Ventas -Manual de Usuario.pdf");
            Process.Start(path);
        }

        public void Ejecutar(Inventario informacion)
        {
            throw new NotImplementedException();
        }

        public void Ejecutar(Clientes informacion)
        {
            throw new NotImplementedException();
        }

        public void Ejecutar(Items informacion)
        {
            _items = informacion;

            textBoxArticulo.Text = _items.Nombre;

        }

        private void buttonArticulo_Click(object sender, EventArgs e)
        {
            FormArticulo item = new FormArticulo();
            item.contrato = this;
            item.Show();
        }
    }
}
