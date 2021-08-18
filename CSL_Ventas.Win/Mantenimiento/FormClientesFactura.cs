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

namespace CSL_Ventas.Win
{
    public partial class FormClientesFactura : DevComponents.DotNetBar.OfficeForm
    {
        public IContract contrato { get; set; }
        private readonly IClientesServices _presenter = new ClientesServices();
        public FormClientesFactura()
        {
            InitializeComponent();
        }
        private static FormClientes frmInstance = null;
        public static FormClientes Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormClientes();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        private void FormClientes_Load(object sender, EventArgs e)
        {
            var cliente = _presenter.Get();
            dataGridViewCliente.DataSource = cliente;
        }
        int id;
        void Limpiar()
        {
            textBoxBuscar.Text = string.Empty;
          
        }


    

        private void dataGridViewCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _cli = new Clientes();

            _cli.Id = Convert.ToInt32(dataGridViewCliente.CurrentRow.Cells[0].Value);
            _cli.Nombre = dataGridViewCliente.CurrentRow.Cells[1].Value.ToString();
            _cli.TipoD = dataGridViewCliente.CurrentRow.Cells[3].Value.ToString();
            _cli.NDocumento = dataGridViewCliente.CurrentRow.Cells[4].Value.ToString();
            _cli.Telefono = dataGridViewCliente.CurrentRow.Cells[5].Value.ToString();
            _cli.Direccion = dataGridViewCliente.CurrentRow.Cells[6].Value.ToString();
            _cli.Email = dataGridViewCliente.CurrentRow.Cells[7].Value.ToString();
          

            if(_cli != null)
            {
                label1.Text = "Selecconado";
                contrato.Ejecutar(_cli);
            }
        }

  

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != string.Empty)
            {
                dataGridViewCliente.DataSource = _presenter.GetNombreId(textBoxBuscar.Text);
            }
            else
            {
                dataGridViewCliente.DataSource = _presenter.Get();
            }
        }
    }
}
