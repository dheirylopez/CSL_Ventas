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

namespace CSL_Ventas.Win
{
    public partial class FormLogin : Form
    {
        SeguridadServices _presentar = new SeguridadServices();
        public FormLogin()
        {
            InitializeComponent();
            label3.Text = DateTime.Now.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FormAgUsuario agu = new FormAgUsuario();
            agu.ShowDialog();


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            var msj = MessageBox.Show("Desera cancelar su ingreso?", "Informacion", MessageBoxButtons.YesNo);
            if (msj == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(comboBoxEmpleado.SelectedValue);
            var validar = _presentar.Validar(id, textBoxClave.Text);
            if (validar == true)
            {
                //var empleado = _presentar.GetEmpleado(id);
                //var usuario = _presentar.GetUsuaario(id);



                this.Hide();

                FormMenu menu = new FormMenu();
                //menu.empleado = empleado;
                //menu.usuario = usuario;
                menu.Show();



                FormLogin login = new FormLogin();
                login.Close();


            }
            else
            {
                MessageBox.Show("La clave es incorrecta o este empleado no tiene acceso al sistema.");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            var empleados = _presentar.Get();
            comboBoxEmpleado.DataSource = empleados;
            comboBoxEmpleado.DisplayMember = "Nombre";
            comboBoxEmpleado.ValueMember = "Id";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "D:/CreateSoftLopez/CreateSoft_Ventas -Manual de Usuario.pdf");
            Process.Start(path);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBoxEmpleado.SelectedValue) <= 0)
            {

            }
            else
            {
                var iduser = Convert.ToInt32(comboBoxEmpleado.SelectedValue);
                var compania = _presentar.GetUsuarioCompania(iduser);

                comboBoxCompañia.DataSource = compania;
                comboBoxCompañia.DisplayMember = "Nombre";
                comboBoxCompañia.ValueMember = "Id";
            }

        }

        private void comboBoxCompañia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBoxCompañia.SelectedValue) <= 0)
            {

            }
            else
            {
                var iduser = Convert.ToInt32(comboBoxCompañia.SelectedValue);
                var sucursales = _presentar.GetSucursalesCompania(iduser);

                comboBoxCompañia.DataSource = sucursales;
                comboBoxCompañia.DisplayMember = "Nombre";
                comboBoxCompañia.ValueMember = "Id";
            }
        }

        private void buttonEntrar_Enter(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(comboBoxEmpleado.SelectedValue);
            var validar = _presentar.Validar(id, textBoxClave.Text);
            if (validar == true)
            {
                //var empleado = _presentar.GetEmpleado(id);
                //var usuario = _presentar.GetUsuaario(id);



                this.Hide();

                FormMenu menu = new FormMenu();
                //menu.empleado = empleado;
                //menu.usuario = usuario;
                menu.Show();



                FormLogin login = new FormLogin();
                login.Close();


            }
            else
            {
                MessageBox.Show("La clave es incorrecta o este empleado no tiene acceso al sistema.");
            }
        }
    }
}
