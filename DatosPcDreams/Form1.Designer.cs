namespace DatosPcDreams
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Red = new System.Windows.Forms.Button();
            this.btn_Datos = new System.Windows.Forms.Button();
            this.btn_Ping = new System.Windows.Forms.Button();
            this.txt_Ping = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_newWndsPrntScrn = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Red
            // 
            this.btn_Red.Location = new System.Drawing.Point(12, 12);
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(117, 63);
            this.btn_Red.TabIndex = 0;
            this.btn_Red.Text = "Datos de red";
            this.btn_Red.UseVisualStyleBackColor = true;
            this.btn_Red.Click += new System.EventHandler(this.btn_Red_Click_1);
            // 
            // btn_Datos
            // 
            this.btn_Datos.Location = new System.Drawing.Point(152, 12);
            this.btn_Datos.Name = "btn_Datos";
            this.btn_Datos.Size = new System.Drawing.Size(117, 63);
            this.btn_Datos.TabIndex = 1;
            this.btn_Datos.Text = "Datos del equipo";
            this.btn_Datos.UseVisualStyleBackColor = true;
            this.btn_Datos.Click += new System.EventHandler(this.btn_Datos_Click);
            // 
            // btn_Ping
            // 
            this.btn_Ping.Location = new System.Drawing.Point(7, 57);
            this.btn_Ping.Name = "btn_Ping";
            this.btn_Ping.Size = new System.Drawing.Size(104, 56);
            this.btn_Ping.TabIndex = 2;
            this.btn_Ping.Text = "Ping";
            this.btn_Ping.UseVisualStyleBackColor = true;
            this.btn_Ping.Click += new System.EventHandler(this.btn_Ping_Click);
            // 
            // txt_Ping
            // 
            this.txt_Ping.Location = new System.Drawing.Point(6, 31);
            this.txt_Ping.Name = "txt_Ping";
            this.txt_Ping.Size = new System.Drawing.Size(104, 20);
            this.txt_Ping.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btn_Ping);
            this.groupBox1.Controls.Add(this.txt_Ping);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pruebas de conectividad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DatosPcDreams.Properties.Resources.LogoDreams;
            this.pictureBox1.Location = new System.Drawing.Point(346, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.btn_newWndsPrntScrn);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(152, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 129);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear una imagen de la pantalla";
            // 
            // btn_newWndsPrntScrn
            // 
            this.btn_newWndsPrntScrn.Location = new System.Drawing.Point(8, 57);
            this.btn_newWndsPrntScrn.Name = "btn_newWndsPrntScrn";
            this.btn_newWndsPrntScrn.Size = new System.Drawing.Size(103, 56);
            this.btn_newWndsPrntScrn.TabIndex = 7;
            this.btn_newWndsPrntScrn.Text = "Capturar pantalla";
            this.btn_newWndsPrntScrn.UseVisualStyleBackColor = true;
            this.btn_newWndsPrntScrn.Click += new System.EventHandler(this.btn_newWndsPrntScrn_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(83, 216);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(117, 63);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DatosPcDreams.Properties.Resources.FondoDreams;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Datos);
            this.Controls.Add(this.btn_Red);
            this.Name = "Form1";
            this.Text = "Datos del Equipo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Red;
        private System.Windows.Forms.Button btn_Datos;
        private System.Windows.Forms.Button btn_Ping;
        private System.Windows.Forms.TextBox txt_Ping;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_newWndsPrntScrn;
        private System.Windows.Forms.Button btn_Exit;
    }
}

