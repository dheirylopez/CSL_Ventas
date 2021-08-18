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
    public partial class FormEmpleados : DevComponents.DotNetBar.OfficeForm
    {
        private readonly IEmpleadosServices _presenter = new EmpleadosServices();
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
            textBoxEmail.Text = string.Empty;
            textBoxPosicion.Text = string.Empty;
            textBoxSueldo.Text = string.Empty;
            id = 0;
        }
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            var empleados = _presenter.Get();
            dataGridViewEmpleado.DataSource = empleados;
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNombre.Text != string.Empty &&  comboBoxTipoDocumento.Text != string.Empty
                             && textBoxNoDocumento.Text != string.Empty && textBoxTelefono.Text != string.Empty)
                {
                    var entidad = new Empleados();
                    entidad.Nombre = textBoxNombre.Text;
                    entidad.Puesto = textBoxPosicion.Text;
                    entidad.TipoD = comboBoxTipoDocumento.Text;
                    entidad.NDocumento = textBoxNoDocumento.Text;
                    entidad.Telefono = textBoxTelefono.Text;
                    entidad.Direccion = textBoxDireccion.Text;
                    entidad.Sueldo = Convert.ToInt32(textBoxSueldo.Text);
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

                dataGridViewEmpleado.DataSource = _presenter.Get();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }
        }
        int GetId()
        {
          return Convert.ToInt32(dataGridViewEmpleado.CurrentRow.Cells[0].Value);
        }
        Empleados tEmpleado = null;
        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            id = GetId();
        
            tEmpleado = _presenter.GetNombreId(id);
           
            textBoxNombre.Text =  tEmpleado.Nombre;
            textBoxPosicion.Text =tEmpleado.Puesto;
            comboBoxTipoDocumento.Text =tEmpleado.TipoD;
            textBoxNoDocumento.Text = tEmpleado.NDocumento;
            textBoxTelefono.Text = tEmpleado.Telefono;
            textBoxDireccion.Text =  tEmpleado.Direccion;
            textBoxEmail.Text = tEmpleado.Email;
            textBoxSueldo.Text = tEmpleado.Sueldo.ToString();
        }

        private void dataGridViewEmpleado_DoubleClick(object sender, EventArgs e)
        {
            id = GetId();

            tEmpleado = _presenter.GetNombreId(id);

            textBoxNombre.Text = tEmpleado.Nombre;
            textBoxPosicion.Text = tEmpleado.Puesto;
            comboBoxTipoDocumento.Text = tEmpleado.TipoD;
            textBoxNoDocumento.Text = tEmpleado.NDocumento;
            textBoxTelefono.Text = tEmpleado.Telefono;
            textBoxDireccion.Text = tEmpleado.Direccion;
            textBoxEmail.Text = tEmpleado.Email;
            textBoxSueldo.Text = tEmpleado.Sueldo.ToString();
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
                entidad.Email = textBoxEmail.Text;
                entidad.Puesto = textBoxPosicion.Text;
                if (textBoxSueldo.Text == string.Empty)
                    entidad.Sueldo = 0; 
                else {
                    entidad.Sueldo = Convert.ToInt32(textBoxSueldo.Text);
                        }
                id=GetId();
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

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != string.Empty)
            {
                dataGridViewEmpleado.DataSource = _presenter.GetNombreId(textBoxBuscar.Text);
            }
            else
            {
                dataGridViewEmpleado.DataSource = _presenter.Get();
            }
        }
    }
}
