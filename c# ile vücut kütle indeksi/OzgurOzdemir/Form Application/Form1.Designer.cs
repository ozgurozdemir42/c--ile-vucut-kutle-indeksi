
namespace Form_Application
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kilo_textBox = new System.Windows.Forms.TextBox();
            this.boy_textBox = new System.Windows.Forms.TextBox();
            this.hesapla_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ad_textBox = new System.Windows.Forms.TextBox();
            this.soyad_textBox = new System.Windows.Forms.TextBox();
            this.sonuc_Label = new System.Windows.Forms.Label();
            this.sonuc_label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boy";
            // 
            // kilo_textBox
            // 
            this.kilo_textBox.Location = new System.Drawing.Point(294, 132);
            this.kilo_textBox.Name = "kilo_textBox";
            this.kilo_textBox.Size = new System.Drawing.Size(100, 20);
            this.kilo_textBox.TabIndex = 2;
            // 
            // boy_textBox
            // 
            this.boy_textBox.Location = new System.Drawing.Point(294, 179);
            this.boy_textBox.Name = "boy_textBox";
            this.boy_textBox.Size = new System.Drawing.Size(100, 20);
            this.boy_textBox.TabIndex = 3;
            // 
            // hesapla_Button
            // 
            this.hesapla_Button.Location = new System.Drawing.Point(294, 222);
            this.hesapla_Button.Name = "hesapla_Button";
            this.hesapla_Button.Size = new System.Drawing.Size(75, 23);
            this.hesapla_Button.TabIndex = 4;
            this.hesapla_Button.Text = "Hesapla";
            this.hesapla_Button.UseVisualStyleBackColor = true;
            this.hesapla_Button.Click += new System.EventHandler(this.hesapla_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soyad";
            // 
            // ad_textBox
            // 
            this.ad_textBox.Location = new System.Drawing.Point(199, 85);
            this.ad_textBox.Name = "ad_textBox";
            this.ad_textBox.Size = new System.Drawing.Size(100, 20);
            this.ad_textBox.TabIndex = 8;
            // 
            // soyad_textBox
            // 
            this.soyad_textBox.Location = new System.Drawing.Point(334, 85);
            this.soyad_textBox.Name = "soyad_textBox";
            this.soyad_textBox.Size = new System.Drawing.Size(100, 20);
            this.soyad_textBox.TabIndex = 9;
            // 
            // sonuc_Label
            // 
            this.sonuc_Label.AutoSize = true;
            this.sonuc_Label.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.sonuc_Label.Location = new System.Drawing.Point(301, 269);
            this.sonuc_Label.Name = "sonuc_Label";
            this.sonuc_Label.Size = new System.Drawing.Size(19, 22);
            this.sonuc_Label.TabIndex = 5;
            this.sonuc_Label.Text = "?";
            // 
            // sonuc_label2
            // 
            this.sonuc_label2.AutoSize = true;
            this.sonuc_label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.sonuc_label2.Location = new System.Drawing.Point(301, 303);
            this.sonuc_label2.Name = "sonuc_label2";
            this.sonuc_label2.Size = new System.Drawing.Size(19, 22);
            this.sonuc_label2.TabIndex = 10;
            this.sonuc_label2.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 357);
            this.Controls.Add(this.sonuc_label2);
            this.Controls.Add(this.soyad_textBox);
            this.Controls.Add(this.ad_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sonuc_Label);
            this.Controls.Add(this.hesapla_Button);
            this.Controls.Add(this.boy_textBox);
            this.Controls.Add(this.kilo_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kilo_textBox;
        private System.Windows.Forms.TextBox boy_textBox;
        private System.Windows.Forms.Button hesapla_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ad_textBox;
        private System.Windows.Forms.TextBox soyad_textBox;
        private System.Windows.Forms.Label sonuc_Label;
        private System.Windows.Forms.Label sonuc_label2;
    }
}

