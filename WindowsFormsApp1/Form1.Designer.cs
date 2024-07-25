namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.sınavNetiHesaplama = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTurkceDogru = new System.Windows.Forms.TextBox();
            this.txbTurkceYanlis = new System.Windows.Forms.TextBox();
            this.txbTurkceNet = new System.Windows.Forms.TextBox();
            this.txbMatDogru = new System.Windows.Forms.TextBox();
            this.txbMatYanlis = new System.Windows.Forms.TextBox();
            this.txbMatematikNet = new System.Windows.Forms.TextBox();
            this.btnNetHesapla = new System.Windows.Forms.Button();
            this.sınavNetiHesaplama.SuspendLayout();
            this.SuspendLayout();
            // 
            // sınavNetiHesaplama
            // 
            this.sınavNetiHesaplama.Controls.Add(this.btnNetHesapla);
            this.sınavNetiHesaplama.Controls.Add(this.txbMatematikNet);
            this.sınavNetiHesaplama.Controls.Add(this.txbMatYanlis);
            this.sınavNetiHesaplama.Controls.Add(this.txbMatDogru);
            this.sınavNetiHesaplama.Controls.Add(this.txbTurkceNet);
            this.sınavNetiHesaplama.Controls.Add(this.txbTurkceYanlis);
            this.sınavNetiHesaplama.Controls.Add(this.txbTurkceDogru);
            this.sınavNetiHesaplama.Controls.Add(this.label5);
            this.sınavNetiHesaplama.Controls.Add(this.label4);
            this.sınavNetiHesaplama.Controls.Add(this.label3);
            this.sınavNetiHesaplama.Controls.Add(this.label2);
            this.sınavNetiHesaplama.Controls.Add(this.label1);
            this.sınavNetiHesaplama.Location = new System.Drawing.Point(59, 40);
            this.sınavNetiHesaplama.Name = "sınavNetiHesaplama";
            this.sınavNetiHesaplama.Size = new System.Drawing.Size(291, 183);
            this.sınavNetiHesaplama.TabIndex = 0;
            this.sınavNetiHesaplama.TabStop = false;
            this.sınavNetiHesaplama.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yanlış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Net";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Türkçe";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Matematik";
            // 
            // txbTurkceDogru
            // 
            this.txbTurkceDogru.Location = new System.Drawing.Point(126, 54);
            this.txbTurkceDogru.Name = "txbTurkceDogru";
            this.txbTurkceDogru.Size = new System.Drawing.Size(33, 20);
            this.txbTurkceDogru.TabIndex = 5;
            // 
            // txbTurkceYanlis
            // 
            this.txbTurkceYanlis.Location = new System.Drawing.Point(183, 54);
            this.txbTurkceYanlis.Name = "txbTurkceYanlis";
            this.txbTurkceYanlis.Size = new System.Drawing.Size(33, 20);
            this.txbTurkceYanlis.TabIndex = 6;
            // 
            // txbTurkceNet
            // 
            this.txbTurkceNet.Location = new System.Drawing.Point(240, 54);
            this.txbTurkceNet.Name = "txbTurkceNet";
            this.txbTurkceNet.ReadOnly = true;
            this.txbTurkceNet.Size = new System.Drawing.Size(33, 20);
            this.txbTurkceNet.TabIndex = 7;
            // 
            // txbMatDogru
            // 
            this.txbMatDogru.Location = new System.Drawing.Point(126, 83);
            this.txbMatDogru.Name = "txbMatDogru";
            this.txbMatDogru.Size = new System.Drawing.Size(33, 20);
            this.txbMatDogru.TabIndex = 8;
            // 
            // txbMatYanlis
            // 
            this.txbMatYanlis.Location = new System.Drawing.Point(182, 86);
            this.txbMatYanlis.Name = "txbMatYanlis";
            this.txbMatYanlis.Size = new System.Drawing.Size(33, 20);
            this.txbMatYanlis.TabIndex = 9;
            // 
            // txbMatematikNet
            // 
            this.txbMatematikNet.Location = new System.Drawing.Point(240, 86);
            this.txbMatematikNet.Name = "txbMatematikNet";
            this.txbMatematikNet.ReadOnly = true;
            this.txbMatematikNet.Size = new System.Drawing.Size(33, 20);
            this.txbMatematikNet.TabIndex = 10;
            // 
            // btnNetHesapla
            // 
            this.btnNetHesapla.Location = new System.Drawing.Point(24, 134);
            this.btnNetHesapla.Name = "btnNetHesapla";
            this.btnNetHesapla.Size = new System.Drawing.Size(249, 23);
            this.btnNetHesapla.TabIndex = 11;
            this.btnNetHesapla.Text = "Net Hesapla";
            this.btnNetHesapla.UseVisualStyleBackColor = true;
            this.btnNetHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sınavNetiHesaplama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sınavNetiHesaplama.ResumeLayout(false);
            this.sınavNetiHesaplama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sınavNetiHesaplama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNetHesapla;
        private System.Windows.Forms.TextBox txbMatematikNet;
        private System.Windows.Forms.TextBox txbMatYanlis;
        private System.Windows.Forms.TextBox txbMatDogru;
        private System.Windows.Forms.TextBox txbTurkceNet;
        private System.Windows.Forms.TextBox txbTurkceYanlis;
        private System.Windows.Forms.TextBox txbTurkceDogru;
    }
}

