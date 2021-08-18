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
    public partial class FormHistoricoFacturacion : DevComponents.DotNetBar.Office2007Form
    {
        public FormHistoricoFacturacion()
        {
            InitializeComponent();
        }
        private static FormHistoricoFacturacion frmInstance = null;
        public static FormHistoricoFacturacion Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormHistoricoFacturacion();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        IFacturaServices _presenter = new FacturaServices();
        private void FormHistoricoFacturacion_Load(object sender, EventArgs e)
        {
            var hola = _presenter.GetVistaFactura();
            dataGridViewHistoricoFactracion.DataSource = hola;
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            checkBoxCredito.Checked = false;
            checkBoxContado.Checked = false;
            if (textBoxBuscar.Text != string.Empty)
            {
                dataGridViewHistoricoFactracion.DataSource = _presenter.GetNombreIdVistaF(textBoxBuscar.Text);
            }
            else
            {
                dataGridViewHistoricoFactracion.DataSource = _presenter.GetVistaFactura();
            }
        }



        private void toolStripButtonVentaEmpleado_Click(object sender, EventArgs e)
        {
            FormReporteVentaEmpleado frm = new FormReporteVentaEmpleado();

            frm.ShowDialog();
        }

        private void toolStripButtonFactura_Click(object sender, EventArgs e)
        {
            if (checkBoxProforma.Checked == true)
            {
                var id = Convert.ToInt32(textBoxBuscar.Text);
                if (id > 0)
                {
                    FormFacturaProforma frm = new FormFacturaProforma();
                    var idft = id;
                    frm.id = idft;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Para poder imsprimir una factura debe colocar en el buscar el id de la factura que quiere imsprimir que es un numero.");
                }
            }
            else
            {
                var id = Convert.ToInt32(textBoxBuscar.Text);
                if (id > 0)
                {
                    FormFactura frm = new FormFactura();
                    var idft = id;
                    frm.id = idft;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Para poder imsprimir una factura debe colocar en el buscar el id de la factura que quiere imsprimir que es un numero.");
                }
            }


        }

        private void toolStripButtonRefrescar_Click(object sender, EventArgs e)
        {

            dataGridViewHistoricoFactracion.DataSource = _presenter.GetVistaFactura();


        }

        private void toolStripButtonAyuda_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "D:/CreateSoftLopez/CreateSoft_Ventas -Manual de Usuario.pdf");
            Process.Start(path);
        }

        private void checkBoxContado_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxContado.Checked == true)
            {
                checkBoxCredito.Checked = false;
                dataGridViewHistoricoFactracion.DataSource = _presenter.GetVistaFacturaContado();
            }
        }

        private void checkBoxCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCredito.Checked == true)
            {
                checkBoxContado.Checked = false;
                dataGridViewHistoricoFactracion.DataSource = _presenter.GetVistaFacturaCredito();
            }
        }
    }
}
