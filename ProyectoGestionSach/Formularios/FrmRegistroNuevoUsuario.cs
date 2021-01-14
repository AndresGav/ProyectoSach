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
    public partial class FrmRegistroNuevoUsuario : Form
    {
        public FrmRegistroNuevoUsuario()
        {
            InitializeComponent();
        }

        private void FrmRegistroNuevoUsuario_Load(object sender, EventArgs e)
        {
            txtCargosEmp.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnClose_Click(object sender, EventArgs e)
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
