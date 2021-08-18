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
    public partial class FormCompania : DevComponents.DotNetBar.OfficeForm
    {
        private readonly ICompaniaServices _presenter = new CompaniaServices();
        private static FormCompania frmInstance = null;
        public static FormCompania Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormCompania();
            }
            frmInstance.BringToFront();
            return frmInstance;
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
            textBoxRazonSocial.Text = string.Empty;
            id = 0;
        }
        public FormCompania()
        {
            InitializeComponent();
        }

        private void FormCompania_Load(object sender, EventArgs e)
        {
            var compania = _presenter.Get();
            dataGridViewCompania.DataSource = compania;
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNombre.Text != string.Empty && comboBoxTipoDocumento.SelectedIndex > 0
                             && textBoxNoDocumento.Text != string.Empty && textBoxTelefono.Text != string.Empty)
                {
                    var entidad = new Compania();
                    entidad.Nombre = textBoxNombre.Text;
                    entidad.RazonSocial = textBoxRazonSocial.Text;
                    entidad.TipoD = comboBoxTipoDocumento.Text;
                    entidad.NDoc= textBoxNoDocumento.Text;
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

                dataGridViewCompania.DataSource = _presenter.Get();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }
        }
        int GetId()
        {
            return Convert.ToInt32(dataGridViewCompania.CurrentRow.Cells[0].Value);
        }
        Compania tCompania = null;
        private void dataGridViewCompania_DoubleClick(object sender, EventArgs e)
        {
            id = GetId();
            tCompania = _presenter.GetNombreId(id);
            textBoxNombre.Text = tCompania.Nombre;
            textBoxRazonSocial.Text = tCompania.RazonSocial;
            comboBoxTipoDocumento.Text = tCompania.TipoD;
            textBoxNoDocumento.Text = tCompania.NDoc;
            textBoxTelefono.Text = tCompania.Telefono;
            textBoxDireccion.Text = tCompania.Direccion;
            textBoxEmail.Text = tCompania.Email;
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            id = GetId();
            tCompania = _presenter.GetNombreId(id);
            textBoxNombre.Text = tCompania.Nombre;
            textBoxRazonSocial.Text = tCompania.RazonSocial;
            comboBoxTipoDocumento.Text = tCompania.TipoD;
            textBoxNoDocumento.Text = tCompania.NDoc;
            textBoxTelefono.Text = tCompania.Telefono;
            textBoxDireccion.Text = tCompania.Direccion;
            textBoxEmail.Text = tCompania.Email;
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var entidad = new Compania();
                entidad.Nombre = textBoxNombre.Text;
                entidad.TipoD = comboBoxTipoDocumento.Text;
                entidad.NDoc = textBoxNoDocumento.Text;
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

                dataGridViewCompania.DataSource = _presenter.Get();
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
                dataGridViewCompania.DataSource = _presenter.GetNombreId(textBoxBuscar.Text);
            }
            else
            {
                dataGridViewCompania.DataSource = _presenter.Get();
            }
        }
    }
}
