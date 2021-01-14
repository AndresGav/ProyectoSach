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
    public partial class FrmListaHabReservas : Form
    {
        Connection connection = new Connection();
        public FrmListaHabReservas()
        {
            InitializeComponent();
            pnlCargando.Visible = false;

        }

        public async void CargarHabitaciones(string fingreso, string fsalida)
        {
            try
            {
                pnlCargando.Visible = true;
                string urlFinal = "/confim_r?fechaIng_res=" + fingreso+ "&fechaSal_res=" + fsalida;
                string respuesta = await Task.Run(() => connection.GetHttp(urlFinal));
                pnlCargando.Visible = false;
                List<Models.Habitaciones> list = JsonConvert.DeserializeObject<List<Models.Habitaciones>>(respuesta);
                dgv_Habitaciones.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btn_AceptarHab_Click(object sender, EventArgs e)
        {
            
            if (dgv_Habitaciones.SelectedRows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("SELECCIONE UNA FILA");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
