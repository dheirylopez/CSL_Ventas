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

namespace CSL_Ventas.Win
{
    public partial class FormHistoricoConduce : DevComponents.DotNetBar.Office2007Form
    {
        private static FormHistoricoConduce frmInstance = null;
        public static FormHistoricoConduce Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormHistoricoConduce();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        IConduceServices _presenter = new ConduceServices();
        public FormHistoricoConduce()
        {
            InitializeComponent();
        }

        private void FormHistoricoConduce_Load(object sender, EventArgs e)
        {
            dataGridViewHistoricoConduce.DataSource = _presenter.GetVistaConduce();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != string.Empty)
            {
                dataGridViewHistoricoConduce.DataSource = _presenter.GetNombreIdVistaC(textBoxBuscar.Text);
            }
            else
            {
                dataGridViewHistoricoConduce.DataSource = _presenter.GetVistaConduce();
            }
        }

        private void toolStripButtonRefrescar_Click(object sender, EventArgs e)
        {
            dataGridViewHistoricoConduce.DataSource = _presenter.GetVistaConduce();
        }

        private void toolStripButtonImsprimir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBoxBuscar.Text);
            if (id > 0)
            {
                FormConduceVolante frm = new FormConduceVolante();
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
