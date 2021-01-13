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
    public partial class ItemHabitacion : UserControl
    {
        public ItemHabitacion()
        {
            InitializeComponent();
        }
        public ItemHabitacion(string hab, string estado, string tipo)
        {
            InitializeComponent();
            lbl_Estado.Text = estado;
            lbl_TipoHab.Text = tipo;
            btn_Hab.Text = hab;
            colorEstado();
        }
        private void colorEstado()
        {
            if (lbl_Estado.Text == "DISPONIBLE")
            {
                panel1.BackColor = Color.LightGreen;
            }
            else if (lbl_Estado.Text == "OCUPADO")
            {
                panel1.BackColor = Color.Red;
            }else
            {
                panel1.BackColor = Color.Black;
            }
        }

        private void AbrirHab()
        {
            FrmRegistroAlquiler alquiler = new FrmRegistroAlquiler();
            if (lbl_Estado.Text == "DISPONIBLE")
            {
                alquiler.tb_CodHab.Text = btn_Hab.Text;
                if (alquiler.ShowDialog() == DialogResult.OK)
                {
                    panel1.BackColor = Color.Red;
                    lbl_Estado.Text = "OCUPADO";
                }
            }
            else if (lbl_Estado.Text == "OCUPADO")
            {
                alquiler.ObtenerDatosCheckOut(btn_Hab.Text);
                alquiler.tb_CodHab.Text = btn_Hab.Text;
                alquiler.btn_CheckOut.Visible = true;
                if (alquiler.ShowDialog() == DialogResult.OK)
                {
                    panel1.BackColor = Color.LightGreen;
                    lbl_Estado.Text = "DISPONIBLE";
                }
            }
        }
        private void btn_Hab_Click(object sender, EventArgs e)
        {
            AbrirHab();
            
        }
    }
}
