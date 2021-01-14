
namespace ProyectoGestionSach
{
    partial class FrmListaHabReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaHabReservas));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgv_Habitaciones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_AceptarHab = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlCargando = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Habitaciones)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlCargando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 44);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(934, 90);
            this.bunifuCustomLabel1.TabIndex = 107;
            this.bunifuCustomLabel1.Text = " Listado de Habitaciones";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dgv_Habitaciones.Location = new System.Drawing.Point(47, 136);
            this.dgv_Habitaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Habitaciones.Name = "dgv_Habitaciones";
            this.dgv_Habitaciones.ReadOnly = true;
            this.dgv_Habitaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Habitaciones.RowHeadersWidth = 51;
            this.dgv_Habitaciones.RowTemplate.Height = 24;
            this.dgv_Habitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Habitaciones.Size = new System.Drawing.Size(832, 317);
            this.dgv_Habitaciones.TabIndex = 106;
            this.dgv_Habitaciones.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(934, 44);
            this.panel4.TabIndex = 105;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(886, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 89;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_AceptarHab
            // 
            this.btn_AceptarHab.ActiveBorderThickness = 1;
            this.btn_AceptarHab.ActiveCornerRadius = 20;
            this.btn_AceptarHab.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_AceptarHab.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btn_AceptarHab.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btn_AceptarHab.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AceptarHab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AceptarHab.BackgroundImage")));
            this.btn_AceptarHab.ButtonText = "Reservar";
            this.btn_AceptarHab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AceptarHab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AceptarHab.ForeColor = System.Drawing.Color.Black;
            this.btn_AceptarHab.IdleBorderThickness = 1;
            this.btn_AceptarHab.IdleCornerRadius = 20;
            this.btn_AceptarHab.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btn_AceptarHab.IdleForecolor = System.Drawing.Color.Black;
            this.btn_AceptarHab.IdleLineColor = System.Drawing.Color.DarkGray;
            this.btn_AceptarHab.Location = new System.Drawing.Point(699, 460);
            this.btn_AceptarHab.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AceptarHab.Name = "btn_AceptarHab";
            this.btn_AceptarHab.Size = new System.Drawing.Size(180, 60);
            this.btn_AceptarHab.TabIndex = 108;
            this.btn_AceptarHab.TabStop = false;
            this.btn_AceptarHab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AceptarHab.Click += new System.EventHandler(this.btn_AceptarHab_Click);
            // 
            // pnlCargando
            // 
            this.pnlCargando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCargando.BackColor = System.Drawing.Color.Transparent;
            this.pnlCargando.Controls.Add(this.label1);
            this.pnlCargando.Controls.Add(this.pictureBox1);
            this.pnlCargando.Location = new System.Drawing.Point(357, 188);
            this.pnlCargando.Name = "pnlCargando";
            this.pnlCargando.Size = new System.Drawing.Size(220, 177);
            this.pnlCargando.TabIndex = 109;
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
            // FrmListaHabReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 552);
            this.Controls.Add(this.pnlCargando);
            this.Controls.Add(this.btn_AceptarHab);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dgv_Habitaciones);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaHabReservas";
            this.Text = "FrmListaHabReservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Habitaciones)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlCargando.ResumeLayout(false);
            this.pnlCargando.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_AceptarHab;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel4;
        internal Bunifu.Framework.UI.BunifuImageButton btnClose;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Habitaciones;
        private System.Windows.Forms.Panel pnlCargando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}