using Entidad;
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
    public partial class FormCierreCaja : DevComponents.DotNetBar.Office2007Form
    {
        public FormCierreCaja()
        {
            InitializeComponent();
        }
        private Empleados _empleado;
        public Empleados empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
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
        private void FormCierreCaja_Load(object sender, EventArgs e)
        {
            textBoxColaborador.Text = _empleado.Nombre;

            var cierreanterior = _presenter.GetIdCierre(DateTime.Now.AddDays(-1));
            if (cierreanterior != null)
            {

            }
            else
            {
                var resultado = MessageBox.Show("El cierre de ayer no se efectuo desea realizarlo ahora? ", "Pregunta", MessageBoxButtons.YesNo);
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    var _factura = _presenter.Get();
                    double totalFacturado = 0;
                    double pendiente = 0;
                    double Pagado = 0;
                    var cierre = new Cierre();
                    foreach (var item in _factura)
                    {
                        if (item.Fecha.Date == Convert.ToDateTime(DateTime.Now.AddDays(-1).ToString("yyy/MM/dd")))
                        {
                           
                            if (item.Pago_Inicial != 0 || item.Pago_Pendiente != 0)
                            {
                                Pagado = Pagado + item.Pago_Inicial;
                                pendiente = pendiente + item.Pago_Pendiente;
                                totalFacturado = totalFacturado + item.Total;
                            }
                            else if(item.Pago_Inicial == 0 & item.Pago_Pendiente == 0)                                                                                            
                            {
                                Pagado = Pagado + item.Total;
                                totalFacturado = totalFacturado + item.Total;

                            }
                        }

                    }
                    cierre.Fecha = Convert.ToDateTime(DateTime.Now.AddDays(-1).ToString("yyy/MM/dd"));
                    cierre.IdCaja = 1;
                    cierre.Monto_Inicial_Caja = 0;
                    cierre.Colaborador = _empleado.Id;
                    cierre.Total_Facturado = totalFacturado;
                    cierre.Total_Pagado = Pagado;
                    cierre.Total_Pendiente = pendiente;
                    cierre.Estatus = 1;
                    _presenter.AddCierre(cierre);
                    var idcierre = _presenter.GetIdCierre();
                    FormReporteCierre frm = new FormReporteCierre();
                    var idcr =idcierre.Id;
                    frm.id = idcr;
                    frm.ShowDialog();
                 
                }
                else
                {
                    MessageBox.Show("No puede cerrar un dia si tiene el otro pendiente de cierre. ");
                }
                Limpiar();
            }
        }


        void Limpiar()
        {
            textBoxMontoInicial.Text = string.Empty;
            textBoxIdCaja.Text = string.Empty;
            textBoxId.Text = string.Empty;
        }
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                var _factura = _presenter.Get();
                double totalFacturado = 0;
                double pendiente = 0;
                double Pagado = 0;
                var cierre = new Cierre();
                if (textBoxMontoInicial.Text == string.Empty || textBoxIdCaja.Text == string.Empty)
                {
                    MessageBox.Show("Debe llenar el monto inicial y y digitar el numero de la caja.");
                }
                else
                {
                    var _cierreupdate = _presenter.GetIdCierre(DateTime.Now.Date);
                    if (_cierreupdate != null)
                    {
                        foreach (var item in _factura)
                        {
                            if (item.Fecha.Date ==DateTime.Now.Date)
                            {
                                if (item.Pago_Inicial != 0 || item.Pago_Pendiente != 0)
                                {
                                    Pagado = Pagado + item.Pago_Inicial;
                                    pendiente = pendiente + item.Pago_Pendiente;
                                    totalFacturado = totalFacturado + item.Total;
                                }
                                else if (item.Pago_Inicial == 0 & item.Pago_Pendiente == 0)
                                {
                                    Pagado = Pagado + item.Total;
                                    totalFacturado = totalFacturado + item.Total;

                                }
                            }
                        }

                        cierre.Fecha = Convert.ToDateTime(DateTime.Now.Date.ToString("yyy/MM/dd"));
                        cierre.IdCaja = Convert.ToInt32(textBoxIdCaja.Text);
                        cierre.Monto_Inicial_Caja = Convert.ToInt32(textBoxMontoInicial.Text);
                        cierre.Colaborador = _empleado.Id;
                        cierre.Total_Facturado = totalFacturado;
                        cierre.Total_Pagado = Pagado;
                        cierre.Total_Pendiente = pendiente;
                        cierre.Estatus = 1;
                        cierre.Id = _cierreupdate.Id;
                        _presenter.UpdateCierre(cierre);
                    }
                    else
                    {
                        foreach (var item in _factura)
                        {
                            if (item.Fecha.Date == DateTime.Now.Date)
                            {
                                if (item.Pago_Inicial != 0 || item.Pago_Pendiente != 0)
                                {
                                    Pagado = Pagado + item.Pago_Inicial;
                                    pendiente = pendiente + item.Pago_Pendiente;
                                    totalFacturado = totalFacturado + item.Total;
                                }
                                else if (item.Pago_Inicial == 0 & item.Pago_Pendiente == 0)
                                {
                                    Pagado = Pagado + item.Total;
                                    totalFacturado = totalFacturado + item.Total;

                                }
                            }

                        }
                        cierre.Fecha = Convert.ToDateTime(DateTime.Now.Date.ToString("yyy/MM/dd"));
                        cierre.IdCaja = Convert.ToInt32(textBoxIdCaja.Text);
                        cierre.Monto_Inicial_Caja = Convert.ToInt32(textBoxMontoInicial.Text);
                        cierre.Colaborador = _empleado.Id;
                        cierre.Total_Facturado = totalFacturado;
                        cierre.Total_Pagado = Pagado;
                        cierre.Total_Pendiente = pendiente;
                        cierre.Estatus = 1;
                        _presenter.AddCierre(cierre);


                    }


                    MessageBox.Show("Cierre realizado corectamente.");
                 
                    var idcierre = _presenter.GetIdCierre();
                    FormReporteCierre frm = new FormReporteCierre();
                    var idcr = idcierre.Id;
                    frm.id = idcr;
                    frm.ShowDialog();

                    Limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Ocurrio un error comunicarse con el probeedor del sistema:{0}", ex.ToString()));
            }

        }

        private void buttonAbrirCaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxId.Text != string.Empty)
                {
                    var cierre = _presenter.GetIdCierre(Convert.ToInt32(textBoxId.Text));

                    cierre.Estatus = 0;
                    cierre.Colaborador = _empleado.Id;
                    _presenter.UpdateCierre(cierre);
                    MessageBox.Show(string.Format("Se aperturo el cierre de factura del codigo: {0}", cierre.Id.ToString()));
                }
                Limpiar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Ocurrio un error comunicarse con el probeedor del sistema:{0}", ex.ToString()));
            }

        }

    }

}
