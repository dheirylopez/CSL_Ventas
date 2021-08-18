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
    public partial class FormAgUsuario : DevComponents.DotNetBar.OfficeForm
    {
        ISeguridadServices _presentar = new SeguridadServices();
        public FormAgUsuario()
        {
            InitializeComponent();
        }

        private static FormAgUsuario frmInstance = null;
        public static FormAgUsuario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormAgUsuario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        private void FormAgUsuario_Load(object sender, EventArgs e)
        {

            var empleado = _presentar.Get();
            comboBoxEmpleado.DataSource = empleado;
            comboBoxEmpleado.DisplayMember = "Nombre";
            comboBoxEmpleado.ValueMember = "Id";

            var rol = _presentar.GetRol();
            //comboBoxRol.DataSource = rol;
            //comboBoxRol.DisplayMember = "Nombre";
            //comboBoxRol.ValueMember = "Id";
        }

        private void toolStripButtonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if ( Convert.ToInt32(comboBoxEmpleado.SelectedValue) > 0 && textBoxClave.Text != string.Empty)
                {
                    var enti = new Usuario();
                    enti.Clave = textBoxClave.Text;
                    enti.IdEmpleado = Convert.ToInt32(comboBoxEmpleado.SelectedValue);
                    //enti.Rol = Convert.ToInt32(comboBoxRol.SelectedValue);
                    enti.Estatus = Convert.ToInt32(checkBoxEstatus.Checked);
                    var validacion = _presentar.GetUsuaario(enti.IdEmpleado);
                    if (validacion != null)
                    {
                        enti.Id = validacion.Id;
                        _presentar.UpdateUsuario(enti);
                        MessageBox.Show("Usuario Actualizado Satisfactoriamente.");
                    }
                    else
                    {
                        _presentar.AddUsuario(enti);
                        MessageBox.Show("se agrego el usuario al sistema.");
                    }
                }
                else
                {
                    MessageBox.Show("No pueden haber campos vacios");
                }
                this.Hide();
                FormLogin login = new FormLogin();
                login.Show();
                FormAgUsuario agu = new FormAgUsuario();
                agu.Close();
             
            }
            catch (Exception ex )
            {

                MessageBox.Show(string.Format("A ocurrido un erro comuniquese con su proveedor erro: {0}",ex.ToString()));
            }

        }
    }
}
