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
    public partial class FrmRegistroReservaciones : Form
    {
        Connection connection = new Connection();
        public FrmRegistroReservaciones()
        {
            InitializeComponent();

            CargarReservaciones();

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmRegistroNuevaReserva obj = new FrmRegistroNuevaReserva();
            obj.ShowDialog();
        }

        public async void CargarReservaciones()
        {
            try
            {
                pnlCargando.Visible = true;
                string urlFinal = "/reservas";
                string respuesta = await Task.Run(() => connection.GetHttp(urlFinal));
                pnlCargando.Visible = false;
                List<Models.VistasReservas> list = JsonConvert.DeserializeObject<List<Models.VistasReservas>>(respuesta);
                dgv_Reservaciones.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_Reservaciones.Rows[dgv_Reservaciones.CurrentRow.Index].Cells[0].Value.ToString());
            string nombre = dgv_Reservaciones.Rows[dgv_Reservaciones.CurrentRow.Index].Cells[2].Value.ToString();

            FrmEditarReserva obj = new FrmEditarReserva();
            obj.tb_NombreClie.Text = nombre;

            obj.cargarDatos(id);

            obj.ShowDialog();

        }
    }
}
