using CSL_Ventas.Win.Almacen;
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
    public partial class FormArticulo : DevComponents.DotNetBar.OfficeForm
    {

        public FormArticulo()
        {
            InitializeComponent();
        }
        IAlmacenServices _presenter = new AlmacenServices();
        public IContract contrato { get; set; }
        private static FormArticulo frmInstance = null;
        public static FormArticulo Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormArticulo();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        private void FormArticulo_Load(object sender, EventArgs e)
        {
            dataGridViewArticulos.DataSource = _presenter.GetArticulo();
            
        }
        int id;
        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxArticulo.Text != string.Empty && comboBoxTipo.Text != string.Empty)
                {
                    var entidad = new Items();
                    entidad.Nombre = textBoxArticulo.Text;
                    entidad.Tipo = comboBoxTipo.Text;
                    entidad.Id = id;

                    if (id > 0)
                    {
                        _presenter.UpdateArticulo(entidad);
                        MessageBox.Show("El registro fue actualizado satisfactoriamente.");
                    }
                    else
                    {
                        _presenter.AddArticulo(entidad);
                        MessageBox.Show("El registro se ingreso satisfactoriamente.");
                    }
                }

                else
                {
                    MessageBox.Show("debe llenar todos los campos requeridos.");
                }

                Limpiar();

                dataGridViewArticulos.DataSource = _presenter.GetArticulo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }


        }

        void Limpiar()
        {
            id = 0;
            textBoxArticulo.Text = string.Empty;
            comboBoxTipo.Text = string.Empty;
        }
        private void dataGridViewArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewArticulos.CurrentRow.Cells[0].Value);
            textBoxArticulo.Text = dataGridViewArticulos.CurrentRow.Cells[1].Value.ToString();
            comboBoxTipo.Text = dataGridViewArticulos.CurrentRow.Cells[2].Value.ToString();

            var items = new Items();
            items.Id = Convert.ToInt32(dataGridViewArticulos.CurrentRow.Cells[0].Value.ToString());
            items.Nombre = dataGridViewArticulos.CurrentRow.Cells[1].Value.ToString();
            items.Tipo = dataGridViewArticulos.CurrentRow.Cells[2].Value.ToString();

            if (items != null)
            {
                labelSelect.Text = "Selecconado";
                if (contrato != null)
                {
                    contrato.Ejecutar(items);
                }

            }
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var entidad = new Items();
                entidad.Nombre = textBoxArticulo.Text;
                entidad.Tipo = comboBoxTipo.Text;
                entidad.Id = id;

                if (id > 0)
                {
                    _presenter.DeleteDetalle(id);
                    _presenter.DeleteArticulo(entidad);

                    MessageBox.Show("El registro fue Eliminado satisfactoriamente.");
                }
                else
                {
                    MessageBox.Show("debe seleccionar el registro que quiere eliminar.");
                }

                Limpiar();

                dataGridViewArticulos.DataSource = _presenter.GetArticulo();
            }

            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != string.Empty)
            {

                dataGridViewArticulos.DataSource = _presenter.GetArticuloNombreId(textBoxBuscar.Text);
            }
            else
            {
                dataGridViewArticulos.DataSource = _presenter.GetArticulo();
            }
        }

        private void toolStripButtonAyuda_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "D:/CreateSoftLopez/CreateSoft_Ventas -Manual de Usuario.pdf");
            Process.Start(path);
        }

        private void checkBoxCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCredito.Checked == true)
            {
                label1.Visible = true;
                textBoxX100Credito.Visible = true;

            }
        }

        private void buttonAñadirArticulo_Click(object sender, EventArgs e)
        {
            if (textBoxArticulo.Text != string.Empty || comboBoxTipo.Text != string.Empty)
            {
                var entidad = new Items();
                entidad.Nombre = textBoxArticulo.Text;
                entidad.Tipo = comboBoxTipo.Text;
                _presenter.AddArticulo(entidad);
                var articulo = _presenter.GetArticuloNombreId();
                id = articulo.Id;

            }


            FormSeleccionArticulos frmselect = new FormSeleccionArticulos();


            frmselect.id = id;
            frmselect.ShowDialog();
            Limpiar();
            dataGridViewArticulos.DataSource = _presenter.GetArticulo();
            MessageBox.Show("El registro se ingreso satisfactoriamente.");
        }


    }
}



