using CSL_Ventas.Win;
using CSL_Ventas.Win.Almacen;
using CSL_Ventas.Win.Herramientas;
using CSL_Ventas.Win.Operaciones;
using CSL_Ventas.Win.Operaciones.ReportesBolantes;
using CSL_Ventas.Win.Seguridad;
using DevComponents.DotNetBar;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSL_Ventas.Win
{
    public partial class FormMenuojo : DevComponents.DotNetBar.Office2007RibbonForm
    {

        private Empleados _empleado;
        public Empleados empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }
        private Usuario _usuario;
        public Usuario usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public FormMenuojo()
        {
            InitializeComponent();

        }

        private void buttonItemProveedor_Click(object sender, EventArgs e)
        {
            FormProveedor cargar = null;
            cargar = FormProveedor.Instance();
            cargar.MdiParent = this;
            cargar.Show();
        }



        private void buttonItem13_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void buttonItemCliente_Click(object sender, EventArgs e)
        {
            FormClientes cargar = null;
            cargar = FormClientes.Instance();
            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemFacturacion_Click(object sender, EventArgs e)
        {
            FormFacturacion cargar = null;
            cargar = FormFacturacion.Instance();
            cargar.empleado = _empleado;
            cargar.MdiParent = this;
            cargar.Show();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (_usuario.Rol == 1)
            {
                ribbonTabItemMantenimientos.Visible = true;
                ribbonTabItemOperacones.Visible = true;
                ribbonTabItemReporte.Visible = true;
                ribbonTabItemSeguridad.Visible = false;
                ribbonTabItemAlmacen.Visible = true;
                buttonItemFacturacion.Enabled = true;
                buttonItemHistoricaCotizacion.Enabled = true;
                buttonItemHistoricoConduce.Enabled = true;
                buttonItemHistoricoFacturacion.Enabled = true;
                buttonItemConduce.Enabled = true;
                buttonItemCotizacion.Enabled = true;
                labelRol.Text = labelRol.Text + "Admin";
            }
            else if (_usuario.Rol == 2)
            {

                ribbonTabItemOperacones.Visible = true;
                ribbonTabItemMantenimientos.Visible = false;
          
                ribbonTabItemReporte.Visible =false;
                ribbonTabItemSeguridad.Visible = false;
                ribbonTabItemAlmacen.Visible = true;
                buttonItemFacturacion.Enabled = true;
                buttonItemHistoricaCotizacion.Enabled = true;
                buttonItemHistoricoConduce.Enabled = true;
                buttonItemHistoricoFacturacion.Enabled = true;
                buttonItemConduce.Enabled = true;
                buttonItemCotizacion.Enabled = true;

                labelRol.Text = labelRol.Text + "Empleados";
            }

            else if (_usuario.Rol == 3)
            {
                ribbonTabItemMantenimientos.Visible = true;
                ribbonTabItemOperacones.Visible = true;
                ribbonTabItemReporte.Visible = true;
                ribbonTabItemAlmacen.Visible = true;
                buttonItemFacturacion.Enabled = true;
                buttonItemHistoricaCotizacion.Enabled = true;
                buttonItemHistoricoConduce.Enabled = true;
                buttonItemHistoricoFacturacion.Enabled = true;
                buttonItemConduce.Enabled = true;
                buttonItemCotizacion.Enabled = true;
                buttonItemGanaciasPerdida.Visible = false;

                labelRol.Text = labelRol.Text + "Encargado";
            }
            labelUsuario.Text = labelUsuario.Text + _empleado.Nombre;


        }

        private void buttonItemArticulos_Click(object sender, EventArgs e)
        {
            FormArticulo cargar = null;
            cargar = FormArticulo.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemIngresoAlmacen_Click(object sender, EventArgs e)
        {
            FormIngresoAlmacen cargar = null;
            cargar = FormIngresoAlmacen.Instance();
            cargar.empleado = _empleado;
            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemInventario_Click(object sender, EventArgs e)
        {
            FormInventario cargar = null;
            cargar = FormInventario.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemNCF_Click(object sender, EventArgs e)
        {
            FormComprobanteFiscal cargar = null;
            cargar = FormComprobanteFiscal.Instance();
            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemHistoricoFacturacion_Click(object sender, EventArgs e)
        {
            FormHistoricoFacturacion cargar = null;
            cargar = FormHistoricoFacturacion.Instance();
            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemUsuario_Click(object sender, EventArgs e)
        {
            FormAgUsuario cargar = null;
            cargar = FormAgUsuario.Instance();
            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemRoles_Click(object sender, EventArgs e)
        {
            FormRoles cargar = null;
            cargar = FormRoles.Instance();
            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemEmpleados_Click(object sender, EventArgs e)
        {

            FormEmpleados cargar = null;
            cargar = FormEmpleados.Instance();
            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemCotizacion_Click(object sender, EventArgs e)
        {
            FormCotizacion cargar = null;
            cargar = FormCotizacion.Instance();
            cargar.empleado = _empleado;
            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemHistoricaCotizacion_Click(object sender, EventArgs e)
        {
            FormHistoricoCotizacion cargar = null;
            cargar = FormHistoricoCotizacion.Instance();
            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemConduce_Click(object sender, EventArgs e)
        {
            FormConduce cargar = null;
            cargar = FormConduce.Instance();
            cargar.empleado = _empleado;
            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemReporteVentas_Click(object sender, EventArgs e)
        {
            FormReporteVentaEmpleado cargar = null;
            cargar = FormReporteVentaEmpleado.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }


        private void buttonItemHistoricoConduce_Click(object sender, EventArgs e)
        {
            FormHistoricoConduce cargar = null;
            cargar = FormHistoricoConduce.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void buttonItemGanaciasPerdida_Click(object sender, EventArgs e)
        {
            FormGananciasGatos cargar = null;
            cargar = FormGananciasGatos.Instance();

            cargar.MdiParent = this;
            cargar.Show();

        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "D:/CreateSoftLopez/CreateSoft_Ventas -Manual de Usuario.pdf");
            Process.Start(path);
        }

        private void labelCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
