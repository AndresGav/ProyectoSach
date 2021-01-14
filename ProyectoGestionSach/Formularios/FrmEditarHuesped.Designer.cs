
namespace ProyectoGestionSach
{
    partial class FrmEditarHuesped
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarHuesped));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_DireccionCl = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_TlfnCl = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_ApellidoCl = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_NombreCl = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_CedulaCl = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Guardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 93;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(754, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 89;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 50);
            this.label1.TabIndex = 94;
            this.label1.Text = "Editar Huesped";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tb_DireccionCl
            // 
            this.tb_DireccionCl.AutoRoundedCorners = true;
            this.tb_DireccionCl.BorderRadius = 21;
            this.tb_DireccionCl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_DireccionCl.DefaultText = "";
            this.tb_DireccionCl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_DireccionCl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_DireccionCl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_DireccionCl.DisabledState.Parent = this.tb_DireccionCl;
            this.tb_DireccionCl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_DireccionCl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_DireccionCl.FocusedState.Parent = this.tb_DireccionCl;
            this.tb_DireccionCl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_DireccionCl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_DireccionCl.HoverState.Parent = this.tb_DireccionCl;
            this.tb_DireccionCl.Location = new System.Drawing.Point(413, 236);
            this.tb_DireccionCl.Margin = new System.Windows.Forms.Padding(4);
            this.tb_DireccionCl.Name = "tb_DireccionCl";
            this.tb_DireccionCl.PasswordChar = '\0';
            this.tb_DireccionCl.PlaceholderText = "";
            this.tb_DireccionCl.SelectedText = "";
            this.tb_DireccionCl.ShadowDecoration.Parent = this.tb_DireccionCl;
            this.tb_DireccionCl.Size = new System.Drawing.Size(311, 44);
            this.tb_DireccionCl.TabIndex = 124;
            // 
            // tb_TlfnCl
            // 
            this.tb_TlfnCl.AutoRoundedCorners = true;
            this.tb_TlfnCl.BorderRadius = 21;
            this.tb_TlfnCl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_TlfnCl.DefaultText = "";
            this.tb_TlfnCl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_TlfnCl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_TlfnCl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_TlfnCl.DisabledState.Parent = this.tb_TlfnCl;
            this.tb_TlfnCl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_TlfnCl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_TlfnCl.FocusedState.Parent = this.tb_TlfnCl;
            this.tb_TlfnCl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_TlfnCl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_TlfnCl.HoverState.Parent = this.tb_TlfnCl;
            this.tb_TlfnCl.Location = new System.Drawing.Point(413, 163);
            this.tb_TlfnCl.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TlfnCl.Name = "tb_TlfnCl";
            this.tb_TlfnCl.PasswordChar = '\0';
            this.tb_TlfnCl.PlaceholderText = "";
            this.tb_TlfnCl.SelectedText = "";
            this.tb_TlfnCl.ShadowDecoration.Parent = this.tb_TlfnCl;
            this.tb_TlfnCl.Size = new System.Drawing.Size(311, 44);
            this.tb_TlfnCl.TabIndex = 123;
            // 
            // tb_ApellidoCl
            // 
            this.tb_ApellidoCl.AutoRoundedCorners = true;
            this.tb_ApellidoCl.BorderRadius = 21;
            this.tb_ApellidoCl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ApellidoCl.DefaultText = "";
            this.tb_ApellidoCl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_ApellidoCl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_ApellidoCl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ApellidoCl.DisabledState.Parent = this.tb_ApellidoCl;
            this.tb_ApellidoCl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ApellidoCl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_ApellidoCl.FocusedState.Parent = this.tb_ApellidoCl;
            this.tb_ApellidoCl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_ApellidoCl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_ApellidoCl.HoverState.Parent = this.tb_ApellidoCl;
            this.tb_ApellidoCl.Location = new System.Drawing.Point(64, 308);
            this.tb_ApellidoCl.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ApellidoCl.Name = "tb_ApellidoCl";
            this.tb_ApellidoCl.PasswordChar = '\0';
            this.tb_ApellidoCl.PlaceholderText = "";
            this.tb_ApellidoCl.SelectedText = "";
            this.tb_ApellidoCl.ShadowDecoration.Parent = this.tb_ApellidoCl;
            this.tb_ApellidoCl.Size = new System.Drawing.Size(311, 44);
            this.tb_ApellidoCl.TabIndex = 122;
            // 
            // tb_NombreCl
            // 
            this.tb_NombreCl.AutoRoundedCorners = true;
            this.tb_NombreCl.BorderRadius = 21;
            this.tb_NombreCl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_NombreCl.DefaultText = "";
            this.tb_NombreCl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_NombreCl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_NombreCl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_NombreCl.DisabledState.Parent = this.tb_NombreCl;
            this.tb_NombreCl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_NombreCl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_NombreCl.FocusedState.Parent = this.tb_NombreCl;
            this.tb_NombreCl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_NombreCl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_NombreCl.HoverState.Parent = this.tb_NombreCl;
            this.tb_NombreCl.Location = new System.Drawing.Point(64, 236);
            this.tb_NombreCl.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NombreCl.Name = "tb_NombreCl";
            this.tb_NombreCl.PasswordChar = '\0';
            this.tb_NombreCl.PlaceholderText = "";
            this.tb_NombreCl.SelectedText = "";
            this.tb_NombreCl.ShadowDecoration.Parent = this.tb_NombreCl;
            this.tb_NombreCl.Size = new System.Drawing.Size(311, 44);
            this.tb_NombreCl.TabIndex = 121;
            // 
            // tb_CedulaCl
            // 
            this.tb_CedulaCl.AutoRoundedCorners = true;
            this.tb_CedulaCl.BorderRadius = 21;
            this.tb_CedulaCl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CedulaCl.DefaultText = "";
            this.tb_CedulaCl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_CedulaCl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_CedulaCl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CedulaCl.DisabledState.Parent = this.tb_CedulaCl;
            this.tb_CedulaCl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CedulaCl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CedulaCl.FocusedState.Parent = this.tb_CedulaCl;
            this.tb_CedulaCl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_CedulaCl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CedulaCl.HoverState.Parent = this.tb_CedulaCl;
            this.tb_CedulaCl.Location = new System.Drawing.Point(64, 163);
            this.tb_CedulaCl.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CedulaCl.Name = "tb_CedulaCl";
            this.tb_CedulaCl.PasswordChar = '\0';
            this.tb_CedulaCl.PlaceholderText = "";
            this.tb_CedulaCl.SelectedText = "";
            this.tb_CedulaCl.ShadowDecoration.Parent = this.tb_CedulaCl;
            this.tb_CedulaCl.Size = new System.Drawing.Size(311, 44);
            this.tb_CedulaCl.TabIndex = 120;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ActiveBorderThickness = 1;
            this.btn_Cancelar.ActiveCornerRadius = 20;
            this.btn_Cancelar.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btn_Cancelar.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.ButtonText = "Cancelar";
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.IdleBorderThickness = 1;
            this.btn_Cancelar.IdleCornerRadius = 20;
            this.btn_Cancelar.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btn_Cancelar.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Cancelar.IdleLineColor = System.Drawing.Color.DarkGray;
            this.btn_Cancelar.Location = new System.Drawing.Point(408, 397);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(180, 62);
            this.btn_Cancelar.TabIndex = 119;
            this.btn_Cancelar.TabStop = false;
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.ActiveBorderThickness = 1;
            this.btn_Guardar.ActiveCornerRadius = 20;
            this.btn_Guardar.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_Guardar.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btn_Guardar.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.ButtonText = "Guardar";
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_Guardar.IdleBorderThickness = 1;
            this.btn_Guardar.IdleCornerRadius = 20;
            this.btn_Guardar.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btn_Guardar.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Guardar.IdleLineColor = System.Drawing.Color.DarkGray;
            this.btn_Guardar.Location = new System.Drawing.Point(194, 397);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(180, 62);
            this.btn_Guardar.TabIndex = 118;
            this.btn_Guardar.TabStop = false;
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 115;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 114;
            this.label2.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 117;
            this.label6.Text = "Cédula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 113;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 116;
            this.label4.Text = "Nombre";
            // 
            // FrmEditarHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.tb_DireccionCl);
            this.Controls.Add(this.tb_TlfnCl);
            this.Controls.Add(this.tb_ApellidoCl);
            this.Controls.Add(this.tb_NombreCl);
            this.Controls.Add(this.tb_CedulaCl);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarHuesped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarHuesped";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tb_DireccionCl;
        private Guna.UI2.WinForms.Guna2TextBox tb_TlfnCl;
        private Guna.UI2.WinForms.Guna2TextBox tb_ApellidoCl;
        private Guna.UI2.WinForms.Guna2TextBox tb_NombreCl;
        private Guna.UI2.WinForms.Guna2TextBox tb_CedulaCl;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Cancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}