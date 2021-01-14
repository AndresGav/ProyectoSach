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
    public partial class FrmEditarUsuario : Form
    {
        Connection connection = new Connection();

        public FrmEditarUsuario()
        {
            InitializeComponent();
        }

        public async void cargarDatos(string cedula)
        {
            try
            {
                string url = "/empleados/filter?cedula=" + cedula;
                string respuesta = await Task.Run(() => connection.GetHttp(url));
                List<Models.Empleados> cliente = JsonConvert.DeserializeObject<List<Models.Empleados>>(respuesta);

                if (cliente.Count > 0)
                {
                    tb_CedulaCl.Text = cliente[0].cedula_emp;
                    tb_NombreCl.Text = cliente[0].nombre_emp;
                    tb_ApellidoCl.Text = cliente[0].apellido_emp;
                    txtCargosEmp.Text = cliente[0].cargo_emp;
                    tb_DireccionCl.Text = cliente[0].direccion_emp;
                    tb_TlfnCl.Text = cliente[0].telefono_emp;
                    txtUsuario.Text = cliente[0].usuario;
                    txtPassword.Text = cliente[0].password;
                    txtEstado.Text = cliente[0].status.ToString();

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
