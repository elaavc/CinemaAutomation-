using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemaotomasyonu
{
    public partial class Form2 : Form 
    {
        public Form2() 
        {
            InitializeComponent();
            
            
            radioButton2.CheckedChanged += FilmSecim_CheckedChanged;
            radioButton3.CheckedChanged += FilmSecim_CheckedChanged;
            radioButton4.CheckedChanged += FilmSecim_CheckedChanged; 
            radioButton5.CheckedChanged += FilmSecim_CheckedChanged; 
            radioButton6.CheckedChanged += FilmSecim_CheckedChanged; 
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        
       
          private void FilmSecim_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton tiklananButon = sender as RadioButton;


            if (tiklananButon == null) return; 

            if (tiklananButon.Checked)
            {
                DateTime suAn = DateTime.Now;
                DateTime filmSaati;


                string butonYazisi = tiklananButon.Text.ToLower();


                if (butonYazisi.Contains("kurtuluş"))
                {
                    filmSaati = new DateTime(suAn.Year, suAn.Month, suAn.Day, 20, 30, 0);
                }
                else if (butonYazisi.Contains("marka"))
                {
                    filmSaati = new DateTime(suAn.Year, suAn.Month, suAn.Day, 20, 30, 0);
                }
                else if (butonYazisi.Contains("tamamı"))
                {
                    filmSaati = new DateTime(suAn.Year, suAn.Month, suAn.Day, 20, 30, 0);
                }
                else
                {
                    filmSaati = new DateTime(suAn.Year, suAn.Month, suAn.Day, 6, 0, 0);
                }


                if (suAn > filmSaati)
                {
                    MessageBox.Show($"{tiklananButon.Text} Filminin seans zamanı geçmiştir! Lütfen başka bir film seçiniz.", "Zamanı geçti.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tiklananButon.Checked = false;
                }
                else
                {

                    if (butonYazisi.Contains("kurtuluş"))
                    {

                        SalonA salonA_Ekrani = new SalonA();
                        salonA_Ekrani.Show();
                        this.Hide();
                    }
                    else if (butonYazisi.Contains("tamamı"))
                    {

                        SalonB salonB_Ekrani = new SalonB();
                        salonB_Ekrani.Show();
                        this.Hide();
                    }
                    else if (butonYazisi.Contains("marka"))
                    {

                        SalonC salonC_Ekrani = new SalonC();
                        salonC_Ekrani.Show();
                        this.Hide();
                    }
                }


            }
          }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e )
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    
}

    

    
