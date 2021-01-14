using Newtonsoft.Json;
using ProyectoGestionSach.ConnectionAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGestionSach
{
    public partial class FrmRegistroHuesped : Form
    {
        Connection connection = new Connection();

        public FrmRegistroHuesped()
        {
            InitializeComponent();
            pnlCargando.Visible = false;
        }

        private async Task CargarDatosClientes(string urlFinal)
        {
            try
            {
                pnlCargando.Visible = true;
                string respuesta = await Task.Run(() => connection.GetHttp(urlFinal));
                pnlCargando.Visible = false;
                List<Models.Clientes> list = JsonConvert.DeserializeObject<List<Models.Clientes>>(respuesta);
                dgv_Huespedes.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmRegistroNuevoHuesped obj = new FrmRegistroNuevoHuesped();
            obj.ShowDialog();
        }

        private async void FrmRegistroHuesped_Load(object sender, EventArgs e)
        {
            await CargarDatosClientes("/clientes");
        }

        private async void tb_CedCli_TextChanged(object sender, EventArgs e)
        {
            
            await CargarDatosClientes("/clientes/filter?like="+tb_CedCli.Text);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            string cedula = dgv_Huespedes.Rows[dgv_Huespedes.CurrentRow.Index].Cells[0].Value.ToString();

            FrmEditarHuesped obj = new FrmEditarHuesped();

            obj.cargarDatos(cedula);

            obj.ShowDialog();
        }
    }
}
