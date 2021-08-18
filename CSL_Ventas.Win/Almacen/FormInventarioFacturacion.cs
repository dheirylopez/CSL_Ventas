using CSL_Ventas.Win.Operaciones;
using CSL_Ventas.Win.Reportes;
using Entidad;
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

namespace CSL_Ventas.Win.Almacen
{
    public partial class FormInventarioFacturacion : DevComponents.DotNetBar.OfficeForm
    {
        public IContract contrato { get; set; }
        public FormInventarioFacturacion()
        {
            InitializeComponent();
        }
        IAlmacenServices _presenter = new AlmacenServices();
        private static FormInventarioFacturacion frmInstance = null;
        public static FormInventarioFacturacion Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormInventarioFacturacion();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        private void FormInventario_Load(object sender, EventArgs e)
        {
            dataGridViewInventario.DataSource = _presenter.GetInventario();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != string.Empty)
            {
                dataGridViewInventario.DataSource = _presenter.GetInveNombreId(textBoxBuscar.Text);
            }
            else
            {
                dataGridViewInventario.DataSource = _presenter.GetInventario();
            }
        }

        private void toolStripButtonReporte_Click(object sender, EventArgs e)
        {
            FormInventarioReporte frm = new FormInventarioReporte();

            frm.ShowDialog();
        }

        private void toolStripButtonRefrescar_Click(object sender, EventArgs e)
        {
            dataGridViewInventario.DataSource = _presenter.GetInventario();
        }

        private void toolStripButtonAyuda_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "D:/CreateSoftLopez/CreateSoft_Ventas -Manual de Usuario.pdf");
            Process.Start(path);
        }
        int validacionDispAlm(IEnumerable<DetalleItems> detalle)
        {


            var nodis = 0;
            foreach (var item in detalle)
            {
                var inv = _presenter.GetarticuloAlmacen(item.IdArticulo.ToString());
                if (item.IdArticulo == inv.IdItems && inv.Cantidad <= item.Cantidad)
                {
                    nodis = nodis + 1;
                }
            

            }


            return nodis;
        }


        private void dataGridViewInventario_DoubleClick(object sender, EventArgs e)
        {
            var inven = new Inventario();
            inven.Id = Convert.ToInt32(dataGridViewInventario.CurrentRow.Cells[0].Value.ToString());
            inven.IdArticulo = Convert.ToInt32(dataGridViewInventario.CurrentRow.Cells[1].Value.ToString());
            inven.Articulo = dataGridViewInventario.CurrentRow.Cells[2].Value.ToString();
            inven.Cantidad = Convert.ToInt32(dataGridViewInventario.CurrentRow.Cells[5].Value.ToString());
            inven.PrecioC = Convert.ToInt32(dataGridViewInventario.CurrentRow.Cells[6].Value.ToString());
            inven.PrecioV = Convert.ToDouble(dataGridViewInventario.CurrentRow.Cells[7].Value.ToString());
            var detalleitems = _presenter.GetDetalleItems(inven.IdArticulo);

            var disponible = validacionDispAlm(detalleitems);


            if (inven != null && disponible == 0)
            {
                label2.Text = "Selecconado";
                contrato.Ejecutar(inven);
            }
            else
            {
                MessageBox.Show(string.Format("Tiene {0} artículos que no cuentan con la cantidad solicitada, Favor verifique en almacén e ingrese la cantidad faltante.", disponible));
            }
        }
    }
}
