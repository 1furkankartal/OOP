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
    public partial class Form5 : Form
    {
        List<Bilgi> names = new List<Bilgi>();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bilgi bilgi = new Bilgi();
            bilgi.Name = textBox1.Text;
            bilgi.Surname = textBox2.Text;
            if (radioButton1.Checked)
            {

                bilgi.Gecti = true;
            }
            else
            {
                bilgi.Gecti = false;

            }

            names.Add(bilgi);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in names)
            {
                if (item.Gecti == true) { listBox1.Items.Add(item.Name); }
                else if (item.Gecti == false) { listBox2.Items.Add(item.Name); }

            }

        }

        //private void Temizle()
        //{
        //    foreach (Control control in this.Controls)
        //    {
        //        if(control.GetType()=typeof(TextBox))
        //        {
        //            TextBox txt = (TextBox)control;
        //            txt.Clear();
        //        }
        //        //else if(control is RadioButton)
        //        //{
        //        //    RadioButton radioButton = (RadioButton)control;
        //        //    if (radioButton.Text == "Geçti")
        //        //    {
        //        //        radioButton.Checked = true;
        //        //    }
        //        //    else
        //        //    {
        //        //        radioButton.Checked = false;
        //        //    }
        //        //}
        //    }
        //}


    }

    public class Bilgi
    {
        private string _name;
        private string _surname;
        private bool _gecti;

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public bool Gecti { get => _gecti; set => _gecti = value; }


    }
}
