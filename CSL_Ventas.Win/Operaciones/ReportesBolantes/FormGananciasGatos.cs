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
    public partial class FormGananciasGatos : DevComponents.DotNetBar.Office2007Form
    {
        public FormGananciasGatos()
        {
            InitializeComponent();
        }
        private static FormGananciasGatos frmInstance = null;
        public static FormGananciasGatos Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormGananciasGatos();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        private void FormGananciasGatos_Load(object sender, EventArgs e)
        {


        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.dataSetReportes.EnforceConstraints = false;

            var desde = dateTimePickerDesde.Value.ToString("yyyy/MM/dd");
            var hasta = dateTimePickerHasta.Value.ToString("yyyy/MM/dd");
            this.view_Ganancias_GastosTableAdapter.Fill(dataSetReportes.View_Ganancias_Gastos, desde, hasta);
            this.reportViewerGanancias.RefreshReport();
        }
    }
}
