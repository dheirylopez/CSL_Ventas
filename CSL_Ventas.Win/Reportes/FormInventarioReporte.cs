using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSL_Ventas.Win.Reportes
{
    public partial class FormInventarioReporte : DevComponents.DotNetBar.OfficeForm
    {
        public FormInventarioReporte()
        {
            InitializeComponent();
        }

        private void FormInventarioReporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetReportes.View_Inventario' table. You can move, or remove it, as needed.
            this.view_InventarioTableAdapter.Fill(this.dataSetReportes.View_Inventario);

            this.reportViewerInventario.RefreshReport();
        }
    }
}
