using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProject3_OOP
{
    public partial class Form2 : Form
    {
        List<Kisiler> kisi;
        public Form2(List<Kisiler>kisi)
        {
            this.kisi = kisi;
            InitializeComponent();
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Kisiler kisiler=new Kisiler();
            kisiler._isim = tb_adsoyad.Text;
            kisiler._telefon = mtb_telefon.Text;
            kisiler._yas = (int)nud_yas.Value;
            kisiler._adres = tb_adres.Text;
            kisi.Add(kisiler);
            MessageBox.Show("Kişi eklendi.");
            Helper.Temizle(this.Controls);
        }

        private void btn_ListeyeDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
