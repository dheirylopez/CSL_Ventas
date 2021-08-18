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

namespace CSL_Ventas.Win.Seguridad
{
    public partial class FormEmpleados : DevComponents.DotNetBar.OfficeForm
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }
        ISeguridadServices _presenter = new SeguridadServices();
        private static FormEmpleados frmInstance = null;
        public static FormEmpleados Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormEmpleados();
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
            textBoxPuesto.Text = string.Empty;
            textBoxSueldo.Text = string.Empty;

            id = 0;
        }
        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNombre.Text != string.Empty && comboBoxTipoDocumento.SelectedIndex > 0
                             && textBoxNoDocumento.Text != string.Empty && textBoxTelefono.Text != string.Empty)
                {
                    var entidad = new Empleados();
                    entidad.Nombre = textBoxNombre.Text;
                    entidad.TipoD = comboBoxTipoDocumento.Text;
                    entidad.NDocumento = textBoxNoDocumento.Text;
                    entidad.Telefono = textBoxTelefono.Text;
                    entidad.Direccion = textBoxDireccion.Text;
                    entidad.Puesto = textBoxPuesto.Text;
                    if (textBoxSueldo.Text != string.Empty)
                    {
                        entidad.Sueldo = Convert.ToInt32(textBoxSueldo.Text);
                    }
                    else
                    {
                        entidad.Sueldo = 0;
                    }


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

                dataGridViewEmpleado.DataSource = _presenter.Get();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridViewEmpleado.CurrentRow.Cells[0].Value);
            textBoxNombre.Text = dataGridViewEmpleado.CurrentRow.Cells[1].Value.ToString();
            comboBoxTipoDocumento.Text = dataGridViewEmpleado.CurrentRow.Cells[2].Value.ToString();
            textBoxNoDocumento.Text = dataGridViewEmpleado.CurrentRow.Cells[3].Value.ToString();
            textBoxTelefono.Text = dataGridViewEmpleado.CurrentRow.Cells[4].Value.ToString();
            textBoxDireccion.Text = dataGridViewEmpleado.CurrentRow.Cells[5].Value.ToString();
            textBoxPuesto.Text = dataGridViewEmpleado.CurrentRow.Cells[6].Value.ToString();
            textBoxSueldo.Text = dataGridViewEmpleado.CurrentRow.Cells[7].Value.ToString();
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                var entidad = new Empleados();
                entidad.Nombre = textBoxNombre.Text;
                entidad.TipoD = comboBoxTipoDocumento.Text;
                entidad.NDocumento = textBoxNoDocumento.Text;
                entidad.Telefono = textBoxTelefono.Text;
                entidad.Direccion = textBoxDireccion.Text;
                entidad.Puesto = textBoxPuesto.Text;

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
                dataGridViewEmpleado.DataSource = _presenter.Get();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }

        }

        private void dataGridViewEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewEmpleado.CurrentRow.Cells[0].Value);
            textBoxNombre.Text = dataGridViewEmpleado.CurrentRow.Cells[1].Value.ToString();
            comboBoxTipoDocumento.Text = dataGridViewEmpleado.CurrentRow.Cells[2].Value.ToString();
            textBoxNoDocumento.Text = dataGridViewEmpleado.CurrentRow.Cells[3].Value.ToString();
            textBoxTelefono.Text = dataGridViewEmpleado.CurrentRow.Cells[4].Value.ToString();
            textBoxDireccion.Text = dataGridViewEmpleado.CurrentRow.Cells[5].Value.ToString();
            textBoxPuesto.Text = dataGridViewEmpleado.CurrentRow.Cells[6].Value.ToString();
            textBoxSueldo.Text = dataGridViewEmpleado.CurrentRow.Cells[7].Value.ToString();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != string.Empty)
            {
                dataGridViewEmpleado.DataSource = _presenter.GetNombreIdEmpleado(textBoxBuscar.Text);
            }
            else
            {
                dataGridViewEmpleado.DataSource = _presenter.Get();
            }
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            dataGridViewEmpleado.DataSource = _presenter.Get();
        }
    }
}
