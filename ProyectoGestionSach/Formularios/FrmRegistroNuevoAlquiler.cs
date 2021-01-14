using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProyectoGestionSach.ConnectionAPI;
using ProyectoGestionSach.Formularios.Fragment;
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
    public partial class FrmRegistroAlquiler : Form
    {
        Connection connection = new Connection();
        int _dias = 0;
        double total = 0;
        int _idHab;

        public FrmRegistroAlquiler()
        {
            InitializeComponent();
            cb_Temp.SelectedIndex = 0;
            lb_NombreEmp.Text = Properties.Settings.Default.Nombre;
            pnlCargando.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public async void ObtenerDatosCheckOut(string codHab)
        {
            try
            {
                tb_CedCli.Enabled = false;
                tb_NombreClie.Visible = true;
                dt_FIngreso.Enabled = false;
                cb_Temp.Enabled = false;
                btn_Alquilar.Visible = false;
                pnlCargando.Visible = true;
                string respuesta = await Task.Run(() => connection.GetHttp("/habitaciones/checkout?code=" + codHab));
                List<Alquileres> checkOut = JsonConvert.DeserializeObject<List<Alquileres>>(respuesta);
                pnlCargando.Visible = false;
                if (checkOut.Count > 0)
                {
                    _idHab = checkOut[0].id_alquiler;
                    tb_CedCli.Text = checkOut[0].cedula_cliA;
                    tb_NombreClie.Text = checkOut[0].nombreClie;
                    dt_FIngreso.Text = checkOut[0].fechaIng_alq;
                    dt_FSalida.Text = checkOut[0].fechaSal_alq;
                    tb_CodHab.Text = checkOut[0].codigo_habA;
                    lbl_Dias.Text = "Num Días: " + checkOut[0].numDias_alq;
                    lbl_Total.Text = "Total a pagar: " + checkOut[0].prcTotal_alq;
                    cb_Temp.Text = checkOut[0].temp_alq;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN MOSTRAR DATOS: \n" + ex.Message);
            }
            
        }

        private void obtenerDias()
        {
            DateTime fInicio = dt_FIngreso.Value.Date;
            DateTime fSalida = dt_FSalida.Value.Date;
            TimeSpan dias = fSalida - fInicio;
            _dias = dias.Days;

            if (_dias == 0)
            {
                _dias += 1;
            }
            lbl_Dias.Text = "Num Días: " + _dias;
        }

        private async void CalcularTotal()
        {
            try
            {
                total = 0;
                double precioHab = 0;

                string respuesta = await Task.Run(() => connection.GetHttp("/habitaciones/filter?code=" + tb_CodHab.Text));
                List<Habitaciones> hab = JsonConvert.DeserializeObject<List<Habitaciones>>(respuesta);
                if (cb_Temp.SelectedIndex == 0)
                {
                    precioHab = hab[0].prcBajo;
                }
                else
                {
                    precioHab = hab[0].prcAlto;
                }
                total = _dias * precioHab;
                lbl_Total.Text = "Total a pagar: " + total;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR OBTENER PRECIO: \n " + ex.Message);
            }
            
        }

        private async void tb_CedCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    tb_NombreClie.Visible = true;
                    string respuesta = await Task.Run(() => connection.GetHttp("/clientes/filter?like=" + tb_CedCli.Text));
                    List<Clientes> cliente = JsonConvert.DeserializeObject<List<Clientes>>(respuesta);
                    if (cliente.Count>0)
                    {
                        tb_NombreClie.Text = cliente[0].apellido_cli + " " + cliente[0].nombre_cli;
                    }
                    else
                    {
                        MessageBox.Show("EL CLIENTE NO ESTÁ REGISTRADO.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR OBTENER DATOS CLIENTE: \n" + ex.Message);
                }
            }
        }

        private void dt_FSalida_ValueChanged(object sender, EventArgs e)
        {
            obtenerDias();
            btn_Actualizar.Visible = true;
        }

        private void cb_Temp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void lbl_Dias_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_Alquilar_Click(object sender, EventArgs e)
        {
            try
            {
                Alquileres alquilar = new Alquileres()
                {
                    cedula_cliA = tb_CedCli.Text,
                    codigo_habA = tb_CodHab.Text,
                    cedula_empA = Properties.Settings.Default.Cedula,
                    fechaIng_alq = dt_FIngreso.Text,
                    fechaSal_alq = dt_FSalida.Text,
                    numDias_alq = _dias,
                    temp_alq = cb_Temp.SelectedItem.ToString(),
                    prcTotal_alq = total,
                    estado_alq = "O"
                };
                HttpResponseMessage respuesta = await Task.Run(() => connection.PostHTTP(alquilar, "/alquilar"));
                var contents = await respuesta.Content.ReadAsStringAsync();
                dynamic json = JObject.Parse(contents);

                if (json.success == "true")
                {
                    MessageBox.Show("" + json.msg);
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("" + json.msg);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR REGISTRO ALQUILER: \n" + ex.Message);
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm.ReleaseCapture();
            MoverForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmRegistroAlquiler_Load(object sender, EventArgs e)
        {
            dt_FIngreso.Format = DateTimePickerFormat.Custom;
            dt_FIngreso.CustomFormat = "yyyy-MM-dd";
            dt_FSalida.Format = DateTimePickerFormat.Custom;
            dt_FSalida.CustomFormat = "yyyy-MM-dd";
        }

        private async void btn_CheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(""+_idHab+ " "+tb_CodHab.Text);
                Alquileres checkout = new Alquileres { 
                    id_alquiler = _idHab, 
                    codigo_habA = tb_CodHab.Text 
                };
                HttpResponseMessage respuesta = await Task.Run(() => connection.UpdateHTTP(checkout, "/alquiler/update"));
                var contents = await respuesta.Content.ReadAsStringAsync();
                dynamic json = JObject.Parse(contents);
                if (json.success == "true")
                {
                    MessageBox.Show("" + json.msg);
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("" + json.msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR REGISTRO ALQUILER: \n" + ex.Message);
            }
            
        }

    }
}
