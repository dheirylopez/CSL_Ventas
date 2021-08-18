using CSL_Ventas.Win.Operaciones.ReportesBolantes;
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

namespace CSL_Ventas.Win.Operaciones
{
    public partial class FormHistoricoCotizacion : DevComponents.DotNetBar.Office2007Form
    {
        public FormHistoricoCotizacion()
        {
            InitializeComponent();
        }
        private static FormHistoricoCotizacion frmInstance = null;
        public static FormHistoricoCotizacion Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormHistoricoCotizacion();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        ICotizacionServices _presenter = new CotizacionServices();
        private void FormHistoricoCotizacion_Load(object sender, EventArgs e)
        {
            dataGridViewHistoricoCotizacion.DataSource = _presenter.GetVistaCotizacion();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != string.Empty)
            {
                dataGridViewHistoricoCotizacion.DataSource = _presenter.GetNombreIdVistaC(textBoxBuscar.Text);
            }
            else
            {
                dataGridViewHistoricoCotizacion.DataSource = _presenter.GetVistaCotizacion();
            }
        }

        private void toolStripButtonRefrescar_Click(object sender, EventArgs e)
        {
            dataGridViewHistoricoCotizacion.DataSource = _presenter.GetVistaCotizacion();
        }

        private void toolStripButtonImsprimir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBoxBuscar.Text);
            if (id > 0)
            {
                FormCotizacionBolante frm = new FormCotizacionBolante();
                var idft = id;
                frm.id = idft;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Para poder imsprimir una Conduce debe colocar en el buscar el id del conduce que quiere imsprimir que es un numero.");
            }
        }

        private void toolStripButtonAyuda_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "D:/CreateSoftLopez/CreateSoft_Ventas -Manual de Usuario.pdf");
            Process.Start(path);
        }
    }
}
