
namespace ProyectoGestionSach
{
    partial class FrmRegistroNuevaReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroNuevaReserva));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_CodHab = new System.Windows.Forms.Label();
            this.dt_FRegistro = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_FSalida = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cb_Temp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Dias = new System.Windows.Forms.Label();
            this.dt_FIngreso = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NombreClie = new System.Windows.Forms.Label();
            this.tb_CedCli = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.tb_Abono = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_NombreEmp = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_BuscarHab = new System.Windows.Forms.Button();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Alquilar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(945, 44);
            this.panel4.TabIndex = 94;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btn_BuscarHab);
            this.panel5.Controls.Add(this.tb_CodHab);
            this.panel5.Controls.Add(this.dt_FRegistro);
            this.panel5.Controls.Add(this.cb_Temp);
            this.panel5.Controls.Add(this.lbl_Dias);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.dt_FSalida);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.dt_FIngreso);
            this.panel5.Location = new System.Drawing.Point(61, 239);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(538, 334);
            this.panel5.TabIndex = 97;
            // 
            // tb_CodHab
            // 
            this.tb_CodHab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CodHab.Location = new System.Drawing.Point(298, 131);
            this.tb_CodHab.Name = "tb_CodHab";
            this.tb_CodHab.Size = new System.Drawing.Size(220, 36);
            this.tb_CodHab.TabIndex = 31;
            this.tb_CodHab.Text = "Cargando...";
            this.tb_CodHab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dt_FRegistro
            // 
            this.dt_FRegistro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dt_FRegistro.CheckedState.Parent = this.dt_FRegistro;
            this.dt_FRegistro.Enabled = false;
            this.dt_FRegistro.FillColor = System.Drawing.Color.White;
            this.dt_FRegistro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_FRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FRegistro.HoverState.Parent = this.dt_FRegistro;
            this.dt_FRegistro.Location = new System.Drawing.Point(13, 79);
            this.dt_FRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dt_FRegistro.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_FRegistro.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_FRegistro.Name = "dt_FRegistro";
            this.dt_FRegistro.ShadowDecoration.Parent = this.dt_FRegistro;
            this.dt_FRegistro.Size = new System.Drawing.Size(245, 34);
            this.dt_FRegistro.TabIndex = 30;
            this.dt_FRegistro.Value = new System.DateTime(2021, 1, 9, 14, 32, 16, 388);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Fecha Registro";
            // 
            // dt_FSalida
            // 
            this.dt_FSalida.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dt_FSalida.CheckedState.Parent = this.dt_FSalida;
            this.dt_FSalida.FillColor = System.Drawing.Color.White;
            this.dt_FSalida.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_FSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FSalida.HoverState.Parent = this.dt_FSalida;
            this.dt_FSalida.Location = new System.Drawing.Point(13, 233);
            this.dt_FSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dt_FSalida.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_FSalida.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_FSalida.Name = "dt_FSalida";
            this.dt_FSalida.ShadowDecoration.Parent = this.dt_FSalida;
            this.dt_FSalida.Size = new System.Drawing.Size(240, 34);
            this.dt_FSalida.TabIndex = 28;
            this.dt_FSalida.Value = new System.DateTime(2021, 1, 9, 14, 31, 36, 73);
            this.dt_FSalida.ValueChanged += new System.EventHandler(this.dt_FSalida_ValueChanged);
            // 
            // cb_Temp
            // 
            this.cb_Temp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Temp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Temp.FormattingEnabled = true;
            this.cb_Temp.Items.AddRange(new object[] {
            "Baja",
            "Alta"});
            this.cb_Temp.Location = new System.Drawing.Point(298, 187);
            this.cb_Temp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Temp.Name = "cb_Temp";
            this.cb_Temp.Size = new System.Drawing.Size(221, 31);
            this.cb_Temp.TabIndex = 26;
            this.cb_Temp.SelectionChangeCommitted += new System.EventHandler(this.cb_Temp_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha Salida";
            // 
            // lbl_Dias
            // 
            this.lbl_Dias.AutoSize = true;
            this.lbl_Dias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Dias.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dias.Location = new System.Drawing.Point(344, 238);
            this.lbl_Dias.Name = "lbl_Dias";
            this.lbl_Dias.Size = new System.Drawing.Size(129, 32);
            this.lbl_Dias.TabIndex = 1;
            this.lbl_Dias.Text = "Num Días";
            this.lbl_Dias.TextChanged += new System.EventHandler(this.lbl_Dias_TextChanged);
            // 
            // dt_FIngreso
            // 
            this.dt_FIngreso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dt_FIngreso.CheckedState.Parent = this.dt_FIngreso;
            this.dt_FIngreso.FillColor = System.Drawing.Color.White;
            this.dt_FIngreso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_FIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FIngreso.HoverState.Parent = this.dt_FIngreso;
            this.dt_FIngreso.Location = new System.Drawing.Point(13, 156);
            this.dt_FIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.dt_FIngreso.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_FIngreso.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_FIngreso.Name = "dt_FIngreso";
            this.dt_FIngreso.ShadowDecoration.Parent = this.dt_FIngreso;
            this.dt_FIngreso.Size = new System.Drawing.Size(245, 34);
            this.dt_FIngreso.TabIndex = 27;
            this.dt_FIngreso.Value = new System.DateTime(2021, 1, 9, 14, 32, 16, 388);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Habitación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha Ingreso";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(536, 36);
            this.panel6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Datos Habitación";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_NombreClie);
            this.panel1.Controls.Add(this.tb_CedCli);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(61, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 120);
            this.panel1.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cédula";
            // 
            // tb_NombreClie
            // 
            this.tb_NombreClie.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NombreClie.Location = new System.Drawing.Point(328, 69);
            this.tb_NombreClie.Name = "tb_NombreClie";
            this.tb_NombreClie.Size = new System.Drawing.Size(457, 44);
            this.tb_NombreClie.TabIndex = 104;
            this.tb_NombreClie.Text = "Esperando...";
            // 
            // tb_CedCli
            // 
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
            this.tb_CedCli.Location = new System.Drawing.Point(8, 69);
            this.tb_CedCli.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CedCli.Name = "tb_CedCli";
            this.tb_CedCli.PasswordChar = '\0';
            this.tb_CedCli.PlaceholderText = "";
            this.tb_CedCli.SelectedText = "";
            this.tb_CedCli.ShadowDecoration.Parent = this.tb_CedCli;
            this.tb_CedCli.Size = new System.Drawing.Size(292, 44);
            this.tb_CedCli.TabIndex = 100;
            this.tb_CedCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CedCli_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 36);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datos Cliente";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(945, 40);
            this.label1.TabIndex = 95;
            this.label1.Text = "Reservar Habitación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lbl_Total);
            this.panel7.Controls.Add(this.tb_Abono);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Location = new System.Drawing.Point(614, 239);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(281, 292);
            this.panel7.TabIndex = 102;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(0, 87);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(281, 36);
            this.lbl_Total.TabIndex = 31;
            this.lbl_Total.Text = "Cargando...";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Abono
            // 
            this.tb_Abono.AutoRoundedCorners = true;
            this.tb_Abono.BorderRadius = 21;
            this.tb_Abono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Abono.DefaultText = "";
            this.tb_Abono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Abono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Abono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Abono.DisabledState.Parent = this.tb_Abono;
            this.tb_Abono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Abono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Abono.FocusedState.Parent = this.tb_Abono;
            this.tb_Abono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Abono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Abono.HoverState.Parent = this.tb_Abono;
            this.tb_Abono.Location = new System.Drawing.Point(30, 174);
            this.tb_Abono.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Abono.Name = "tb_Abono";
            this.tb_Abono.PasswordChar = '\0';
            this.tb_Abono.PlaceholderText = "";
            this.tb_Abono.SelectedText = "";
            this.tb_Abono.ShadowDecoration.Parent = this.tb_Abono;
            this.tb_Abono.Size = new System.Drawing.Size(221, 44);
            this.tb_Abono.TabIndex = 105;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(281, 23);
            this.label12.TabIndex = 104;
            this.label12.Text = "Abono";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 23);
            this.label10.TabIndex = 102;
            this.label10.Text = "Total a pagar";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.Add(this.lbl_Saldo);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 254);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(279, 36);
            this.panel8.TabIndex = 26;
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.AutoSize = true;
            this.lbl_Saldo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saldo.Location = new System.Drawing.Point(3, 4);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(79, 30);
            this.lbl_Saldo.TabIndex = 1;
            this.lbl_Saldo.Text = "Saldo";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Controls.Add(this.label16);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(279, 36);
            this.panel9.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(231, 30);
            this.label16.TabIndex = 0;
            this.label16.Text = "Datos Facturación";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lb_NombreEmp);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Location = new System.Drawing.Point(62, 586);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 110);
            this.panel3.TabIndex = 104;
            // 
            // lb_NombreEmp
            // 
            this.lb_NombreEmp.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NombreEmp.Location = new System.Drawing.Point(3, 49);
            this.lb_NombreEmp.Name = "lb_NombreEmp";
            this.lb_NombreEmp.Size = new System.Drawing.Size(534, 44);
            this.lb_NombreEmp.TabIndex = 103;
            this.lb_NombreEmp.Text = "Cargando...";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightGray;
            this.panel10.Controls.Add(this.label8);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(536, 36);
            this.panel10.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(200, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Datos Empleados";
            // 
            // btn_BuscarHab
            // 
            this.btn_BuscarHab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarHab.Location = new System.Drawing.Point(34, 284);
            this.btn_BuscarHab.Name = "btn_BuscarHab";
            this.btn_BuscarHab.Size = new System.Drawing.Size(188, 34);
            this.btn_BuscarHab.TabIndex = 32;
            this.btn_BuscarHab.Text = "Buscar";
            this.btn_BuscarHab.UseVisualStyleBackColor = true;
            this.btn_BuscarHab.Click += new System.EventHandler(this.btn_BuscarHab_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Entregar";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkGray;
            this.bunifuThinButton22.Location = new System.Drawing.Point(667, 674);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(180, 60);
            this.bunifuThinButton22.TabIndex = 103;
            this.bunifuThinButton22.TabStop = false;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Visible = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Cancelar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkGray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(667, 604);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(180, 60);
            this.bunifuThinButton21.TabIndex = 103;
            this.bunifuThinButton21.TabStop = false;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Alquilar
            // 
            this.btn_Alquilar.ActiveBorderThickness = 1;
            this.btn_Alquilar.ActiveCornerRadius = 20;
            this.btn_Alquilar.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_Alquilar.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btn_Alquilar.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btn_Alquilar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Alquilar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Alquilar.BackgroundImage")));
            this.btn_Alquilar.ButtonText = "Reservar";
            this.btn_Alquilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Alquilar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alquilar.ForeColor = System.Drawing.Color.Black;
            this.btn_Alquilar.IdleBorderThickness = 1;
            this.btn_Alquilar.IdleCornerRadius = 20;
            this.btn_Alquilar.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btn_Alquilar.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Alquilar.IdleLineColor = System.Drawing.Color.DarkGray;
            this.btn_Alquilar.Location = new System.Drawing.Point(667, 540);
            this.btn_Alquilar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Alquilar.Name = "btn_Alquilar";
            this.btn_Alquilar.Size = new System.Drawing.Size(180, 60);
            this.btn_Alquilar.TabIndex = 98;
            this.btn_Alquilar.TabStop = false;
            this.btn_Alquilar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Alquilar.Click += new System.EventHandler(this.btn_Alquilar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(897, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 89;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmRegistroNuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 840);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btn_Alquilar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistroNuevaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistroReserva";
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        internal Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Alquilar;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_FRegistro;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_FSalida;
        private System.Windows.Forms.ComboBox cb_Temp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Dias;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_FIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox tb_CedCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2TextBox tb_Abono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label tb_NombreClie;
        public System.Windows.Forms.Label tb_CodHab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_NombreEmp;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl_Total;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Button btn_BuscarHab;
    }
}