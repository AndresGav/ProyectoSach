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
    public partial class FrmEditarReserva : Form
    {

        Connection connection = new Connection();

        public FrmEditarReserva()
        {
            InitializeComponent();

            
        }

        public async void cargarDatos(int id)
        {
            try
            {
                string url = "/reservas/filter?id=" + id;
                string respuesta = await Task.Run(() => connection.GetHttp(url));
                List<Models.Reservas> cliente = JsonConvert.DeserializeObject<List<Models.Reservas>>(respuesta);

                if (cliente.Count > 0)
                {
                    tb_CedCli.Text = cliente[0].cedula_cliR;
                    dt_FRegistro.Text = cliente[0].fechaReg_res;
                    dt_FIngreso.Text = cliente[0].fechaIng_res;
                    dt_FSalida.Text = cliente[0].fechaSal_res;
                    //cb_Temp.Text = ;
                    tb_CodHab.Text = cliente[0].codigo_habR;
                    lbl_Dias.Text = "Num Días: " + cliente[0].numDias_res.ToString();
                    lb_NombreEmp.Text = Properties.Settings.Default.Nombre;
                    lbl_Total.Text = cliente[0].prcTotal_res.ToString();
                    lbl_Saldo.Text = "Saldo: " + cliente[0].saldo_res;

                }
                else
                {
                    MessageBox.Show("EL CLIENTE NO ESTÁ REGISTRADO.");
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm.ReleaseCapture();
            MoverForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
