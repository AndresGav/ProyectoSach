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
    public partial class FrmRegistroHabitacion : Form
    {
        Connection connection = new Connection();

        public FrmRegistroHabitacion()
        {
            InitializeComponent();
            pnlCargando.Visible = true;
        }

        private async Task CargarDatosHabitacion(string urlFinal)
        {
            try
            {
                string respuesta = await Task.Run(() => connection.GetHttp(urlFinal));
                pnlCargando.Visible = false;
                List<Models.Habitaciones> list = JsonConvert.DeserializeObject<List<Models.Habitaciones>>(respuesta);
                dgv_Habitaciones.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmRegistroNuevaHabitacion obj = new FrmRegistroNuevaHabitacion();
            obj.ShowDialog();
        }

        private async void FrmRegistroHabitacion_Load(object sender, EventArgs e)
        {
            await CargarDatosHabitacion("/habitaciones");
        }
    }
}
