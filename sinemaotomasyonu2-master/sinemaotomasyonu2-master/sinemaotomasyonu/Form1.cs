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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            if (kullaniciAdi == "Gisegorevlisi" && sifre == "MersinUni33.")
            {
                MessageBox.Show("Giriş başarılı!");
                //bundan sonra film secimi icin ikinci form acilacak
       
                Form2 gecis = new Form2();
                gecis.Show();
                // Şu anki giriş ekranını (Form1) arka plana gizliyoruz
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış. Lütfen tekrar deneyin.");
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
                txtKullaniciAdi.Focus();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
  

}
