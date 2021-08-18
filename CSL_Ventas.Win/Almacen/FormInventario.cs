using CSL_Ventas.Win.Reportes;
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
    public partial class FormInventario : DevComponents.DotNetBar.OfficeForm
    {
        public FormInventario()
        {
            InitializeComponent();
        }
        IAlmacenServices _presenter = new AlmacenServices();
        private static FormInventario frmInstance = null;
        public static FormInventario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormInventario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        private void FormInventario_Load(object sender, EventArgs e)
        {
            dataGridViewInventario.DataSource = _presenter.GetInventario();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != string.Empty)
            {
                dataGridViewInventario.DataSource = _presenter.GetInveNombreId(textBoxBuscar.Text);
            }
            else
            {
                dataGridViewInventario.DataSource = _presenter.GetInventario();
            }
        }

        private void toolStripButtonReporte_Click(object sender, EventArgs e)
        {
            FormInventarioReporte frm = new FormInventarioReporte();
         
            frm.ShowDialog();
        }

        private void toolStripButtonRefrescar_Click(object sender, EventArgs e)
        {
            dataGridViewInventario.DataSource = _presenter.GetInventario();
        }

        private void toolStripButtonAyuda_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "D:/CreateSoftLopez/CreateSoft_Ventas -Manual de Usuario.pdf");
            Process.Start(path);
        }

        private void dataGridViewInventario_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
