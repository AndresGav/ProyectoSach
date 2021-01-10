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
    public partial class FrmIniciar : Form
    {
        public FrmIniciar()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmSplashView mv = new FrmSplashView();

            this.Hide();
            mv.ShowDialog();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            FrmSplashView mv = new FrmSplashView();

            this.Hide();
            mv.ShowDialog();
            this.Close();
        }
    }
}
