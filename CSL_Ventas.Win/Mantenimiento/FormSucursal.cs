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
    public partial class FormSucursal : DevComponents.DotNetBar.OfficeForm
    {
        private readonly ISucursalServices _presenter = new SucursalServices();
        private static FormSucursal frmInstance = null;
        public static FormSucursal Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormSucursal();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        int id;
        void Limpiar()
        {
            textBoxNombre.Text = string.Empty;
            comboBoxCompania.Text = string.Empty;
            textBoxRNL.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;
            textBoxDireccion.Text = string.Empty;
       
            id = 0;
        }
        public FormSucursal()
        {
            InitializeComponent();
        }

        private void FormSucursal_Load(object sender, EventArgs e)
        { var compania = _presenter.GetCompania();
            comboBoxCompania.DataSource = compania;
            comboBoxCompania.DisplayMember = "Nombre";
            comboBoxCompania.ValueMember = "Id";

            var sucursal = _presenter.Get();
            dataGridViewSucursal.DataSource = sucursal;
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNombre.Text != string.Empty && Convert.ToInt32( comboBoxCompania.SelectedValue) > 0
                             && textBoxRNL.Text != string.Empty && textBoxTelefono.Text != string.Empty)
                {
                    var entidad = new Sucursal();
                    entidad.Nombre = textBoxNombre.Text;
                   
                    entidad.Compania =Convert.ToInt32( comboBoxCompania.SelectedValue);
                    entidad.RNL = textBoxRNL.Text;
                    entidad.Telefono = textBoxTelefono.Text;
                    entidad.Direccion = textBoxDireccion.Text;
                  

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

                dataGridViewSucursal.DataSource = _presenter.Get();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }
        }
        int GetId()
        {
            return Convert.ToInt32(dataGridViewSucursal.CurrentRow.Cells[0].Value);
        }
        Sucursal tSucursal = null;
        private void dataGridViewSucursal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = GetId();

            tSucursal = _presenter.GetNombreId(id);
            var tcompania = _presenter.Get(tSucursal.Compania);

            textBoxNombre.Text = tSucursal.Nombre;
            
            comboBoxCompania.Text =tcompania.Nombre;
            textBoxRNL.Text = tSucursal.RNL;
            textBoxTelefono.Text = tSucursal.Telefono;
            textBoxDireccion.Text = tSucursal.Direccion;
           
         
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {

            id = GetId();

            tSucursal = _presenter.GetNombreId(id);
            var tcompania = _presenter.Get(tSucursal.Compania);

            textBoxNombre.Text = tSucursal.Nombre;

            comboBoxCompania.Text = tcompania.Nombre;
            textBoxRNL.Text = tSucursal.RNL;
            textBoxTelefono.Text = tSucursal.Telefono;
            textBoxDireccion.Text = tSucursal.Direccion;
         
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != string.Empty)
            {
                dataGridViewSucursal.DataSource = _presenter.GetNombreId(textBoxBuscar.Text);
            }
            else
            {
                dataGridViewSucursal.DataSource = _presenter.Get();
            }
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var entidad = new Sucursal();
                entidad.Nombre = textBoxNombre.Text;
                entidad.Compania = comboBoxCompania.SelectedIndex;
                entidad.RNL = textBoxRNL.Text;
                entidad.Telefono = textBoxTelefono.Text;
                entidad.Direccion = textBoxDireccion.Text;
                
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

                dataGridViewSucursal.DataSource = _presenter.Get();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }
        }
    }
}
