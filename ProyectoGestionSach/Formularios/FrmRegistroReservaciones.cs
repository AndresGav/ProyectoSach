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
    public partial class FrmRegistroReservaciones : Form
    {
        public FrmRegistroReservaciones()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmRegistroNuevaReserva obj = new FrmRegistroNuevaReserva();
            obj.ShowDialog();
        }
    }
}
