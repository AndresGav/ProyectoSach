using Newtonsoft.Json;
using ProyectoGestionSach.ConnectionAPI;
using ProyectoGestionSach.Formularios.Fragment;
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
    public partial class FrmEditarHabitacion : Form
    {

        Connection connection = new Connection();

        public FrmEditarHabitacion()
        {
            InitializeComponent();
        }

        public async void cargarDatos(string codigo)
        {
            try
            {
                string url = "/habitaciones/filter?id=" + codigo;
                string respuesta = await Task.Run(() => connection.GetHttp(url));
                List<Models.Habitaciones> cliente = JsonConvert.DeserializeObject<List<Models.Habitaciones>>(respuesta);

                if (cliente.Count > 0)
                {
                    tb_CodHab.Text = cliente[0].codigo_hab;
                    tb_TipoHab.Text = cliente[0].tipo_hab;
                    tb_Descrp.Text = cliente[0].descr_hab;
                    tb_TempBaja.Text = cliente[0].prcBajo.ToString();
                    tb_TempAlta.Text = cliente[0].prcAlto.ToString();

                }
                else
                {
                    MessageBox.Show("LA HABITACION NO ESTÁ REGISTRADO.");
                }
            }
            catch
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm.ReleaseCapture();
            MoverForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
