using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            ListarCliente();
            gb_area.Enabled = false;
            txtb_cliente.Enabled = false;
            btn_add.Enabled = false;
            btn_modify.Enabled = false;
            dgvCliente.ReadOnly = true;
        }

        public void ListarCliente()
        {
            dgvCliente.DataSource = LogCliente.Instancia.ListarCliente();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            try
            {
                var c = new Cliente
                {
                    IdCliente = int.Parse(txtb_cliente.Text.Trim()),
                    RazonSocial = txtb_razonsocial.Text.Trim(),
                    IdTipoCliente = int.Parse(txtb_tipoCliente.Text.Trim()),
                    FechaRegistro = dtp_fechaRegistro.Value,
                    IdCiudad = int.Parse(txt_ciudad.Text.Trim()),
                    Estado = cb_estadoCliente.Checked
                };

                LogCliente.Instancia.EditarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error" + ex);
            }

            ListarCliente();
            dgvCliente.Update();
            dgvCliente.Refresh();
            gb_area.Enabled = false;
            CleanData();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            gb_area.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var c = new Cliente
                {
                    RazonSocial = txtb_razonsocial.Text.Trim(),
                    IdTipoCliente = int.Parse(txtb_tipoCliente.Text.Trim()),
                    FechaRegistro = dtp_fechaRegistro.Value,
                    IdCiudad = int.Parse(txt_ciudad.Text.Trim()),
                    Estado = cb_estadoCliente.Checked
                };

                LogCliente.Instancia.InsertarCliente(c);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(@"Error" + ex);
            }

            ListarCliente();
            dgvCliente.Update();
            dgvCliente.Refresh();
            gb_area.Enabled = false;
            CleanData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            gb_area.Enabled = true;

            if (dgvCliente.CurrentRow != null)
            {
                var idCliente = dgvCliente.CurrentRow.Cells["IdCliente"].Value.ToString();
                var cliente = Cliente.Search(int.Parse(idCliente), LogCliente.Instancia.ListarCliente());

                txtb_cliente.Text = idCliente;
                txt_ciudad.Text = cliente.IdCiudad.ToString();
                txtb_razonsocial.Text = cliente.RazonSocial;
                txtb_tipoCliente.Text = cliente.IdTipoCliente.ToString();
                dtp_fechaRegistro.Value = cliente.FechaRegistro;
                cb_estadoCliente.Checked = cliente.Estado;
            }

            btn_modify.Enabled = true;
        }

        private void CleanData()
        {
            txt_ciudad.Text = "";
            txtb_cliente.Text = "";
            txtb_razonsocial.Text = "";
            txtb_tipoCliente.Text = "";
            cb_estadoCliente.Checked = false;
            btn_modify.Enabled = false;
            btn_add.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            CleanData();
            gb_area.Enabled = false;
        }

        private void btn_disable_Click(object sender, EventArgs e)
        {
            foreach (var row in dgvCliente.Rows)
            {
                //if (Convert)
                
            }
        }
    }
}
