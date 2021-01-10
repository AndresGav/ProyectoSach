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
            if (lbl_Estado.Text == "D")
            {
                panel1.BackColor = Color.LightGreen;
            }
            else if (lbl_Estado.Text == "O")
            {
                panel1.BackColor = Color.Red;
            }
        }
        private void btn_Hab_Click(object sender, EventArgs e)
        {
            FrmRegistroAlquiler alquiler = new FrmRegistroAlquiler();
            alquiler.ShowDialog();
        }
    }
}
