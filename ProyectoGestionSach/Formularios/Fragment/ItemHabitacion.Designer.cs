
namespace ProyectoGestionSach
{
    partial class ItemHabitacion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Hab = new System.Windows.Forms.Button();
            this.lbl_TipoHab = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Hab);
            this.panel1.Controls.Add(this.lbl_TipoHab);
            this.panel1.Controls.Add(this.lbl_Estado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 180);
            this.panel1.TabIndex = 5;
            // 
            // btn_Hab
            // 
            this.btn_Hab.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Hab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Hab.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hab.Location = new System.Drawing.Point(0, 0);
            this.btn_Hab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Hab.Name = "btn_Hab";
            this.btn_Hab.Size = new System.Drawing.Size(238, 60);
            this.btn_Hab.TabIndex = 1;
            this.btn_Hab.Text = "habitacion";
            this.btn_Hab.UseVisualStyleBackColor = false;
            this.btn_Hab.Click += new System.EventHandler(this.btn_Hab_Click);
            // 
            // lbl_TipoHab
            // 
            this.lbl_TipoHab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoHab.Location = new System.Drawing.Point(-1, 82);
            this.lbl_TipoHab.Name = "lbl_TipoHab";
            this.lbl_TipoHab.Size = new System.Drawing.Size(240, 23);
            this.lbl_TipoHab.TabIndex = 3;
            this.lbl_TipoHab.Text = "Familiar";
            this.lbl_TipoHab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Estado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Location = new System.Drawing.Point(-1, 119);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(239, 21);
            this.lbl_Estado.TabIndex = 2;
            this.lbl_Estado.Text = "Disponible";
            this.lbl_Estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemHabitacion";
            this.Size = new System.Drawing.Size(240, 180);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Hab;
        private System.Windows.Forms.Label lbl_TipoHab;
        private System.Windows.Forms.Label lbl_Estado;
    }
}
