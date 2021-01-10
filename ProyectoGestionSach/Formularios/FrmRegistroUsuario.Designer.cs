
namespace ProyectoGestionSach
{
    partial class FrmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroUsuario));
            this.dgv_Huespedes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Label2 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Agregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_CedCli = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Huespedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Huespedes
            // 
            this.dgv_Huespedes.AllowUserToAddRows = false;
            this.dgv_Huespedes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Huespedes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Huespedes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Huespedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Huespedes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Huespedes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Huespedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Huespedes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Huespedes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Huespedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Huespedes.DataMember = "Cliente";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Huespedes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Huespedes.DoubleBuffered = true;
            this.dgv_Huespedes.EnableHeadersVisualStyles = false;
            this.dgv_Huespedes.GridColor = System.Drawing.Color.Black;
            this.dgv_Huespedes.HeaderBgColor = System.Drawing.Color.DarkGray;
            this.dgv_Huespedes.HeaderForeColor = System.Drawing.Color.Black;
            this.dgv_Huespedes.Location = new System.Drawing.Point(68, 163);
            this.dgv_Huespedes.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Huespedes.Name = "dgv_Huespedes";
            this.dgv_Huespedes.ReadOnly = true;
            this.dgv_Huespedes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Huespedes.RowHeadersWidth = 51;
            this.dgv_Huespedes.RowTemplate.Height = 24;
            this.dgv_Huespedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Huespedes.Size = new System.Drawing.Size(647, 324);
            this.dgv_Huespedes.TabIndex = 76;
            this.dgv_Huespedes.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(63, 90);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 30);
            this.Label2.TabIndex = 71;
            this.Label2.Text = "Buscar:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageActive = null;
            this.btn_Eliminar.Location = new System.Drawing.Point(699, 90);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(30, 32);
            this.btn_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Eliminar.TabIndex = 75;
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
            this.btn_Editar.Location = new System.Drawing.Point(657, 90);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(30, 32);
            this.btn_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Editar.TabIndex = 74;
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
            this.btn_Agregar.Location = new System.Drawing.Point(613, 90);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(30, 32);
            this.btn_Agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Agregar.TabIndex = 73;
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
            this.bunifuCustomLabel1.TabIndex = 77;
            this.bunifuCustomLabel1.Text = " Listado de Empleados";
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
            this.tb_CedCli.Location = new System.Drawing.Point(186, 90);
            this.tb_CedCli.Name = "tb_CedCli";
            this.tb_CedCli.PasswordChar = '\0';
            this.tb_CedCli.PlaceholderText = "";
            this.tb_CedCli.SelectedText = "";
            this.tb_CedCli.ShadowDecoration.Parent = this.tb_CedCli;
            this.tb_CedCli.Size = new System.Drawing.Size(389, 36);
            this.tb_CedCli.TabIndex = 102;
            // 
            // FrmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 492);
            this.Controls.Add(this.tb_CedCli);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dgv_Huespedes);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroUsuario";
            this.Text = "FrmRegistroUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Huespedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Huespedes;
        private Bunifu.Framework.UI.BunifuImageButton btn_Eliminar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Editar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Agregar;
        internal System.Windows.Forms.Label Label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tb_CedCli;
    }
}