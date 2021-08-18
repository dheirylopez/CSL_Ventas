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
    public partial class FormCotizacionBolante : Form
    {
        private int _idventas;
        public int id
        {
            get { return _idventas; }
            set { _idventas = value; }
        }
        public FormCotizacionBolante()
        {
            InitializeComponent();
        }

        private void FormCotizacionBolante_Load(object sender, EventArgs e)
        {
            this.dataSetReportes.EnforceConstraints = false;
            this.viewCotizacionTableAdapter.Fill(this.dataSetReportes.ViewCotizacion, _idventas);
            this.reportViewer1.RefreshReport();
        }
    }
}
