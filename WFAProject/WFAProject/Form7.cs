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
    public partial class Form7 : Form
    {
        List<Kisi> list = new List<Kisi>();
        List<string> hobbylist = new List<string>();
        public Form7()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Kisi newperson = new Kisi();
            newperson.Name = textBox1.Text;
            newperson.Surname = textBox2.Text;
            newperson.Datebirth = textBox3.Text;
            newperson.Email = textBox4.Text;
            newperson.TelephoneNumber = textBox5.Text;
            newperson.Year = int.Parse(textBox6.Text);
            newperson.Gender = (radioButton7.Checked) ? true : false;

            string result1 = null;
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        result1 = radio.Text;
                        newperson.Education = result1;
                    }
                }
            }
            string result2 = null;
            foreach (Control control_1 in this.groupBox2.Controls)
            {
                if (control_1 is CheckBox)
                {
                    RadioButton radio = control_1 as RadioButton;
                    CheckBox check = control_1 as CheckBox;
                    if (check.Checked)
                    {
                        result2 = check.Text;
                        hobbylist.Add(result2);
                        newperson.Hobby = hobbylist;

                    }
                }
            }


            list.Add(newperson);

            foreach (var item in list)
            {

                listBox1.Items.Add(item.Name + " " + item.Surname + " " + item.Education);
                foreach (var item_1 in hobbylist)
                {
                    listBox1.Items.Add(item_1);
                }
            }

        }
    }

    public class Kisi
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Datebirth { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public int Year { get; set; }
        public bool Gender { get; set; }
        public string Education { get; set; }
        public List<string> Hobby { get; set; }

    }
}
