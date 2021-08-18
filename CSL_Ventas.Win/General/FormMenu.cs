using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidad;
using Servicios;

namespace CSL_Ventas.Win
{
    public partial class FormMenu : DevComponents.DotNetBar.OfficeForm
    {
        private int childFormNumber = 0;

        public FormMenu()
        {
            InitializeComponent();
        }
        IPermisosMenuServices _presenter = new PermisosMenuServices();


        private IList<Form> GetFormList()
        {

            IList<Form> lista = new List<Form>();
          
            Module[] modulos = Assembly.GetExecutingAssembly().GetModules();
            foreach (Module m in modulos)
            {

                string nameSpace = m.Assembly.GetName().Name;

                Type[] tipos = m.GetTypes();

                foreach (Type t in tipos)
                {

                    if (t.IsSubclassOf(typeof(Form)))
                        lista.Add(new Form() { Name = t.Name, AccessibleName = t.FullName });
                   
                }
            }
            return lista;
        }

        public class FormList
        {

            public string Name { get; set; }
            public string FullName { get; set; }
        }



        //Habilitar Menu
        private void HabilitarMenu()
        {
        
          

            var ojo = _presenter.Get();

            foreach (var item in ojo)
            {
                //Habilitar menus principales
                if (item.PantallasMenu.Equals("MenuMantenimiento")) { MenuMantenimiento.Enabled = true; }
                if (item.PantallasMenu.Equals("MenuOperaciones")) { MenuOperaciones.Enabled = true; }
                if (item.PantallasMenu.Equals("MenuAlmacen")) { MenuAlmacen.Enabled = true; }
                if (item.PantallasMenu.Equals("SubMenuCompania")) { SubMenuFormCompania.Enabled = true; }
                if (item.PantallasMenu.Equals("MenuReporte")) { MenuReporte.Enabled = true; }

                //Dabilitar Sub menus 
                if (item.PantallasMenu.Equals("SubMenuFormEmpleados")) { SubMenuFormEmpleados.Enabled = true; }
                if (item.PantallasMenu.Equals("SubMenuFormClientes")) { SubMenuFormClientes.Enabled = true; }
                if (item.PantallasMenu.Equals("SubMenuFormProveedores")) { SubMenuFormProveedores.Enabled = true; }
                if (item.PantallasMenu.Equals("SubMenuFormCompania")) { SubMenuFormCompania.Enabled = true; }
                if (item.PantallasMenu.Equals("SubSubMenuFormComprobanteFiscal")) { SubSubMenuFormComprobanteFiscal.Enabled = true; }
                if (item.PantallasMenu.Equals("SubMenuFormFacturacion")) { SubMenuFormFacturacion.Enabled = true; }
                if (item.PantallasMenu.Equals("SubSubMenuFormHistoricoFacturacion")) { SubSubMenuFormHistoricoFacturacion.Enabled = true; }
                if (item.PantallasMenu.Equals("SubMenuFormCotizacion")) { SubMenuFormCotizacion.Enabled = true; }
                if (item.PantallasMenu.Equals("SubSubMenuFormHistoricoCotizacion")) { SubSubMenuFormHistoricoCotizacion.Enabled = true; }
                if (item.PantallasMenu.Equals("SubMenuFormConduce")) { SubMenuFormConduce.Enabled = true; }
                if (item.PantallasMenu.Equals("SubSubMenuFormHistoricoConduce")) { SubSubMenuFormHistoricoConduce.Enabled = true; }
                if (item.PantallasMenu.Equals("SubMenuFormArticulo")) { SubMenuFormArticulo.Enabled = true; }
                if (item.PantallasMenu.Equals("SubMenuFormIngresoAlmacen")) { SubMenuFormIngresoAlmacen.Enabled = true; }
                if (item.PantallasMenu.Equals("SubMenuFormInventario")) { SubMenuFormInventario.Enabled = true; }
                if (item.PantallasMenu.Equals("SubMenuReporteVenta")) { SubMenuReporteVenta.Enabled = true; }
                if (item.PantallasMenu.Equals("SubMenuReporteGananciaPerdida")) { SubMenuReporteGananciaPerdida.Enabled = true; }
                if (item.PantallasMenu.Equals("SubSubMenuFormSucursal")) { SubSubMenuFormSucursal.Enabled = true; }
                if (item.PantallasMenu.Equals("SubSubMenuFormCompania")) { SubSubMenuFormCompania.Enabled = true; }
                if (item.PantallasMenu.Equals("SubSubMenuFormFacturacion")) { SubSubMenuFormFacturacion.Enabled = true; }
                if (item.PantallasMenu.Equals("SubSubMenuFormCotizacion")) { SubSubMenuFormCotizacion.Enabled = true; }
                if (item.PantallasMenu.Equals("SubSubMenuFormConduce")) { SubSubMenuFormConduce.Enabled = true; }
            }
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes cargar = null;
            cargar = Win.FormClientes.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void nFCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedor cargar = null;
            cargar = Win.FormProveedor.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void nFCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Herramientas.FormComprobanteFiscal cargar = null;
            cargar = Herramientas.FormComprobanteFiscal.Instance();
            cargar.MdiParent = this;
            cargar.Show();
        }

        private void históricoDeFacturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoricoFacturacion cargar = null;
            cargar = Win.FormHistoricoFacturacion.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void históricoCotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones.FormHistoricoCotizacion cargar = null;
            cargar = Operaciones.FormHistoricoCotizacion.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void conduceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void históricoConduceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoricoConduce cargar = null;
            cargar = Win.FormHistoricoConduce.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void agregarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen.FormArticulo cargar = null;
            cargar = Almacen.FormArticulo.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void ingresoAlmacénToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen.FormIngresoAlmacen cargar = null;
            cargar = Almacen.FormIngresoAlmacen.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen.FormInventario cargar = null;
            cargar = Almacen.FormInventario.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void reportesDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones.ReportesBolantes.FormReporteVentaEmpleado cargar = null;
            cargar = Operaciones.ReportesBolantes.FormReporteVentaEmpleado.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //Para Deshabilitar todos los menus por defecto
            //DeshabilitarMenu();
            //Para Habilitar los menus simepre y cuando el usuario tenga permiso
            HabilitarMenu();
        }

        private void SubSubMenuFormHistoricoConduce_Click(object sender, EventArgs e)
        {
            FormHistoricoConduce cargar = null;
            cargar = FormHistoricoConduce.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void SubSubMenuFormConduce_Click(object sender, EventArgs e)
        {
            FormConduce cargar = null;
            cargar = FormConduce.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void SubMenuFormEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void SubSubMenuFormCompania_Click(object sender, EventArgs e)
        {

        }

        private void SubSubMenuFormFacturacion_Click(object sender, EventArgs e)
        {
            Operaciones.FormFacturacion cargar = null;
            cargar = Operaciones.FormFacturacion.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void SubSubMenuFormHistoricoFacturacion_Click(object sender, EventArgs e)
        {
            FormHistoricoFacturacion cargar = null;
            cargar = FormHistoricoFacturacion.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void SubSubMenuFormCotizacion_Click(object sender, EventArgs e)
        {
            Operaciones.FormCotizacion cargar = null;
            cargar = Operaciones.FormCotizacion.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void SubSubMenuFormHistoricoCotizacion_Click(object sender, EventArgs e)
        {
            Operaciones.FormHistoricoCotizacion cargar = null;
            cargar = Operaciones.FormHistoricoCotizacion.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

        private void SubMenuReporteGananciaPerdida_Click(object sender, EventArgs e)
        {
            Operaciones.ReportesBolantes.FormGananciasGatos cargar = null;
            cargar = Operaciones.ReportesBolantes.FormGananciasGatos.Instance();

            cargar.MdiParent = this;
            cargar.Show();
        }

    }
}

