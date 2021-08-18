using Entidad;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSL_Ventas.Win
{
    public partial class FormProveedor : DevComponents.DotNetBar.OfficeForm
    {
        public FormProveedor()
        {
            InitializeComponent();
        }
        IProveedorServices _presenter = new ProveedorServices();
        private static FormProveedor frmInstance = null;
        public static FormProveedor Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormProveedor();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void FormProveedor_Load(object sender, EventArgs e)
           
        {
            var cliente = _presenter.Get();
            dataGridViewProveedor.DataSource = cliente;
        }
        int id;
        void Limpiar()
        {
            textBoxNombre.Text = string.Empty;
            comboBoxTipoDocumento.Text = string.Empty;
            textBoxNoDocumento.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;
            textBoxDireccion.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            id = 0;
        }
        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNombre.Text != string.Empty 
                            && textBoxTelefono.Text != string.Empty)
                {
                    var entidad = new Proveedor();
                    entidad.Nombre = textBoxNombre.Text;
                    entidad.TipoD = comboBoxTipoDocumento.Text;
                    entidad.NDocumento = textBoxNoDocumento.Text;
                    entidad.Telefono = textBoxTelefono.Text;
                    entidad.Direccion = textBoxDireccion.Text;
                    entidad.Email = textBoxEmail.Text;

                    entidad.Id = id;

                    if (id > 0)
                    {
                        _presenter.Update(entidad);
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

                dataGridViewProveedor.DataSource = _presenter.Get();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }
        }
        int GetId()
        {
            return Convert.ToInt32(dataGridViewProveedor.CurrentRow.Cells[0].Value);
        }
        Proveedor tProveedore = null;
        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            id = GetId();
            tProveedore = _presenter.GetNombreId(id);
            textBoxNombre.Text = tProveedore.Nombre;
            
            comboBoxTipoDocumento.Text = tProveedore.TipoD;
            textBoxNoDocumento.Text = tProveedore.NDocumento;
            textBoxTelefono.Text = tProveedore.Telefono;
            textBoxDireccion.Text = tProveedore.Direccion;
            textBoxEmail.Text = tProveedore.Email;
        }

        private void dataGridViewPorveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = GetId();
            tProveedore = _presenter.GetNombreId(id);
            textBoxNombre.Text = tProveedore.Nombre;
      
            comboBoxTipoDocumento.Text = tProveedore.TipoD;
            textBoxNoDocumento.Text = tProveedore.NDocumento;
            textBoxTelefono.Text = tProveedore.Telefono;
            textBoxDireccion.Text = tProveedore.Direccion;
            textBoxEmail.Text = tProveedore.Email;
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                var entidad = new Proveedor();
                entidad.Nombre = textBoxNombre.Text;
                entidad.TipoD = comboBoxTipoDocumento.Text;
                entidad.NDocumento = textBoxNoDocumento.Text;
                entidad.Telefono = textBoxTelefono.Text;
                entidad.Direccion = textBoxDireccion.Text;
                entidad.Email = textBoxEmail.Text;
                id = GetId();
                entidad.Id = id;
                if (id > 0)
                {
                    _presenter.Delete(entidad);
                    MessageBox.Show("El registro fue Eliminado satisfactoriamente.");
                }
                else
                {
                    MessageBox.Show("debe seleccionar el registro que quiere eliminar.");
                }
                Limpiar();

                dataGridViewProveedor.DataSource = _presenter.Get();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != string.Empty)
            {
                dataGridViewProveedor.DataSource = _presenter.GetNombreId(textBoxBuscar.Text);
            }
            else
            {
                dataGridViewProveedor.DataSource = _presenter.Get();
            }
        }
    }
}
