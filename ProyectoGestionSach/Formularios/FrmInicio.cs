﻿using Newtonsoft.Json;
using ProyectoGestionSach.ConnectionAPI;
using ProyectoGestionSach.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGestionSach
{
    public partial class FrmInicio : Form
    {
        Connection connection = new Connection();
        public ArrayList lista = new ArrayList();

        public FrmInicio()
        {
            InitializeComponent();
            pnlCargando.Visible = false;
        }
        string respuesta = "";// = await connection.GetHttp(urlFinal);
        public async Task CargarHabitaciones(string urlFinal)
        {
            try
            {
                
                pnlCargando.Visible = true;
                respuesta = await Task.Run(()=> connection.GetHttp(urlFinal));
                List<Habitaciones> list = JsonConvert.DeserializeObject<List<Habitaciones>>(respuesta);
                pnlCargando.Visible = false;
                pnlContenedor.Controls.Clear();
                foreach (Habitaciones hab in list)
                {
                    pnlContenedor.Controls.Add(new ItemHabitacion(hab.codigo_hab, hab.estado_hab, hab.tipo_hab));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private async void FrmInicio_Load(object sender, EventArgs e)
        {
            await CargarHabitaciones("/habitaciones");
        }
    }
}
