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
    public partial class FormRoles : DevComponents.DotNetBar.OfficeForm
    {
        public FormRoles()
        {
            InitializeComponent();
        }
        ISeguridadServices _presentar = new SeguridadServices();
        private void FormRoles_Load(object sender, EventArgs e)
        {
            dataGridViewRoles.DataSource = _presentar.GetRol();
        }
        private static FormRoles frmInstance = null;
        public static FormRoles Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormRoles();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        int id;
        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxRol.Text != string.Empty )
                {
                    var entidad = new Roles();
                    entidad.Nombre = textBoxRol.Text;
                    entidad.Id = id;

                    if (id > 0)
                    {
                        _presentar.UpdateRol(entidad);
                        MessageBox.Show("El registro fue actualizado satisfactoriamente.");
                    }
                    else
                    {
                        _presentar.AddRol(entidad);
                        MessageBox.Show("El registro se ingreso satisfactoriamente.");
                    }
                }
                else
                {
                    MessageBox.Show("debe llenar todos los campos requeridos.");
                }


              textBoxRol.Text = string.Empty;



                dataGridViewRoles.DataSource = _presentar.GetRol();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }
        }

        private void dataGridViewRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewRoles.CurrentRow.Cells[0].Value);
            textBoxRol.Text = dataGridViewRoles.CurrentRow.Cells[1].Value.ToString();
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridViewRoles.CurrentRow.Cells[0].Value);
            textBoxRol.Text = dataGridViewRoles.CurrentRow.Cells[1].Value.ToString();
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            try {
                var entidad = new Roles();
                entidad.Nombre = textBoxRol.Text;
                entidad.Id = id;
               
            if (id > 0)
            {
                _presentar.DeleteRol(entidad);
                MessageBox.Show("El registro fue Eliminado satisfactoriamente.");
            }
            else
            {
                MessageBox.Show("debe seleccionar el registro que quiere eliminar.");
            }


                textBoxRol.Text = string.Empty;
                dataGridViewRoles.DataSource = _presentar.GetRol();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }
}
    }
}
