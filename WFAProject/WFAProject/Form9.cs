using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProject
{
    public partial class Form9 : Form
    {
        List<Musteri> customer = new List<Musteri>();
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri _musteri = new Musteri();
            _musteri.Name = textBox1.Text;
            _musteri.PhoneNumber = textBox2.Text;
            _musteri.Year = int.Parse(textBox3.Text);
            _musteri.Adress = textBox4.Text;

            customer.Add(_musteri);

        }
    }

    public class Musteri
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int Year { get; set; }
        public string Adress { get; set; }
    }
}
