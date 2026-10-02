namespace sinemaotomasyonu
{
    partial class BiletSatinAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiletSatinAl));
            this.label1 = new System.Windows.Forms.Label();
            this.lblKoltuk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTamPlus = new System.Windows.Forms.Button();
            this.lblTam = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnTamMinus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOgrenciMinus = new System.Windows.Forms.Button();
            this.btnOgrenciPlus = new System.Windows.Forms.Button();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seçilen Koltuk Sayısı: ";
            // 
            // lblKoltuk
            // 
            this.lblKoltuk.AutoSize = true;
            this.lblKoltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKoltuk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKoltuk.Location = new System.Drawing.Point(255, 59);
            this.lblKoltuk.Name = "lblKoltuk";
            this.lblKoltuk.Size = new System.Drawing.Size(24, 26);
            this.lblKoltuk.TabIndex = 1;
            this.lblKoltuk.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(33, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tam Bilet";
            // 
            // btnTamPlus
            // 
            this.btnTamPlus.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTamPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamPlus.Location = new System.Drawing.Point(312, 142);
            this.btnTamPlus.Name = "btnTamPlus";
            this.btnTamPlus.Size = new System.Drawing.Size(44, 34);
            this.btnTamPlus.TabIndex = 3;
            this.btnTamPlus.Text = "+";
            this.btnTamPlus.UseVisualStyleBackColor = false;
            this.btnTamPlus.Click += new System.EventHandler(this.btnTamPlus_Click);
            // 
            // lblTam
            // 
            this.lblTam.AutoSize = true;
            this.lblTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTam.Location = new System.Drawing.Point(271, 151);
            this.lblTam.Name = "lblTam";
            this.lblTam.Size = new System.Drawing.Size(24, 26);
            this.lblTam.TabIndex = 4;
            this.lblTam.Text = "0";
            this.lblTam.Click += new System.EventHandler(this.lblTam_Click);
            // 
            // btnTamMinus
            // 
            this.btnTamMinus.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTamMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamMinus.Location = new System.Drawing.Point(208, 142);
            this.btnTamMinus.Name = "btnTamMinus";
            this.btnTamMinus.Size = new System.Drawing.Size(44, 34);
            this.btnTamMinus.TabIndex = 5;
            this.btnTamMinus.Text = "-";
            this.btnTamMinus.UseVisualStyleBackColor = false;
            this.btnTamMinus.Click += new System.EventHandler(this.btnTamMinus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(30, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Öğrenci Bilet";
            // 
            // btnOgrenciMinus
            // 
            this.btnOgrenciMinus.BackColor = System.Drawing.Color.LightSalmon;
            this.btnOgrenciMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenciMinus.Location = new System.Drawing.Point(208, 210);
            this.btnOgrenciMinus.Name = "btnOgrenciMinus";
            this.btnOgrenciMinus.Size = new System.Drawing.Size(44, 34);
            this.btnOgrenciMinus.TabIndex = 7;
            this.btnOgrenciMinus.Text = "-";
            this.btnOgrenciMinus.UseVisualStyleBackColor = false;
            this.btnOgrenciMinus.Click += new System.EventHandler(this.btnOgrenciMinus_Click);
            // 
            // btnOgrenciPlus
            // 
            this.btnOgrenciPlus.BackColor = System.Drawing.Color.LightSalmon;
            this.btnOgrenciPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenciPlus.Location = new System.Drawing.Point(312, 210);
            this.btnOgrenciPlus.Name = "btnOgrenciPlus";
            this.btnOgrenciPlus.Size = new System.Drawing.Size(44, 34);
            this.btnOgrenciPlus.TabIndex = 8;
            this.btnOgrenciPlus.Text = "+";
            this.btnOgrenciPlus.UseVisualStyleBackColor = false;
            this.btnOgrenciPlus.Click += new System.EventHandler(this.btnOgrenciPlus_Click);
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrenci.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOgrenci.Location = new System.Drawing.Point(271, 219);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(24, 26);
            this.lblOgrenci.TabIndex = 9;
            this.lblOgrenci.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(33, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Toplam Fiyat: \r\n";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblToplam.Location = new System.Drawing.Point(178, 276);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(54, 26);
            this.lblToplam.TabIndex = 11;
            this.lblToplam.Text = "0 TL";
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackColor = System.Drawing.Color.LightSalmon;
            this.btnOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdeme.Location = new System.Drawing.Point(126, 347);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(240, 51);
            this.btnOdeme.TabIndex = 12;
            this.btnOdeme.Text = "Ödemeyi Tamamla";
            this.btnOdeme.UseVisualStyleBackColor = false;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // BiletSatinAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOgrenci);
            this.Controls.Add(this.btnOgrenciPlus);
            this.Controls.Add(this.btnOgrenciMinus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTamMinus);
            this.Controls.Add(this.lblTam);
            this.Controls.Add(this.btnTamPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKoltuk);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BiletSatinAl";
            this.Text = "CineNova";
            this.Load += new System.EventHandler(this.BiletSatinAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKoltuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTamPlus;
        private System.Windows.Forms.Label lblTam;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTamMinus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOgrenciMinus;
        private System.Windows.Forms.Button btnOgrenciPlus;
        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}