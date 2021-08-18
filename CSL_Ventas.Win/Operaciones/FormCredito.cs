using Servicios;
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
    public partial class FormCredito : DevComponents.DotNetBar.Office2007Form
    {
        public FormCredito()
        {
            InitializeComponent();
        }
        IFacturaServices _presenter = new FacturaServices();

        private static FormCredito frmInstance = null;
        public static FormCredito Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormCredito();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void FormCredito_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            var factura = _presenter.GetId(Convert.ToInt32(textBoxIdFactura.Text));

            textBoxMontoInicial.Text = factura.Pago_Inicial.ToString();
            textBoxMontoPendiente.Text = factura.Pago_Pendiente.ToString();
            textBoxTotal.Text = factura.Total.ToString();

        }
        void limpiar()
        {
            textBoxMontoInicial.Text = string.Empty;
            textBoxMontoPendiente.Text = string.Empty;
            textBoxTotal.Text = string.Empty;
            textBoxIdFactura.Text = string.Empty;
            textBoxPago.Text = string.Empty;
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            try
            {

                var factura = _presenter.GetId(Convert.ToInt32(textBoxIdFactura.Text));

                if (factura.Pago_Pendiente == 0)
                {
                    factura.Estatus = 0;
                }
                else
                {
                    factura.Pago_Pendiente = factura.Pago_Pendiente - Convert.ToInt32(textBoxPago.Text);
                }
                _presenter.Update(factura);
                limpiar();
                MessageBox.Show("Se realizo el pago de manera satisfactoria.");

            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Ocurrio un error comunicarse con el probeedor del sistema:{0}", ex.ToString()));
            }




        }
    }
}
