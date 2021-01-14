
namespace ProyectoGestionSach
{
    partial class FrmSplashView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplashView));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.loading_timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_Archivos = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(135, 553);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cargando Sistema...";
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.AutoRoundedCorners = true;
            this.guna2ProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ProgressBar1.BorderRadius = 6;
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(135, 581);
            this.guna2ProgressBar1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.White;
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.White;
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(721, 15);
            this.guna2ProgressBar1.TabIndex = 3;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.lbl_Archivos);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ProgressBar1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1009, 682);
            this.guna2CustomGradientPanel1.TabIndex = 5;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::ProyectoGestionSach.Properties.Resources.GestionSachLogo;
            this.guna2PictureBox1.Location = new System.Drawing.Point(313, 180);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(400, 246);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // loading_timer
            // 
            this.loading_timer.Tick += new System.EventHandler(this.loading_timer_Tick_1);
            // 
            // lbl_Archivos
            // 
            this.lbl_Archivos.AutoSize = true;
            this.lbl_Archivos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Archivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Archivos.ForeColor = System.Drawing.Color.Black;
            this.lbl_Archivos.Location = new System.Drawing.Point(135, 601);
            this.lbl_Archivos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Archivos.Name = "lbl_Archivos";
            this.lbl_Archivos.Size = new System.Drawing.Size(79, 20);
            this.lbl_Archivos.TabIndex = 6;
            this.lbl_Archivos.Text = "Archivos:";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 35;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // FrmSplashView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 682);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSplashView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplashView";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Timer loading_timer;
        private System.Windows.Forms.Label lbl_Archivos;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}