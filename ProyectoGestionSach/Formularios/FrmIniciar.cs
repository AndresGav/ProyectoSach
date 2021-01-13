using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProyectoGestionSach.ConnectionAPI;
using ProyectoGestionSach.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGestionSach
{
    public partial class FrmIniciar : Form
    {
        Connection connection = new Connection();

        public FrmIniciar()
        {
            InitializeComponent();
            
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados iniciar = new Empleados(txtUsuario.Text, txtContrasenia.Text);
                HttpResponseMessage respuesta = await Task.Run(() => connection.PostHTTP(iniciar, "/login"));
                var contents = await respuesta.Content.ReadAsStringAsync();
                dynamic json = JObject.Parse(contents);

                if (json.success == "true")
                {
                    Properties.Settings.Default.Cedula = json.cedula;
                    Properties.Settings.Default.Nombre = json.name;
                    Properties.Settings.Default.Login = true;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("" + json.msg);
                    FrmSplashView mv = new FrmSplashView();
                    this.Hide();
                    mv.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("" + json.msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN INICIAR SESION: \n"+ex.Message);
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmIniciar_Load(object sender, EventArgs e)
        {

        }
    }
}
