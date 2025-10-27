namespace ClinicaMedicare
{
    partial class InicioForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNLOGINMEDICO = new System.Windows.Forms.PictureBox();
            this.BTNLOGINADMIN = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNLOGINMEDICO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNLOGINADMIN)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.BarraTitulo.Controls.Add(this.pictureBox3);
            this.BarraTitulo.Controls.Add(this.pictureBox2);
            this.BarraTitulo.Controls.Add(this.pictureBox1);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 35);
            this.BarraTitulo.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ClinicaMedicare.Properties.Resources.minimizar_ventana;
            this.pictureBox3.InitialImage = global::ClinicaMedicare.Properties.Resources.cruz;
            this.pictureBox3.Location = new System.Drawing.Point(1210, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClinicaMedicare.Properties.Resources.restaurar_ventana;
            this.pictureBox2.InitialImage = global::ClinicaMedicare.Properties.Resources.cruz;
            this.pictureBox2.Location = new System.Drawing.Point(1241, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicaMedicare.Properties.Resources.cruz;
            this.pictureBox1.InitialImage = global::ClinicaMedicare.Properties.Resources.cruz;
            this.pictureBox1.Location = new System.Drawing.Point(1272, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEDICARE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 22.2F);
            this.label2.Location = new System.Drawing.Point(416, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar como";
            // 
            // BTNLOGINMEDICO
            // 
            this.BTNLOGINMEDICO.Image = global::ClinicaMedicare.Properties.Resources.md_del_usuario;
            this.BTNLOGINMEDICO.Location = new System.Drawing.Point(294, 271);
            this.BTNLOGINMEDICO.Name = "BTNLOGINMEDICO";
            this.BTNLOGINMEDICO.Size = new System.Drawing.Size(183, 158);
            this.BTNLOGINMEDICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTNLOGINMEDICO.TabIndex = 3;
            this.BTNLOGINMEDICO.TabStop = false;
            // 
            // BTNLOGINADMIN
            // 
            this.BTNLOGINADMIN.Image = global::ClinicaMedicare.Properties.Resources.alt_administrador;
            this.BTNLOGINADMIN.Location = new System.Drawing.Point(790, 271);
            this.BTNLOGINADMIN.Name = "BTNLOGINADMIN";
            this.BTNLOGINADMIN.Size = new System.Drawing.Size(183, 158);
            this.BTNLOGINADMIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTNLOGINADMIN.TabIndex = 4;
            this.BTNLOGINADMIN.TabStop = false;
            this.BTNLOGINADMIN.Click += new System.EventHandler(this.BTNLOGINADMIN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 11F);
            this.label3.Location = new System.Drawing.Point(305, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "MEDICO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Wide Latin", 11F);
            this.label4.Location = new System.Drawing.Point(724, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "ADMINISTRADOR";
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNLOGINADMIN);
            this.Controls.Add(this.BTNLOGINMEDICO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioForm";
            this.Text = "InicioForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNLOGINMEDICO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNLOGINADMIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BTNLOGINMEDICO;
        private System.Windows.Forms.PictureBox BTNLOGINADMIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

