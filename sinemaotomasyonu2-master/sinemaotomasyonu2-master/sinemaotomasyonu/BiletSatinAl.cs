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
    public partial class BiletSatinAl : Form
    {
        int tamBilet = 0;
        int ogrenciBilet = 0;
        int secilenKoltukSayisi;

        public BiletSatinAl(int koltukSayisi)
        {
            InitializeComponent();
            secilenKoltukSayisi = koltukSayisi;
            Guncelle();
        }

        private void Guncelle()
        {
            lblTam.Text = tamBilet.ToString();
            lblOgrenci.Text = ogrenciBilet.ToString();
            int toplam = tamBilet * 280 + ogrenciBilet * 245;
            lblToplam.Text = toplam + " TL";
            lblKoltuk.Text = secilenKoltukSayisi.ToString();
        }

        private void lblTam_Click(object sender, EventArgs e)
        {

        }

        private void btnTamPlus_Click(object sender, EventArgs e)
        {
            if (tamBilet + ogrenciBilet < secilenKoltukSayisi)
            {
                tamBilet++;
                Guncelle();
            }
        }

        private void btnTamMinus_Click(object sender, EventArgs e)
        {
            if (tamBilet > 0)
            {
                tamBilet--;
                Guncelle();
            }
        }

        private void btnOgrenciPlus_Click(object sender, EventArgs e)
        {
            if (tamBilet + ogrenciBilet < secilenKoltukSayisi)
            {
                ogrenciBilet++;
                Guncelle();
            }
        }

        private void btnOgrenciMinus_Click(object sender, EventArgs e)
        {
            if (ogrenciBilet > 0)
            {
                ogrenciBilet--;
                Guncelle();
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (tamBilet + ogrenciBilet != secilenKoltukSayisi)
            {
                MessageBox.Show("Lütfen tüm koltuklar için bilet seçiniz!");
                return;
            }
            MessageBox.Show("İşleminiz başarılı!");
        }

        private void BiletSatinAl_Load(object sender, EventArgs e)
        {

        }
    }
}
