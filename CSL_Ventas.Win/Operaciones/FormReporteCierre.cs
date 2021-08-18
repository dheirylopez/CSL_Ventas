using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSL_Ventas.Win.Operaciones
{
    public partial class FormReporteCierre : DevComponents.DotNetBar.Office2007Form
    {
        public FormReporteCierre()
        {
            InitializeComponent();
        }
        private int _idcierre;
        public int id
        {
            get { return _idcierre; }
            set { _idcierre = value; }
        }
        private void FormReporteCierre_Load(object sender, EventArgs e)
        {
            this.DataSetReportes.EnforceConstraints = false;
            this.CierreDiaTableAdapter.Fill(this.DataSetReportes.CierreDia, _idcierre);
            this.reportViewerCierreDia.RefreshReport();
        }
    }
}
