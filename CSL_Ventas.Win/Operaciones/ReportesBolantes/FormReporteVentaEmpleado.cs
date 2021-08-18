using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSL_Ventas.Win.Operaciones.ReportesBolantes
{
    public partial class FormReporteVentaEmpleado : DevComponents.DotNetBar.Office2007Form
    {
        public FormReporteVentaEmpleado()
        {
            InitializeComponent();
        }
        private static FormReporteVentaEmpleado frmInstance = null;
        public static FormReporteVentaEmpleado Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormReporteVentaEmpleado();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        private void FormReporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetReportes.View_Inventario' table. You can move, or remove it, as needed.

            
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.dataSetReportes.EnforceConstraints = false;
            var desde = dateTimePickerDesde.Value.ToString("yyyy/MM/dd");
            var hasta = dateTimePickerHasta.Value.ToString("yyyy/MM/dd");
            this.view_VentaEmpleadoTableAdapter.Fill(this.dataSetReportes.View_VentaEmpleado, textBoxEmpleado.Text,desde,hasta );
            this.reportViewer1.RefreshReport();

        }
    }
}
