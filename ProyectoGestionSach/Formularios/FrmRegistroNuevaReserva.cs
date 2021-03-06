﻿using Newtonsoft.Json;
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
    public partial class FrmRegistroNuevaReserva : Form
    {
        Connection connection = new Connection();
        int _dias = 0;
        double total = 0;
        double saldo = 0;

        public FrmRegistroNuevaReserva()
        {
            InitializeComponent();
            cb_Temp.SelectedIndex = 1;
            lb_NombreEmp.Text = Properties.Settings.Default.Nombre;
            dt_FRegistro.Format = DateTimePickerFormat.Custom;
            dt_FRegistro.CustomFormat = "yyyy-MM-dd";
            dt_FIngreso.Format = DateTimePickerFormat.Custom;
            dt_FIngreso.CustomFormat = "yyyy-MM-dd";
            dt_FSalida.Format = DateTimePickerFormat.Custom;
            dt_FSalida.CustomFormat = "yyyy-MM-dd";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm.ReleaseCapture();
            MoverForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dt_FSalida_ValueChanged(object sender, EventArgs e)
        {
            //obtenerDias();
        }

        private void cb_Temp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void lbl_Dias_TextChanged(object sender, EventArgs e)
        {
            //CalcularTotal();
        }

        private async void tb_CedCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string respuesta = await Task.Run(() => connection.GetHttp("/clientes/filter?like=" + tb_CedCli.Text));
                    List<Clientes> cliente = JsonConvert.DeserializeObject<List<Clientes>>(respuesta);
                    if (cliente.Count > 0)
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

        private void btn_BuscarHab_Click(object sender, EventArgs e)
        {
            FrmListaHabReservas lista = new FrmListaHabReservas();
            lista.CargarHabitaciones(dt_FIngreso.Text,dt_FSalida.Text);
            if (lista.ShowDialog() == DialogResult.OK)
            {
                tb_CodHab.Text = lista.dgv_Habitaciones.Rows[lista.dgv_Habitaciones.CurrentRow.Index].Cells[0].Value.ToString();
                obtenerDias();
                CalcularTotal();
            }

        }

        private async void btn_Alquilar_Click(object sender, EventArgs e)
        {
            try
            {


                Reservas reservar = new Reservas()
                {

                    cedula_cliR = tb_CedCli.Text,
                    codigo_habR = tb_CodHab.Text,
                    cedula_empR = Properties.Settings.Default.Cedula,
                    fechaReg_res = dt_FRegistro.Text,
                    fechaIng_res = dt_FIngreso.Text,
                    fechaSal_res = dt_FSalida.Text,
                    numDias_res = _dias,
                    prcTotal_res = total,
                    abono_res = double.Parse(tb_Abono.Text),
                    saldo_res = saldo,
                    estado_res = estadoReserva().ToString()

                };


                HttpResponseMessage respuesta = await Task.Run(() => connection.PostHTTP(reservar, "/reservar"));
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
                MessageBox.Show("ERROR REGISTRO RESERVA: \n" + ex.Message);
            }
        }

        private char estadoReserva()
        {

            if (total == saldo)
                return 'P';
            else
                return 'C';
            
        }

        private void tb_Abono_TextChanged(object sender, EventArgs e)
        {
            try
            {
        
                saldo = total - double.Parse(tb_Abono.Text);
                lbl_Saldo.Text = "Saldo: " + saldo;
            }
            catch
            {
                
            }
            
        }
    }
}
