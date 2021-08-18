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

namespace CSL_Ventas.Win.Herramientas
{
    public partial class FormComprobanteFiscal : DevComponents.DotNetBar.OfficeForm
    {
        public FormComprobanteFiscal()
        {
            InitializeComponent();
        }

        INCFServices _presenter = new NCFServices();
        private static FormComprobanteFiscal frmInstance = null;
        public static FormComprobanteFiscal Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FormComprobanteFiscal();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        private void FormComprobanteFiscal_Load(object sender, EventArgs e)
        {
            dataGridViewComprobantes.DataSource = _presenter.Get();
        }
        void Limpiar()
        {
            textBoxCodigo.Text = string.Empty;
            comboBoxTipo.Text = string.Empty;
            dateTimePickerEmision.Value = DateTime.Now;
            dateTimePickerVencimiento.Value = DateTime.Now;
            id = 0;
            comboBoxTipo.Enabled = true;
            textBoxCodigo.ReadOnly = false;
        }
        int id;
        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCodigo.Text != string.Empty && comboBoxTipo.SelectedIndex > 0
                             && dateTimePickerEmision.MinDate > DateTime.MinValue && dateTimePickerVencimiento.MinDate > DateTime.MinValue)
                {
                    var entidad = new NCF();
                    entidad.Codigo = textBoxCodigo.Text;
                    entidad.Tipo = comboBoxTipo.Text;
                    entidad.Estatus = Convert.ToInt32(checkBoxStatus.Checked);
                    entidad.FechaEmision = dateTimePickerEmision.Value;
                    entidad.FechaVencimiento = dateTimePickerVencimiento.Value;
                    entidad.id = id;
                    entidad.FechaUso = dateTimePickerEmision.Value;

                    if (id > 0)
                    {
                        _presenter.Update(entidad);
                        MessageBox.Show("El registro fue actualizado satisfactoriamente.");
                    }
                    else
                    {
                        _presenter.Add(entidad);
                        MessageBox.Show("El registro se ingreso satisfactoriamente.");
                    }
                }
                else
                {
                    MessageBox.Show("debe llenar todos los campos requeridos.");
                }

                Limpiar();

                dataGridViewComprobantes.DataSource = _presenter.Get();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("A ocurrido un error al realizar la operacion comuniquese con su proveedor del sistema erro:{0} ", ex.ToString()));
            }
        }

        private void dataGridViewComprobantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxTipo.Enabled = false;
            textBoxCodigo.ReadOnly = true;
            id = Convert.ToInt32(dataGridViewComprobantes.CurrentRow.Cells[0].Value);
            textBoxCodigo.Text = dataGridViewComprobantes.CurrentRow.Cells[1].Value.ToString();
            comboBoxTipo.Text = dataGridViewComprobantes.CurrentRow.Cells[2].Value.ToString();
            checkBoxStatus.Checked = Convert.ToBoolean(dataGridViewComprobantes.CurrentRow.Cells[3].Value);
            dateTimePickerEmision.Value = Convert.ToDateTime(dataGridViewComprobantes.CurrentRow.Cells[4].Value);
            dateTimePickerVencimiento.Value = Convert.ToDateTime(dataGridViewComprobantes.CurrentRow.Cells[5].Value);

        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            comboBoxTipo.Enabled = false;
            textBoxCodigo.ReadOnly = true;
            id = Convert.ToInt32(dataGridViewComprobantes.CurrentRow.Cells[0].Value);
            textBoxCodigo.Text = dataGridViewComprobantes.CurrentRow.Cells[1].Value.ToString();
            comboBoxTipo.Text = dataGridViewComprobantes.CurrentRow.Cells[2].Value.ToString();
            checkBoxStatus.Checked = Convert.ToBoolean(dataGridViewComprobantes.CurrentRow.Cells[3].Value);
            dateTimePickerEmision.Value = Convert.ToDateTime(dataGridViewComprobantes.CurrentRow.Cells[4].Value);
            dateTimePickerVencimiento.Value = Convert.ToDateTime(dataGridViewComprobantes.CurrentRow.Cells[5].Value);
        }
    }
}
