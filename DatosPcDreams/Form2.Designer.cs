namespace DatosPcDreams
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_PrintScreen = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bnt_SendPrintScreen = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_PrintScreen
            // 
            this.btn_PrintScreen.Location = new System.Drawing.Point(12, 12);
            this.btn_PrintScreen.Name = "btn_PrintScreen";
            this.btn_PrintScreen.Size = new System.Drawing.Size(104, 56);
            this.btn_PrintScreen.TabIndex = 8;
            this.btn_PrintScreen.Text = "Captura de pantalla";
            this.btn_PrintScreen.UseVisualStyleBackColor = true;
            this.btn_PrintScreen.Click += new System.EventHandler(this.btn_PrintScreen_Click);
            // 
            // bnt_SendPrintScreen
            // 
            this.bnt_SendPrintScreen.Location = new System.Drawing.Point(12, 74);
            this.bnt_SendPrintScreen.Name = "bnt_SendPrintScreen";
            this.bnt_SendPrintScreen.Size = new System.Drawing.Size(104, 56);
            this.bnt_SendPrintScreen.TabIndex = 9;
            this.bnt_SendPrintScreen.Text = "Enviar pantallazo por mail";
            this.bnt_SendPrintScreen.UseVisualStyleBackColor = true;
            this.bnt_SendPrintScreen.Click += new System.EventHandler(this.bnt_SendPrintScreen_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(29, 136);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(73, 27);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(127, 175);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.bnt_SendPrintScreen);
            this.Controls.Add(this.btn_PrintScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PrintScreen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bnt_SendPrintScreen;
        private System.Windows.Forms.Button btn_Exit;
    }
}