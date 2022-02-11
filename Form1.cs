using digitalSignature.SignatureAlgorithms;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;


namespace KriptolojiTez
{
    public partial class Form1 : Form
    {
        //-------Fields----------------------
        string algoritmaTipi = string.Empty;
        string hashTipi = string.Empty;
        string dosyaTipi = string.Empty;
        string dosyaYolu = string.Empty;
        string DosyaAdi = "";
        //----------------------------------
        RSACryptoServiceProvider RSA;
        DSACryptoServiceProvider DSA;
        ECDsaCng ecdsa;

        public Form1()
        {
            RSA = new RSACryptoServiceProvider();
            DSA = new DSACryptoServiceProvider();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gBoxİmzalamaSifreleme.Visible = false;
            lblcpuKullanimi.Text = "";
            lblramKullanimi.Text = "";              
            lblcalismaSuresi.Text = "";
            

        }

        private void sBoxAlgoritmaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            algoritmaTipi = sBoxAlgoritmaTipi.SelectedItem.ToString();
            sBoxDosyaTipi.Enabled = true;
            sBoxHashTipi.Enabled = true;
            gBoxİmzalamaSifreleme.Visible = true;
            if (algoritmaTipi == "RSA")
            {
                sBoxDosyaTipi.DataSource = ComboBoxDatas.getFileTypesForRSA();
                sBoxHashTipi.DataSource = ComboBoxDatas.getHashTypesForRSA();
            }
            else if (algoritmaTipi == "DSA")
            {
                sBoxDosyaTipi.DataSource = ComboBoxDatas.getFileTypesForDSA();
                sBoxHashTipi.DataSource = ComboBoxDatas.getHashTypesForDSA();
            }
            else if (algoritmaTipi == "ECDsaCNG")
            {
                sBoxDosyaTipi.DataSource = ComboBoxDatas.getFileTypesForECDsaCNG();
                sBoxHashTipi.DataSource = ComboBoxDatas.getHashTypesForECDsaCNG();
            }
        }

        private void sBoxHashTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            hashTipi = sBoxHashTipi.SelectedItem.ToString();
        }

        private void sBoxDosyaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            dosyaTipi = sBoxDosyaTipi.SelectedItem.ToString();
        }

        private void btnFileUploader_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (dosyaTipi == ComboBoxDatas.tip1)//.rar
            {
                file.Filter = "Rar Dosyası |*.rar";
            }
            else if (dosyaTipi == ComboBoxDatas.tip2)//.zip
            {
                file.Filter = "Zip Dosyası |*.zip";
            }
            else if (dosyaTipi == ComboBoxDatas.tip3)//.txt
            {
                file.Filter = "Metin Dosyası |*.txt";
            }
            else if (dosyaTipi == ComboBoxDatas.tip4)//.docx
            {
                file.Filter = "Word Dosyası |*.docx";
            }
            else if (dosyaTipi == ComboBoxDatas.tip5)//.pdf
            {
                file.Filter = "Pdf Dosyası |*.pdf";
            }

            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Dosya Seçiniz";

            if (file.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = file.FileName;
                DosyaAdi = file.SafeFileName;
                lblFilePath.Text = DosyaAdi;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            lblHashSign.Text = " ";
            
            
            if (algoritmaTipi=="RSA")
            {
                
                Stopwatch SureHesapla = new Stopwatch();
                SureHesapla.Start();
                timer1.Start();               
                RSASign _rsaObj = new RSASign(RSA);
                var temp=_rsaObj.Sign(dosyaYolu,hashTipi);
                timer1.Stop();
                SureHesapla.Stop();                
                getCurrentCpuUsage();
                getAvailableRAM();               
                TimeSpan HesaplananZaman = SureHesapla.Elapsed;
                string sure=String.Format("{0:00}:{1:00}",HesaplananZaman.Milliseconds/10,HesaplananZaman.Milliseconds);
                string sonuc = DosyaAdi + " dosyasının Hashi:\n" + _rsaObj.PrintByteArray(temp.Item1) + "\n E-imzası:\n" + _rsaObj.PrintByteArray(temp.Item2);
                lblHashSign.Text=sonuc;
                lblcalismaSuresi.Text = sure;
                lblanahtarBoyutu.Text = Convert.ToString(temp.Item4);
            }
            else if (algoritmaTipi == "DSA")
            {

                Stopwatch SureHesapla = new Stopwatch();
                SureHesapla.Start();
                timer1.Start();
                DSASign _dsaObj = new DSASign(DSA);
                var temp = _dsaObj.Sign(dosyaYolu, hashTipi);
                timer1.Stop();
                SureHesapla.Stop();
                getCurrentCpuUsage();
                getAvailableRAM();
                TimeSpan HesaplananZaman = SureHesapla.Elapsed;
                string sure = String.Format("{0:00}:{1:00}", HesaplananZaman.Milliseconds / 10, HesaplananZaman.Milliseconds);
                string sonuc = DosyaAdi + " dosyasının Hashi:\n" + _dsaObj.PrintByteArray(temp.Item1) + "\n E-imzası:\n" + _dsaObj.PrintByteArray(temp.Item2);
                lblHashSign.Text = sonuc;
                lblcalismaSuresi.Text = sure;
                lblanahtarBoyutu.Text = Convert.ToString(temp.Item5);
            }
            else if(algoritmaTipi=="ECDsaCNG")
            {
                Stopwatch SureHesapla = new Stopwatch();
                SureHesapla.Start();
                timer1.Start();
                ECDsaCNG _ecdsacng = new ECDsaCNG(ecdsa);
                var temp = _ecdsacng.Sign(dosyaYolu, hashTipi);
                timer1.Stop();
                SureHesapla.Stop();
                getCurrentCpuUsage();
                getAvailableRAM();
                TimeSpan HesaplananZaman = SureHesapla.Elapsed;
                string sure = String.Format("{0:00}:{1:00}", HesaplananZaman.Milliseconds / 10, HesaplananZaman.Milliseconds);
                string sonuc = DosyaAdi + " dosyasının Hashi:\n" + _ecdsacng.PrintByteArray(temp.Item1) + "\n E-imzası:\n" + _ecdsacng.PrintByteArray(temp.Item2);
                lblHashSign.Text = sonuc;
                lblcalismaSuresi.Text = sure;
                lblanahtarBoyutu.Text = Convert.ToString(temp.Item5);
            }
            
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            
            if (algoritmaTipi == "RSA")
            {
                Stopwatch SureHesapla = new Stopwatch();
                SureHesapla.Start();
                timer1.Start();
                RSASign _rsaObj = new RSASign(RSA);
                var temp1 = _rsaObj.Sign(dosyaYolu, hashTipi);
                lblimzalandı.Text = _rsaObj.Verify(hashTipi,temp1.Item1,temp1.Item2);
                timer1.Stop();
                SureHesapla.Stop();
                getCurrentCpuUsage();
                getAvailableRAM();
                TimeSpan HesaplananZaman = SureHesapla.Elapsed;
                string sure = String.Format("{0:00}:{1:00}", HesaplananZaman.Milliseconds / 10, HesaplananZaman.Milliseconds);
                lblcalismaSuresi.Text = sure;
            }
            else if (algoritmaTipi == "DSA")
            {
                Stopwatch SureHesapla = new Stopwatch();
                SureHesapla.Start();
                timer1.Start();
                DSASign _dsaObj = new DSASign(DSA);
                var temp1 = _dsaObj.Sign(dosyaYolu, hashTipi);
                lblimzalandı.Text = Convert.ToString(_dsaObj.Verify(hashTipi, temp1.Item1, temp1.Item2));
                timer1.Stop();
                SureHesapla.Stop();
                getCurrentCpuUsage();
                getAvailableRAM();
                TimeSpan HesaplananZaman = SureHesapla.Elapsed;
                string sure = String.Format("{0:00}:{1:00}", HesaplananZaman.Milliseconds / 10, HesaplananZaman.Milliseconds);
                lblcalismaSuresi.Text = sure;
            }
            else if (algoritmaTipi == "ECDsaCNG")
            {
                Stopwatch SureHesapla = new Stopwatch();
                SureHesapla.Start();
                timer1.Start();
                ECDsaCNG _ecdsacng = new ECDsaCNG(ecdsa);                
                var temp1 = _ecdsacng.Sign(dosyaYolu, hashTipi);
                string temp = _ecdsacng.Receive(temp1.Item1, temp1.Item2,temp1.Item6);
                lblimzalandı.Text = temp;
                timer1.Stop();
                SureHesapla.Stop();
                getCurrentCpuUsage();
                getAvailableRAM();
                TimeSpan HesaplananZaman = SureHesapla.Elapsed;
                string sure = String.Format("{0:00}:{1:00}", HesaplananZaman.Milliseconds / 10, HesaplananZaman.Milliseconds);
                lblcalismaSuresi.Text = sure;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            lblcpu1.Text = cpuCount.NextValue().ToString();
            lblram1.Text = ramCount.NextValue().ToString();
           
        }


        
        //PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        public string getCurrentCpuUsage()
        {
            
            
            return lblcpuKullanimi.Text = cpuCount.NextValue() + "%";

        }
       

        public string getAvailableRAM()
        {
            return lblramKullanimi.Text=ramCount.NextValue().ToString() + " MB";
        }

    }
        }
    

