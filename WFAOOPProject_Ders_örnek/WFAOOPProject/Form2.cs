using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAOOPProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // II. YOL
        List<Musteri> musteriler;
        public Form2(List<Musteri> musteriler)
        {
            InitializeComponent();
            this.musteriler = musteriler;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.AdSoyad = txtAdSoyad.Text;
            musteri.Telefon = txtTelefon.Text;
            musteri.Adres = txtAdres.Text;
            musteri.Yas = (int)nudYas.Value;

            //I. YOL
            //Form1.musteriler.Add(musteri);

            //II. YOL
            musteriler.Add(musteri);

            MessageBox.Show("Musteri başarıyla eklendi");
            Helper.Temizle(this.Controls);

        }

        private void btnListeyeDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
