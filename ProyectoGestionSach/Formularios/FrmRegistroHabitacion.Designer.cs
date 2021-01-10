
namespace ProyectoGestionSach
{
    partial class FrmRegistroHabitacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroHabitacion));
            this.Label2 = new System.Windows.Forms.Label();
            this.dgv_Habitaciones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Agregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_CedCli = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Habitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(48, 105);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 30);
            this.Label2.TabIndex = 59;
            this.Label2.Text = "Buscar:";
            // 
            // dgv_Habitaciones
            // 
            this.dgv_Habitaciones.AllowUserToAddRows = false;
            this.dgv_Habitaciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Habitaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Habitaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Habitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Habitaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Habitaciones.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Habitaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Habitaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Habitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Habitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Habitaciones.DataMember = "Habitaciones";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Habitaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Habitaciones.DoubleBuffered = true;
            this.dgv_Habitaciones.EnableHeadersVisualStyles = false;
            this.dgv_Habitaciones.GridColor = System.Drawing.Color.Black;
            this.dgv_Habitaciones.HeaderBgColor = System.Drawing.Color.DarkGray;
            this.dgv_Habitaciones.HeaderForeColor = System.Drawing.Color.Black;
            this.dgv_Habitaciones.Location = new System.Drawing.Point(53, 179);
            this.dgv_Habitaciones.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Habitaciones.Name = "dgv_Habitaciones";
            this.dgv_Habitaciones.ReadOnly = true;
            this.dgv_Habitaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Habitaciones.RowHeadersWidth = 51;
            this.dgv_Habitaciones.RowTemplate.Height = 24;
            this.dgv_Habitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Habitaciones.Size = new System.Drawing.Size(675, 286);
            this.dgv_Habitaciones.TabIndex = 58;
            this.dgv_Habitaciones.TabStop = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageActive = null;
            this.btn_Eliminar.Location = new System.Drawing.Point(698, 106);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(30, 32);
            this.btn_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Eliminar.TabIndex = 63;
            this.btn_Eliminar.TabStop = false;
            this.btn_Eliminar.Zoom = 10;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Editar.Image")));
            this.btn_Editar.ImageActive = null;
            this.btn_Editar.Location = new System.Drawing.Point(656, 106);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(30, 32);
            this.btn_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Editar.TabIndex = 62;
            this.btn_Editar.TabStop = false;
            this.btn_Editar.Zoom = 10;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageActive = null;
            this.btn_Agregar.Location = new System.Drawing.Point(612, 106);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(30, 32);
            this.btn_Agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Agregar.TabIndex = 61;
            this.btn_Agregar.TabStop = false;
            this.btn_Agregar.Zoom = 10;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(772, 73);
            this.bunifuCustomLabel1.TabIndex = 64;
            this.bunifuCustomLabel1.Text = " Listado de Habitaciones";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_CedCli
            // 
            this.tb_CedCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_CedCli.AutoRoundedCorners = true;
            this.tb_CedCli.BorderRadius = 17;
            this.tb_CedCli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CedCli.DefaultText = "";
            this.tb_CedCli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_CedCli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_CedCli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CedCli.DisabledState.Parent = this.tb_CedCli;
            this.tb_CedCli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CedCli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CedCli.FocusedState.Parent = this.tb_CedCli;
            this.tb_CedCli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_CedCli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CedCli.HoverState.Parent = this.tb_CedCli;
            this.tb_CedCli.Location = new System.Drawing.Point(152, 106);
            this.tb_CedCli.Name = "tb_CedCli";
            this.tb_CedCli.PasswordChar = '\0';
            this.tb_CedCli.PlaceholderText = "";
            this.tb_CedCli.SelectedText = "";
            this.tb_CedCli.ShadowDecoration.Parent = this.tb_CedCli;
            this.tb_CedCli.Size = new System.Drawing.Size(455, 36);
            this.tb_CedCli.TabIndex = 101;
            // 
            // FrmRegistroHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 492);
            this.Controls.Add(this.tb_CedCli);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dgv_Habitaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroHabitacion";
            this.Text = "FrmRegistroHabitacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Habitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btn_Eliminar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Editar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Agregar;
        internal System.Windows.Forms.Label Label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Habitaciones;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tb_CedCli;
    }
}