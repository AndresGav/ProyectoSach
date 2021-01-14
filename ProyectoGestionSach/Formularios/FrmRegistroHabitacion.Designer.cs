
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroHabitacion));
            this.Label2 = new System.Windows.Forms.Label();
            this.dgv_Habitaciones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Agregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_CedCli = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlCargando = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Habitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).BeginInit();
            this.pnlCargando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(58, 122);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 37);
            this.Label2.TabIndex = 59;
            this.Label2.Text = "Buscar:";
            // 
            // dgv_Habitaciones
            // 
            this.dgv_Habitaciones.AllowUserToAddRows = false;
            this.dgv_Habitaciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Habitaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Habitaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Habitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Habitaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Habitaciones.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Habitaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Habitaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Habitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Habitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Habitaciones.DataMember = "Habitaciones";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Habitaciones.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Habitaciones.DoubleBuffered = true;
            this.dgv_Habitaciones.EnableHeadersVisualStyles = false;
            this.dgv_Habitaciones.GridColor = System.Drawing.Color.Black;
            this.dgv_Habitaciones.HeaderBgColor = System.Drawing.Color.DarkGray;
            this.dgv_Habitaciones.HeaderForeColor = System.Drawing.Color.Black;
            this.dgv_Habitaciones.Location = new System.Drawing.Point(65, 220);
            this.dgv_Habitaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Habitaciones.Name = "dgv_Habitaciones";
            this.dgv_Habitaciones.ReadOnly = true;
            this.dgv_Habitaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Habitaciones.RowHeadersWidth = 51;
            this.dgv_Habitaciones.RowTemplate.Height = 24;
            this.dgv_Habitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Habitaciones.Size = new System.Drawing.Size(900, 350);
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
            this.btn_Eliminar.Location = new System.Drawing.Point(935, 120);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(40, 39);
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
            this.btn_Editar.Location = new System.Drawing.Point(875, 120);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(40, 39);
            this.btn_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Editar.TabIndex = 62;
            this.btn_Editar.TabStop = false;
            this.btn_Editar.Zoom = 10;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageActive = null;
            this.btn_Agregar.Location = new System.Drawing.Point(815, 120);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(40, 39);
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
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(1030, 90);
            this.bunifuCustomLabel1.TabIndex = 64;
            this.bunifuCustomLabel1.Text = " Listado de Habitaciones";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_CedCli
            // 
            this.tb_CedCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_CedCli.AutoRoundedCorners = true;
            this.tb_CedCli.BorderRadius = 21;
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
            this.tb_CedCli.Location = new System.Drawing.Point(200, 120);
            this.tb_CedCli.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CedCli.Name = "tb_CedCli";
            this.tb_CedCli.PasswordChar = '\0';
            this.tb_CedCli.PlaceholderText = "";
            this.tb_CedCli.SelectedText = "";
            this.tb_CedCli.ShadowDecoration.Parent = this.tb_CedCli;
            this.tb_CedCli.Size = new System.Drawing.Size(600, 45);
            this.tb_CedCli.TabIndex = 101;
            // 
            // pnlCargando
            // 
            this.pnlCargando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCargando.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlCargando.Controls.Add(this.label1);
            this.pnlCargando.Controls.Add(this.pictureBox1);
            this.pnlCargando.Location = new System.Drawing.Point(405, 210);
            this.pnlCargando.Name = "pnlCargando";
            this.pnlCargando.Size = new System.Drawing.Size(220, 176);
            this.pnlCargando.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cargando...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistroHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 600);
            this.Controls.Add(this.pnlCargando);
            this.Controls.Add(this.tb_CedCli);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dgv_Habitaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistroHabitacion";
            this.Text = "FrmRegistroHabitacion";
            this.Load += new System.EventHandler(this.FrmRegistroHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Habitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).EndInit();
            this.pnlCargando.ResumeLayout(false);
            this.pnlCargando.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        public System.Windows.Forms.Panel pnlCargando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}