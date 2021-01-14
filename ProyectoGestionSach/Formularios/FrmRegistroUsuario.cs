using Newtonsoft.Json;
using ProyectoGestionSach.ConnectionAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGestionSach
{
    public partial class FrmRegistroUsuario : Form
    {
        Connection connection = new Connection();

        public FrmRegistroUsuario()
        {
            InitializeComponent();
            pnlCargando.Visible = true;
        }

        private async Task CargarDatosUsuarios(string urlFinal)
        {
            try
            {
                string respuesta = await Task.Run(() => connection.GetHttp(urlFinal));
                pnlCargando.Visible = false;
                List<Models.Empleados> list = JsonConvert.DeserializeObject<List<Models.Empleados>>(respuesta);
                dgv_Empleados.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmRegistroNuevoUsuario obj = new FrmRegistroNuevoUsuario();
            obj.ShowDialog();
        }

        private async void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {
            await CargarDatosUsuarios("/empleados");
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            string cedula = dgv_Empleados.Rows[dgv_Empleados.CurrentRow.Index].Cells[0].Value.ToString();
            FrmEditarUsuario obj = new FrmEditarUsuario();

            obj.cargarDatos(cedula);

            obj.ShowDialog();

        }
    }
}
