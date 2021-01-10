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
    public partial class FrmSplashView : Form
    {
        public FrmSplashView()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            loading_timer.Interval = 100;
            loading_timer.Start();
            guna2ProgressBar1.Maximum = 24;
        }

        private void loading_timer_Tick_1(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value != 24)
            {
                guna2ProgressBar1.Value++;
            }
            else
            {
                loading_timer.Stop();

                FrmPrincipal mv = new FrmPrincipal();
                
                this.Hide();
                mv.ShowDialog();
                this.Close();
            }
        }
    }
}
