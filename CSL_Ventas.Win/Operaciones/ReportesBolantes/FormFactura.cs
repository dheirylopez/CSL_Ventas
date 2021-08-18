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
    public partial class FormFactura : DevComponents.DotNetBar.Office2007Form
    {
        private int _idventas;
        public int id
        {
            get { return _idventas; }
            set { _idventas = value; }
        }
        public FormFactura()
        {
            InitializeComponent();
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            this.dataSetReportes.EnforceConstraints = false;
            this.volanteFacturaTableAdapter.Fill(this.dataSetReportes.VolanteFactura, _idventas);
            this.reportViewerFactura.RefreshReport();
        }
    }
}
