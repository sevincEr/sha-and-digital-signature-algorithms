namespace KriptolojiTez
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
            this.components = new System.ComponentModel.Container();
            this.cpuCount = new System.Diagnostics.PerformanceCounter();
            this.ramCount = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sBoxAlgoritmaTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sBoxDosyaTipi = new System.Windows.Forms.ComboBox();
            this.gBoxSonucVerileri = new System.Windows.Forms.GroupBox();
            this.gBoxAnahtarBoyutu = new System.Windows.Forms.GroupBox();
            this.lblanahtarBoyutu = new System.Windows.Forms.Label();
            this.gBoxKaynak = new System.Windows.Forms.GroupBox();
            this.lblcpu1 = new System.Windows.Forms.Label();
            this.lblram1 = new System.Windows.Forms.Label();
            this.lblramKullanimi = new System.Windows.Forms.Label();
            this.lblcpuKullanimi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gBoxCalismaSuresi = new System.Windows.Forms.GroupBox();
            this.lblcalismaSuresi = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnFileUploader = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblimzalandı = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.gBoxHashSign = new System.Windows.Forms.GroupBox();
            this.lblHashSign = new System.Windows.Forms.Label();
            this.gBoxİmzalamaSifreleme = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sBoxHashTipi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cpuCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramCount)).BeginInit();
            this.gBoxSonucVerileri.SuspendLayout();
            this.gBoxAnahtarBoyutu.SuspendLayout();
            this.gBoxKaynak.SuspendLayout();
            this.gBoxCalismaSuresi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBoxHashSign.SuspendLayout();
            this.gBoxİmzalamaSifreleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpuCount
            // 
            this.cpuCount.CategoryName = "İşlemci";
            this.cpuCount.CounterName = "% İşlemci Zamanı";
            this.cpuCount.InstanceName = "_Total";
            // 
            // ramCount
            // 
            this.ramCount.CategoryName = "Bellek";
            this.ramCount.CounterName = "Kullanılabilir MBayt";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sBoxAlgoritmaTipi
            // 
            this.sBoxAlgoritmaTipi.FormattingEnabled = true;
            this.sBoxAlgoritmaTipi.Items.AddRange(new object[] {
            "RSA",
            "DSA",
            "ECDsaCNG"});
            this.sBoxAlgoritmaTipi.Location = new System.Drawing.Point(221, 39);
            this.sBoxAlgoritmaTipi.Name = "sBoxAlgoritmaTipi";
            this.sBoxAlgoritmaTipi.Size = new System.Drawing.Size(325, 24);
            this.sBoxAlgoritmaTipi.TabIndex = 7;
            this.sBoxAlgoritmaTipi.SelectedIndexChanged += new System.EventHandler(this.sBoxAlgoritmaTipi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Algoritma Seçiniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dosya Tipini Seçiniz :";
            // 
            // sBoxDosyaTipi
            // 
            this.sBoxDosyaTipi.Enabled = false;
            this.sBoxDosyaTipi.FormattingEnabled = true;
            this.sBoxDosyaTipi.Items.AddRange(new object[] {
            ".doc/.docx",
            ".txt",
            ".exe",
            ""});
            this.sBoxDosyaTipi.Location = new System.Drawing.Point(221, 99);
            this.sBoxDosyaTipi.Name = "sBoxDosyaTipi";
            this.sBoxDosyaTipi.Size = new System.Drawing.Size(325, 24);
            this.sBoxDosyaTipi.TabIndex = 10;
            this.sBoxDosyaTipi.SelectedIndexChanged += new System.EventHandler(this.sBoxDosyaTipi_SelectedIndexChanged);
            // 
            // gBoxSonucVerileri
            // 
            this.gBoxSonucVerileri.Controls.Add(this.gBoxAnahtarBoyutu);
            this.gBoxSonucVerileri.Controls.Add(this.gBoxKaynak);
            this.gBoxSonucVerileri.Controls.Add(this.gBoxCalismaSuresi);
            this.gBoxSonucVerileri.Location = new System.Drawing.Point(31, 306);
            this.gBoxSonucVerileri.Name = "gBoxSonucVerileri";
            this.gBoxSonucVerileri.Size = new System.Drawing.Size(501, 226);
            this.gBoxSonucVerileri.TabIndex = 13;
            this.gBoxSonucVerileri.TabStop = false;
            this.gBoxSonucVerileri.Text = "Sonuç Verileri";
            // 
            // gBoxAnahtarBoyutu
            // 
            this.gBoxAnahtarBoyutu.Controls.Add(this.lblanahtarBoyutu);
            this.gBoxAnahtarBoyutu.Location = new System.Drawing.Point(6, 160);
            this.gBoxAnahtarBoyutu.Name = "gBoxAnahtarBoyutu";
            this.gBoxAnahtarBoyutu.Size = new System.Drawing.Size(483, 53);
            this.gBoxAnahtarBoyutu.TabIndex = 12;
            this.gBoxAnahtarBoyutu.TabStop = false;
            this.gBoxAnahtarBoyutu.Text = "Anahtar Boyutu";
            // 
            // lblanahtarBoyutu
            // 
            this.lblanahtarBoyutu.AutoSize = true;
            this.lblanahtarBoyutu.Location = new System.Drawing.Point(185, 18);
            this.lblanahtarBoyutu.Name = "lblanahtarBoyutu";
            this.lblanahtarBoyutu.Size = new System.Drawing.Size(106, 17);
            this.lblanahtarBoyutu.TabIndex = 0;
            this.lblanahtarBoyutu.Text = "Anahtar Boyutu";
            // 
            // gBoxKaynak
            // 
            this.gBoxKaynak.Controls.Add(this.lblcpu1);
            this.gBoxKaynak.Controls.Add(this.lblram1);
            this.gBoxKaynak.Controls.Add(this.lblramKullanimi);
            this.gBoxKaynak.Controls.Add(this.lblcpuKullanimi);
            this.gBoxKaynak.Controls.Add(this.label6);
            this.gBoxKaynak.Controls.Add(this.label5);
            this.gBoxKaynak.Location = new System.Drawing.Point(6, 33);
            this.gBoxKaynak.Name = "gBoxKaynak";
            this.gBoxKaynak.Size = new System.Drawing.Size(483, 66);
            this.gBoxKaynak.TabIndex = 10;
            this.gBoxKaynak.TabStop = false;
            this.gBoxKaynak.Text = "Kaynak Kullanımları";
            // 
            // lblcpu1
            // 
            this.lblcpu1.AutoSize = true;
            this.lblcpu1.Location = new System.Drawing.Point(381, 44);
            this.lblcpu1.Name = "lblcpu1";
            this.lblcpu1.Size = new System.Drawing.Size(44, 17);
            this.lblcpu1.TabIndex = 12;
            this.lblcpu1.Text = "CPU1";
            // 
            // lblram1
            // 
            this.lblram1.AutoSize = true;
            this.lblram1.Location = new System.Drawing.Point(381, 27);
            this.lblram1.Name = "lblram1";
            this.lblram1.Size = new System.Drawing.Size(45, 17);
            this.lblram1.TabIndex = 11;
            this.lblram1.Text = "Ram1";
            // 
            // lblramKullanimi
            // 
            this.lblramKullanimi.AutoSize = true;
            this.lblramKullanimi.Location = new System.Drawing.Point(222, 27);
            this.lblramKullanimi.Name = "lblramKullanimi";
            this.lblramKullanimi.Size = new System.Drawing.Size(37, 17);
            this.lblramKullanimi.TabIndex = 8;
            this.lblramKullanimi.Text = "Ram";
            // 
            // lblcpuKullanimi
            // 
            this.lblcpuKullanimi.AutoSize = true;
            this.lblcpuKullanimi.Location = new System.Drawing.Point(221, 44);
            this.lblcpuKullanimi.Name = "lblcpuKullanimi";
            this.lblcpuKullanimi.Size = new System.Drawing.Size(33, 17);
            this.lblcpuKullanimi.TabIndex = 9;
            this.lblcpuKullanimi.Text = "Cpu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPU Kullanımı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "RAM Kullanımı : ";
            // 
            // gBoxCalismaSuresi
            // 
            this.gBoxCalismaSuresi.Controls.Add(this.lblcalismaSuresi);
            this.gBoxCalismaSuresi.Location = new System.Drawing.Point(6, 105);
            this.gBoxCalismaSuresi.Name = "gBoxCalismaSuresi";
            this.gBoxCalismaSuresi.Size = new System.Drawing.Size(483, 49);
            this.gBoxCalismaSuresi.TabIndex = 11;
            this.gBoxCalismaSuresi.TabStop = false;
            this.gBoxCalismaSuresi.Text = "Çalışma Süresi ";
            // 
            // lblcalismaSuresi
            // 
            this.lblcalismaSuresi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcalismaSuresi.AutoSize = true;
            this.lblcalismaSuresi.Location = new System.Drawing.Point(221, 18);
            this.lblcalismaSuresi.Name = "lblcalismaSuresi";
            this.lblcalismaSuresi.Size = new System.Drawing.Size(28, 17);
            this.lblcalismaSuresi.TabIndex = 0;
            this.lblcalismaSuresi.Text = "Hız";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(127, 262);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(97, 40);
            this.btnSign.TabIndex = 13;
            this.btnSign.Text = "İmzalama";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(288, 262);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(97, 40);
            this.btnVerify.TabIndex = 14;
            this.btnVerify.Text = "Doğrulama";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnFileUploader
            // 
            this.btnFileUploader.Location = new System.Drawing.Point(24, 43);
            this.btnFileUploader.Name = "btnFileUploader";
            this.btnFileUploader.Size = new System.Drawing.Size(501, 47);
            this.btnFileUploader.TabIndex = 15;
            this.btnFileUploader.Text = "Dosya Yükle";
            this.btnFileUploader.UseVisualStyleBackColor = true;
            this.btnFileUploader.Click += new System.EventHandler(this.btnFileUploader_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblimzalandı);
            this.groupBox1.Controls.Add(this.lblFilePath);
            this.groupBox1.Location = new System.Drawing.Point(24, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 71);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilen Dosya Adı";
            // 
            // lblimzalandı
            // 
            this.lblimzalandı.AutoSize = true;
            this.lblimzalandı.Location = new System.Drawing.Point(368, 29);
            this.lblimzalandı.Name = "lblimzalandı";
            this.lblimzalandı.Size = new System.Drawing.Size(89, 17);
            this.lblimzalandı.TabIndex = 1;
            this.lblimzalandı.Text = "İmza Sonucu";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(29, 29);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 17);
            this.lblFilePath.TabIndex = 0;
            // 
            // gBoxHashSign
            // 
            this.gBoxHashSign.Controls.Add(this.lblHashSign);
            this.gBoxHashSign.Location = new System.Drawing.Point(24, 173);
            this.gBoxHashSign.Name = "gBoxHashSign";
            this.gBoxHashSign.Size = new System.Drawing.Size(501, 83);
            this.gBoxHashSign.TabIndex = 17;
            this.gBoxHashSign.TabStop = false;
            this.gBoxHashSign.Text = "HASH ve İMZA";
            // 
            // lblHashSign
            // 
            this.lblHashSign.AutoSize = true;
            this.lblHashSign.Location = new System.Drawing.Point(6, 18);
            this.lblHashSign.Name = "lblHashSign";
            this.lblHashSign.Size = new System.Drawing.Size(46, 17);
            this.lblHashSign.TabIndex = 0;
            this.lblHashSign.Text = "sonuc";
            // 
            // gBoxİmzalamaSifreleme
            // 
            this.gBoxİmzalamaSifreleme.Controls.Add(this.gBoxHashSign);
            this.gBoxİmzalamaSifreleme.Controls.Add(this.groupBox1);
            this.gBoxİmzalamaSifreleme.Controls.Add(this.btnFileUploader);
            this.gBoxİmzalamaSifreleme.Controls.Add(this.btnVerify);
            this.gBoxİmzalamaSifreleme.Controls.Add(this.btnSign);
            this.gBoxİmzalamaSifreleme.Controls.Add(this.gBoxSonucVerileri);
            this.gBoxİmzalamaSifreleme.Location = new System.Drawing.Point(51, 152);
            this.gBoxİmzalamaSifreleme.Name = "gBoxİmzalamaSifreleme";
            this.gBoxİmzalamaSifreleme.Size = new System.Drawing.Size(560, 548);
            this.gBoxİmzalamaSifreleme.TabIndex = 11;
            this.gBoxİmzalamaSifreleme.TabStop = false;
            this.gBoxİmzalamaSifreleme.Text = "İmzalama Şifrelemesi";
            this.gBoxİmzalamaSifreleme.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hash Seçiniz :";
            // 
            // sBoxHashTipi
            // 
            this.sBoxHashTipi.Enabled = false;
            this.sBoxHashTipi.FormattingEnabled = true;
            this.sBoxHashTipi.Items.AddRange(new object[] {
            ".doc/.docx",
            ".txt",
            ".exe",
            ""});
            this.sBoxHashTipi.Location = new System.Drawing.Point(221, 69);
            this.sBoxHashTipi.Name = "sBoxHashTipi";
            this.sBoxHashTipi.Size = new System.Drawing.Size(325, 24);
            this.sBoxHashTipi.TabIndex = 13;
            this.sBoxHashTipi.SelectedIndexChanged += new System.EventHandler(this.sBoxHashTipi_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 712);
            this.Controls.Add(this.sBoxHashTipi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gBoxİmzalamaSifreleme);
            this.Controls.Add(this.sBoxDosyaTipi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sBoxAlgoritmaTipi);
            this.Name = "Form1";
            this.Text = "İmzalama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramCount)).EndInit();
            this.gBoxSonucVerileri.ResumeLayout(false);
            this.gBoxAnahtarBoyutu.ResumeLayout(false);
            this.gBoxAnahtarBoyutu.PerformLayout();
            this.gBoxKaynak.ResumeLayout(false);
            this.gBoxKaynak.PerformLayout();
            this.gBoxCalismaSuresi.ResumeLayout(false);
            this.gBoxCalismaSuresi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxHashSign.ResumeLayout(false);
            this.gBoxHashSign.PerformLayout();
            this.gBoxİmzalamaSifreleme.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Diagnostics.PerformanceCounter cpuCount;
        private System.Diagnostics.PerformanceCounter ramCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox sBoxAlgoritmaTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sBoxDosyaTipi;
        private System.Windows.Forms.GroupBox gBoxSonucVerileri;
        private System.Windows.Forms.GroupBox gBoxAnahtarBoyutu;
        private System.Windows.Forms.Label lblanahtarBoyutu;
        private System.Windows.Forms.GroupBox gBoxKaynak;
        private System.Windows.Forms.Label lblramKullanimi;
        private System.Windows.Forms.Label lblcpuKullanimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gBoxCalismaSuresi;
        private System.Windows.Forms.Label lblcalismaSuresi;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnFileUploader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.GroupBox gBoxHashSign;
        private System.Windows.Forms.Label lblHashSign;
        private System.Windows.Forms.GroupBox gBoxİmzalamaSifreleme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sBoxHashTipi;
        private System.Windows.Forms.Label lblcpu1;
        private System.Windows.Forms.Label lblram1;
        private System.Windows.Forms.Label lblimzalandı;
    }
}

