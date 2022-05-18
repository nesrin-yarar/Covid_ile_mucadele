
namespace YMG_Covid_ile_mucadele
{
    partial class sifre_guncelleme
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
            this.hasta_bilgileriTableAdapter1 = new YMG_Covid_ile_mucadele.denemeDataSet1TableAdapters.hasta_bilgileriTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox_yenişifretekrar = new System.Windows.Forms.TextBox();
            this.textBox_yenişfre = new System.Windows.Forms.TextBox();
            this.textBox_eskişifre = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hasta_bilgileriTableAdapter1
            // 
            this.hasta_bilgileriTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(303, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "şifre değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(72, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Yeni şifre (tekrar):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yeni şifre (tekrar):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(82, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yeni şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Eski şifre:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(317, 278);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(98, 22);
            this.textBox4.TabIndex = 13;
            // 
            // textBox_yenişifretekrar
            // 
            this.textBox_yenişifretekrar.Location = new System.Drawing.Point(249, 213);
            this.textBox_yenişifretekrar.Name = "textBox_yenişifretekrar";
            this.textBox_yenişifretekrar.PasswordChar = '*';
            this.textBox_yenişifretekrar.Size = new System.Drawing.Size(166, 22);
            this.textBox_yenişifretekrar.TabIndex = 12;
            // 
            // textBox_yenişfre
            // 
            this.textBox_yenişfre.Location = new System.Drawing.Point(249, 153);
            this.textBox_yenişfre.Name = "textBox_yenişfre";
            this.textBox_yenişfre.PasswordChar = '*';
            this.textBox_yenişfre.Size = new System.Drawing.Size(166, 22);
            this.textBox_yenişfre.TabIndex = 11;
            // 
            // textBox_eskişifre
            // 
            this.textBox_eskişifre.Location = new System.Drawing.Point(249, 94);
            this.textBox_eskişifre.Name = "textBox_eskişifre";
            this.textBox_eskişifre.PasswordChar = '*';
            this.textBox_eskişifre.Size = new System.Drawing.Size(166, 22);
            this.textBox_eskişifre.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Location = new System.Drawing.Point(12, 443);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 27);
            this.button8.TabIndex = 25;
            this.button8.Text = "<<GERİ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // sifre_guncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(466, 482);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox_yenişifretekrar);
            this.Controls.Add(this.textBox_yenişfre);
            this.Controls.Add(this.textBox_eskişifre);
            this.Name = "sifre_guncelleme";
            this.Text = "sifre_guncelleme";
            this.Load += new System.EventHandler(this.sifre_guncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private denemeDataSet1TableAdapters.hasta_bilgileriTableAdapter hasta_bilgileriTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox_yenişifretekrar;
        private System.Windows.Forms.TextBox textBox_yenişfre;
        private System.Windows.Forms.TextBox textBox_eskişifre;
        private System.Windows.Forms.Button button8;
    }
}