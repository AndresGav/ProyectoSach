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
    public partial class FrmRegistroHabitacion : Form
    {
        public FrmRegistroHabitacion()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmRegistroNuevaHabitacion obj = new FrmRegistroNuevaHabitacion();
            obj.ShowDialog();
        }
    }
}
