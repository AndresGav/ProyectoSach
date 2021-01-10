
namespace ProyectoGestionSach
{
    partial class FrmRegistroNuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroNuevoUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCargosEmp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Guardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tb_CedulaCl = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_NombreCl = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_ApellidoCl = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_TlfnCl = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_DireccionCl = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 36);
            this.panel1.TabIndex = 93;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(523, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
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
            this.label1.Location = new System.Drawing.Point(0, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 41);
            this.label1.TabIndex = 94;
            this.label1.Text = "Registro Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 111;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 109;
            this.label2.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 115;
            this.label6.Text = "Cédula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 107;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 113;
            this.label4.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(308, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 119;
            this.label7.Text = "Cargo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 21);
            this.label8.TabIndex = 121;
            this.label8.Text = "Contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(157, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 123;
            this.label9.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 21);
            this.label10.TabIndex = 125;
            this.label10.Text = "Usuario";
            // 
            // txtCargosEmp
            // 
            this.txtCargosEmp.BackColor = System.Drawing.Color.Transparent;
            this.txtCargosEmp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCargosEmp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCargosEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCargosEmp.FillColor = System.Drawing.SystemColors.Control;
            this.txtCargosEmp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCargosEmp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCargosEmp.FocusedState.Parent = this.txtCargosEmp;
            this.txtCargosEmp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCargosEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtCargosEmp.HoverState.Parent = this.txtCargosEmp;
            this.txtCargosEmp.ItemHeight = 30;
            this.txtCargosEmp.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.txtCargosEmp.ItemsAppearance.Parent = this.txtCargosEmp;
            this.txtCargosEmp.Location = new System.Drawing.Point(294, 238);
            this.txtCargosEmp.Name = "txtCargosEmp";
            this.txtCargosEmp.ShadowDecoration.Parent = this.txtCargosEmp;
            this.txtCargosEmp.Size = new System.Drawing.Size(231, 36);
            this.txtCargosEmp.TabIndex = 126;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.Transparent;
            this.txtEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstado.FillColor = System.Drawing.SystemColors.Control;
            this.txtEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstado.FocusedState.Parent = this.txtEstado;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtEstado.HoverState.Parent = this.txtEstado;
            this.txtEstado.ItemHeight = 30;
            this.txtEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.txtEstado.ItemsAppearance.Parent = this.txtEstado;
            this.txtEstado.Location = new System.Drawing.Point(161, 112);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ShadowDecoration.Parent = this.txtEstado;
            this.txtEstado.Size = new System.Drawing.Size(233, 36);
            this.txtEstado.TabIndex = 127;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 154);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Sistema";
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
            this.btn_Cancelar.Location = new System.Drawing.Point(269, 453);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(138, 37);
            this.btn_Cancelar.TabIndex = 130;
            this.btn_Cancelar.TabStop = false;
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Guardar.Location = new System.Drawing.Point(109, 453);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(138, 37);
            this.btn_Guardar.TabIndex = 129;
            this.btn_Guardar.TabStop = false;
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_CedulaCl
            // 
            this.tb_CedulaCl.AutoRoundedCorners = true;
            this.tb_CedulaCl.BorderRadius = 17;
            this.tb_CedulaCl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CedulaCl.DefaultText = "";
            this.tb_CedulaCl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_CedulaCl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_CedulaCl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CedulaCl.DisabledState.Parent = this.tb_CedulaCl;
            this.tb_CedulaCl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CedulaCl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CedulaCl.FocusedState.Parent = this.tb_CedulaCl;
            this.tb_CedulaCl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_CedulaCl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CedulaCl.HoverState.Parent = this.tb_CedulaCl;
            this.tb_CedulaCl.Location = new System.Drawing.Point(30, 128);
            this.tb_CedulaCl.Name = "tb_CedulaCl";
            this.tb_CedulaCl.PasswordChar = '\0';
            this.tb_CedulaCl.PlaceholderText = "";
            this.tb_CedulaCl.SelectedText = "";
            this.tb_CedulaCl.ShadowDecoration.Parent = this.tb_CedulaCl;
            this.tb_CedulaCl.Size = new System.Drawing.Size(233, 36);
            this.tb_CedulaCl.TabIndex = 131;
            // 
            // tb_NombreCl
            // 
            this.tb_NombreCl.AutoRoundedCorners = true;
            this.tb_NombreCl.BorderRadius = 17;
            this.tb_NombreCl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_NombreCl.DefaultText = "";
            this.tb_NombreCl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_NombreCl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_NombreCl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_NombreCl.DisabledState.Parent = this.tb_NombreCl;
            this.tb_NombreCl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_NombreCl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_NombreCl.FocusedState.Parent = this.tb_NombreCl;
            this.tb_NombreCl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_NombreCl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_NombreCl.HoverState.Parent = this.tb_NombreCl;
            this.tb_NombreCl.Location = new System.Drawing.Point(32, 187);
            this.tb_NombreCl.Name = "tb_NombreCl";
            this.tb_NombreCl.PasswordChar = '\0';
            this.tb_NombreCl.PlaceholderText = "";
            this.tb_NombreCl.SelectedText = "";
            this.tb_NombreCl.ShadowDecoration.Parent = this.tb_NombreCl;
            this.tb_NombreCl.Size = new System.Drawing.Size(233, 36);
            this.tb_NombreCl.TabIndex = 132;
            // 
            // tb_ApellidoCl
            // 
            this.tb_ApellidoCl.AutoRoundedCorners = true;
            this.tb_ApellidoCl.BorderRadius = 17;
            this.tb_ApellidoCl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ApellidoCl.DefaultText = "";
            this.tb_ApellidoCl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_ApellidoCl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_ApellidoCl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ApellidoCl.DisabledState.Parent = this.tb_ApellidoCl;
            this.tb_ApellidoCl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ApellidoCl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_ApellidoCl.FocusedState.Parent = this.tb_ApellidoCl;
            this.tb_ApellidoCl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_ApellidoCl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_ApellidoCl.HoverState.Parent = this.tb_ApellidoCl;
            this.tb_ApellidoCl.Location = new System.Drawing.Point(32, 250);
            this.tb_ApellidoCl.Name = "tb_ApellidoCl";
            this.tb_ApellidoCl.PasswordChar = '\0';
            this.tb_ApellidoCl.PlaceholderText = "";
            this.tb_ApellidoCl.SelectedText = "";
            this.tb_ApellidoCl.ShadowDecoration.Parent = this.tb_ApellidoCl;
            this.tb_ApellidoCl.Size = new System.Drawing.Size(233, 36);
            this.tb_ApellidoCl.TabIndex = 133;
            // 
            // tb_TlfnCl
            // 
            this.tb_TlfnCl.AutoRoundedCorners = true;
            this.tb_TlfnCl.BorderRadius = 17;
            this.tb_TlfnCl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_TlfnCl.DefaultText = "";
            this.tb_TlfnCl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_TlfnCl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_TlfnCl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_TlfnCl.DisabledState.Parent = this.tb_TlfnCl;
            this.tb_TlfnCl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_TlfnCl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_TlfnCl.FocusedState.Parent = this.tb_TlfnCl;
            this.tb_TlfnCl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_TlfnCl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_TlfnCl.HoverState.Parent = this.tb_TlfnCl;
            this.tb_TlfnCl.Location = new System.Drawing.Point(294, 128);
            this.tb_TlfnCl.Name = "tb_TlfnCl";
            this.tb_TlfnCl.PasswordChar = '\0';
            this.tb_TlfnCl.PlaceholderText = "";
            this.tb_TlfnCl.SelectedText = "";
            this.tb_TlfnCl.ShadowDecoration.Parent = this.tb_TlfnCl;
            this.tb_TlfnCl.Size = new System.Drawing.Size(233, 36);
            this.tb_TlfnCl.TabIndex = 134;
            // 
            // tb_DireccionCl
            // 
            this.tb_DireccionCl.AutoRoundedCorners = true;
            this.tb_DireccionCl.BorderRadius = 17;
            this.tb_DireccionCl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_DireccionCl.DefaultText = "";
            this.tb_DireccionCl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_DireccionCl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_DireccionCl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_DireccionCl.DisabledState.Parent = this.tb_DireccionCl;
            this.tb_DireccionCl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_DireccionCl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_DireccionCl.FocusedState.Parent = this.tb_DireccionCl;
            this.tb_DireccionCl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_DireccionCl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_DireccionCl.HoverState.Parent = this.tb_DireccionCl;
            this.tb_DireccionCl.Location = new System.Drawing.Point(294, 187);
            this.tb_DireccionCl.Name = "tb_DireccionCl";
            this.tb_DireccionCl.PasswordChar = '\0';
            this.tb_DireccionCl.PlaceholderText = "";
            this.tb_DireccionCl.SelectedText = "";
            this.tb_DireccionCl.ShadowDecoration.Parent = this.tb_DireccionCl;
            this.tb_DireccionCl.Size = new System.Drawing.Size(233, 36);
            this.tb_DireccionCl.TabIndex = 136;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoRoundedCorners = true;
            this.txtPassword.BorderRadius = 17;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(279, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(233, 36);
            this.txtPassword.TabIndex = 135;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoRoundedCorners = true;
            this.txtUsuario.BorderRadius = 17;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.Parent = this.txtUsuario;
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.FocusedState.Parent = this.txtUsuario;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.HoverState.Parent = this.txtUsuario;
            this.txtUsuario.Location = new System.Drawing.Point(19, 48);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.ShadowDecoration.Parent = this.txtUsuario;
            this.txtUsuario.Size = new System.Drawing.Size(233, 36);
            this.txtUsuario.TabIndex = 136;
            // 
            // FrmRegistroNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 503);
            this.Controls.Add(this.tb_DireccionCl);
            this.Controls.Add(this.tb_TlfnCl);
            this.Controls.Add(this.tb_ApellidoCl);
            this.Controls.Add(this.tb_NombreCl);
            this.Controls.Add(this.tb_CedulaCl);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCargosEmp);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistroNuevoUsuario";
            this.Load += new System.EventHandler(this.FrmRegistroNuevoUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox txtCargosEmp;
        private Guna.UI2.WinForms.Guna2ComboBox txtEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Cancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Guardar;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox tb_CedulaCl;
        private Guna.UI2.WinForms.Guna2TextBox tb_NombreCl;
        private Guna.UI2.WinForms.Guna2TextBox tb_ApellidoCl;
        private Guna.UI2.WinForms.Guna2TextBox tb_TlfnCl;
        private Guna.UI2.WinForms.Guna2TextBox tb_DireccionCl;
    }
}