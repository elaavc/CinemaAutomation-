using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemaotomasyonu
{
    public partial class SalonC : Form
    {
        private List<Button> koltuklar = new List<Button>();
        private List<Button> gunButonlari = new List<Button>();
        private List<Button> saatButonlari = new List<Button>();

        private DateTime seciliGun;
        private TimeSpan seciliSaat;
        private bool gunSecildiMi = false;
        private bool saatSecildiMi = false;
        private bool koltukOnaylandi = false;
        private int secilenKoltukSayisi = 0;
        private List<Button> kullaniciKoltuklari = new List<Button>();

        public SalonC()
        {
            InitializeComponent();

            this.Text = "SalonC";
            this.Size = new Size(650, 480);

            ArayuzuOlustur();
            RastgeleDoldur();
        }

        private void ArayuzuOlustur()
        {
            Panel pnl = new Panel();
            pnl.Location = new Point(20, 20);
            pnl.Size = new Size(300, 310);
            this.Controls.Add(pnl);

            int no = 1;
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(45, 45);
                    btn.Location = new Point(c * 50, r * 50);
                    btn.Text = no.ToString();
                    btn.BackColor = Color.LightGray;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += Koltuk_Click;

                    koltuklar.Add(btn);
                    pnl.Controls.Add(btn);
                    no++;
                }
            }

            Button btnKoltukAktif = new Button();
            btnKoltukAktif.Text = "Koltuk Seç";
            btnKoltukAktif.Location = new Point(20, 340);
            btnKoltukAktif.Size = new Size(120, 35);
            btnKoltukAktif.BackColor = Color.LightGoldenrodYellow;
            btnKoltukAktif.Click += KoltukAktif_Click;
            this.Controls.Add(btnKoltukAktif);

            DateTime baslangic = new DateTime(2026, 6, 1);
            for (int i = 0; i < 4; i++)
            {
                Button btnG = new Button();
                DateTime t = baslangic.AddDays(i);
                btnG.Text = t.ToString("dd MMMM yyyy");
                btnG.Tag = t;
                btnG.Location = new Point(340, 45 + (i * 35));
                btnG.Size = new Size(130, 30);
                btnG.FlatStyle = FlatStyle.Flat;
                btnG.BackColor = Color.LightGray;
                btnG.Click += Gun_Click;

                gunButonlari.Add(btnG);
                this.Controls.Add(btnG);
            }

            string[] st = { "09:30", "10:00", "13:30", "19:00" };
            for (int i = 0; i < st.Length; i++)
            {
                Button btnS = new Button();
                btnS.Text = st[i];
                btnS.Tag = TimeSpan.Parse(st[i]);
                btnS.Location = new Point(490, 45 + (i * 35));
                btnS.Size = new Size(80, 30);
                btnS.FlatStyle = FlatStyle.Flat;
                btnS.BackColor = Color.LightGray;
                btnS.Click += Saat_Click;

                saatButonlari.Add(btnS);
                this.Controls.Add(btnS);
            }

            Button btnAl = new Button();
            btnAl.Text = "Devam Et";
            btnAl.Location = new Point(340, 250);
            btnAl.Size = new Size(230, 60);
            btnAl.BackColor = Color.LightGreen;
            btnAl.Click += BiletAl_Click;
            this.Controls.Add(btnAl);

            Label lblKoltukSayisi = new Label();
            lblKoltukSayisi.Name = "lblKoltukSayisi";
            lblKoltukSayisi.Text = "Seçilen Koltuk Sayısı: 0";
            lblKoltukSayisi.Location = new Point(340, 330);
            lblKoltukSayisi.Size = new Size(230, 30);
            this.Controls.Add(lblKoltukSayisi);

            Button btnTemizle = new Button();
            btnTemizle.Text = "Seçimi İptal Et";
            btnTemizle.Location = new Point(340, 370);
            btnTemizle.Size = new Size(230, 40);
            btnTemizle.BackColor = Color.LightCoral;
            btnTemizle.Click += Temizle_Click;
            this.Controls.Add(btnTemizle);
        }

        private void RastgeleDoldur()
        {
            Random rnd = new Random();
            int adet = rnd.Next(5, 15);
            for (int i = 0; i < adet; i++)
            {
                int idx = rnd.Next(0, 30);
                koltuklar[idx].BackColor = Color.Red;
            }
        }

        private void KoltukAktif_Click(object sender, EventArgs e)
        {
            bool secimYapildiMi = false;

            foreach (Button k in koltuklar)
            {
                if (k.BackColor == Color.Green)
                {
                    k.BackColor = Color.Red;
                    secimYapildiMi = true;

                    if (!kullaniciKoltuklari.Contains(k))
                    {
                        kullaniciKoltuklari.Add(k);
                    }
                }
            }

            if (secimYapildiMi)
            {
                koltukOnaylandi = true;
            }
            else
            {
                MessageBox.Show("Lütfen önce boş koltuklardan seçim yapın.");
            }
        }

        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor == Color.Red)
                return;

            if (btn.BackColor == Color.LightGray)
            {
                btn.BackColor = Color.Green;
                secilenKoltukSayisi++;
            }
            else if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.LightGray;
                secilenKoltukSayisi--;
            }

            Label lbl = (Label)this.Controls["lblKoltukSayisi"];
            lbl.Text = "Seçilen Koltuk: " + secilenKoltukSayisi;
        }

        private void Gun_Click(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;

            if (tiklanan.BackColor == Color.Green)
            {
                tiklanan.BackColor = Color.LightGray;
                gunSecildiMi = false;
                return;
            }

            foreach (Button b in gunButonlari) b.BackColor = Color.LightGray;
            tiklanan.BackColor = Color.Green;
            seciliGun = (DateTime)tiklanan.Tag;
            gunSecildiMi = true;
        }

        private void Saat_Click(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;

            if (tiklanan.BackColor == Color.Green)
            {
                tiklanan.BackColor = Color.LightGray;
                saatSecildiMi = false;
                return;
            }

            foreach (Button b in saatButonlari) b.BackColor = Color.LightGray;
            tiklanan.BackColor = Color.Green;
            seciliSaat = (TimeSpan)tiklanan.Tag;
            saatSecildiMi = true;
        }

        private void BiletAl_Click(object sender, EventArgs e)
        {
            if (!gunSecildiMi || !saatSecildiMi)
            {
                MessageBox.Show("Lütfen önce gün ve saat seçin!");
                return;
            }

            DateTime secilen = seciliGun.Date + seciliSaat;
            if (secilen < DateTime.Now)
            {
                MessageBox.Show("Zamanı geçmiş seans! Bilet alınamaz.");
                return;
            }

            bool yesilKoltukVarMi = false;
            foreach (Button k in koltuklar)
            {
                if (k.BackColor == Color.Green)
                {
                    yesilKoltukVarMi = true;
                    break;
                }
            }

            if (yesilKoltukVarMi)
            {
                MessageBox.Show("Lütfen önce koltuk seçimi yapın!");
                return;
            }

            if (!koltukOnaylandi)
            {
                MessageBox.Show("Lütfen önce koltuk seçimi yapın!");
                return;
            }

            BiletSatinAl form = new BiletSatinAl(secilenKoltukSayisi);
            form.Show();
            this.Hide();
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            foreach (Button k in kullaniciKoltuklari)
            {
                k.BackColor = Color.LightGray;
            }

            foreach (Button k in koltuklar)
            {
                if (k.BackColor == Color.Green)
                {
                    k.BackColor = Color.LightGray;
                }
            }

            kullaniciKoltuklari.Clear();

            secilenKoltukSayisi = 0;

            Label lbl = (Label)this.Controls["lblKoltukSayisi"];
            lbl.Text = "Seçilen Koltuk: 0";

            koltukOnaylandi = false;
        }
    }
}

