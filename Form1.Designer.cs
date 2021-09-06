
namespace Servidor
{
    partial class Form_Servidor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IP_label = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.Puerto_label = new System.Windows.Forms.Label();
            this.Btn_Encender = new System.Windows.Forms.Button();
            this.txt_Mensaje = new System.Windows.Forms.TextBox();
            this.Btn_Apagar = new System.Windows.Forms.Button();
            this.LED_Estado_1 = new System.Windows.Forms.Label();
            this.LED_ON = new System.Windows.Forms.Label();
            this.LED_OFF = new System.Windows.Forms.Label();
            this.LED_Estado_2 = new System.Windows.Forms.Label();
            this.LED2_OFF = new System.Windows.Forms.Label();
            this.LED2_ON = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IP_label
            // 
            this.IP_label.AutoSize = true;
            this.IP_label.Location = new System.Drawing.Point(45, 13);
            this.IP_label.Name = "IP_label";
            this.IP_label.Size = new System.Drawing.Size(37, 28);
            this.IP_label.TabIndex = 0;
            this.IP_label.Text = "IP :";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(88, 7);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(245, 34);
            this.txtIP.TabIndex = 1;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(88, 47);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(125, 34);
            this.txtPuerto.TabIndex = 2;
            // 
            // Puerto_label
            // 
            this.Puerto_label.AutoSize = true;
            this.Puerto_label.Location = new System.Drawing.Point(12, 53);
            this.Puerto_label.Name = "Puerto_label";
            this.Puerto_label.Size = new System.Drawing.Size(70, 28);
            this.Puerto_label.TabIndex = 3;
            this.Puerto_label.Text = "Puerto";
            // 
            // Btn_Encender
            // 
            this.Btn_Encender.Location = new System.Drawing.Point(351, 7);
            this.Btn_Encender.Name = "Btn_Encender";
            this.Btn_Encender.Size = new System.Drawing.Size(118, 34);
            this.Btn_Encender.TabIndex = 4;
            this.Btn_Encender.Text = "Encender";
            this.Btn_Encender.UseVisualStyleBackColor = true;
            this.Btn_Encender.Click += new System.EventHandler(this.Btn_Encender_Click);
            // 
            // txt_Mensaje
            // 
            this.txt_Mensaje.Location = new System.Drawing.Point(88, 93);
            this.txt_Mensaje.Name = "txt_Mensaje";
            this.txt_Mensaje.Size = new System.Drawing.Size(385, 34);
            this.txt_Mensaje.TabIndex = 5;
            // 
            // Btn_Apagar
            // 
            this.Btn_Apagar.Location = new System.Drawing.Point(351, 53);
            this.Btn_Apagar.Name = "Btn_Apagar";
            this.Btn_Apagar.Size = new System.Drawing.Size(122, 34);
            this.Btn_Apagar.TabIndex = 6;
            this.Btn_Apagar.Text = "Apagar";
            this.Btn_Apagar.UseVisualStyleBackColor = true;
            this.Btn_Apagar.Click += new System.EventHandler(this.Btn_Apagar_Click);
            // 
            // LED_Estado_1
            // 
            this.LED_Estado_1.AutoSize = true;
            this.LED_Estado_1.Location = new System.Drawing.Point(88, 167);
            this.LED_Estado_1.Name = "LED_Estado_1";
            this.LED_Estado_1.Size = new System.Drawing.Size(164, 28);
            this.LED_Estado_1.TabIndex = 7;
            this.LED_Estado_1.Text = "Estado del LED_1:";
            // 
            // LED_ON
            // 
            this.LED_ON.AutoSize = true;
            this.LED_ON.Location = new System.Drawing.Point(269, 167);
            this.LED_ON.Name = "LED_ON";
            this.LED_ON.Size = new System.Drawing.Size(42, 28);
            this.LED_ON.TabIndex = 8;
            this.LED_ON.Text = "ON";
            this.LED_ON.Visible = false;
            // 
            // LED_OFF
            // 
            this.LED_OFF.AutoSize = true;
            this.LED_OFF.Location = new System.Drawing.Point(269, 167);
            this.LED_OFF.Name = "LED_OFF";
            this.LED_OFF.Size = new System.Drawing.Size(47, 28);
            this.LED_OFF.TabIndex = 9;
            this.LED_OFF.Text = "OFF";
            this.LED_OFF.Visible = false;
            // 
            // LED_Estado_2
            // 
            this.LED_Estado_2.AutoSize = true;
            this.LED_Estado_2.Location = new System.Drawing.Point(88, 235);
            this.LED_Estado_2.Name = "LED_Estado_2";
            this.LED_Estado_2.Size = new System.Drawing.Size(169, 28);
            this.LED_Estado_2.TabIndex = 10;
            this.LED_Estado_2.Text = "Estado del LED_2 :";
            // 
            // LED2_OFF
            // 
            this.LED2_OFF.AutoSize = true;
            this.LED2_OFF.Location = new System.Drawing.Point(269, 235);
            this.LED2_OFF.Name = "LED2_OFF";
            this.LED2_OFF.Size = new System.Drawing.Size(47, 28);
            this.LED2_OFF.TabIndex = 12;
            this.LED2_OFF.Text = "OFF";
            this.LED2_OFF.Visible = false;
            // 
            // LED2_ON
            // 
            this.LED2_ON.AutoSize = true;
            this.LED2_ON.Location = new System.Drawing.Point(269, 235);
            this.LED2_ON.Name = "LED2_ON";
            this.LED2_ON.Size = new System.Drawing.Size(42, 28);
            this.LED2_ON.TabIndex = 11;
            this.LED2_ON.Text = "ON";
            this.LED2_ON.Visible = false;
            // 
            // Form_Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 307);
            this.Controls.Add(this.LED2_OFF);
            this.Controls.Add(this.LED2_ON);
            this.Controls.Add(this.LED_Estado_2);
            this.Controls.Add(this.LED_OFF);
            this.Controls.Add(this.LED_ON);
            this.Controls.Add(this.LED_Estado_1);
            this.Controls.Add(this.Btn_Apagar);
            this.Controls.Add(this.txt_Mensaje);
            this.Controls.Add(this.Btn_Encender);
            this.Controls.Add(this.Puerto_label);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.IP_label);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 356);
            this.MinimumSize = new System.Drawing.Size(510, 356);
            this.Name = "Form_Servidor";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.Form_Servidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IP_label;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label Puerto_label;
        private System.Windows.Forms.Button Btn_Encender;
        private System.Windows.Forms.TextBox txt_Mensaje;
        private System.Windows.Forms.Button Btn_Apagar;
        private System.Windows.Forms.Label LED_Estado_1;
        private System.Windows.Forms.Label LED_ON;
        private System.Windows.Forms.Label LED_OFF;
        private System.Windows.Forms.Label LED_Estado_2;
        private System.Windows.Forms.Label LED2_OFF;
        private System.Windows.Forms.Label LED2_ON;
    }
}

