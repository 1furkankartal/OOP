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
    public partial class Form4 : Form
    {
        List<string> names = new List<string>();
        List<int> kaldi = new List<int>();


        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            names.Add(textBox1.Text + " " + textBox2.Text);
            if (radioButton1.Checked) { kaldi.Add(1); }
            else if (radioButton2.Checked) { kaldi.Add(0); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int j = 0; j < kaldi.Count; j++)
            {
                if (kaldi[j] == 0)
                {
                    listBox1.Items.Add(names[j]);
                }
                else if (kaldi[j] == 1)
                {
                    listBox2.Items.Add(names[j]);
                }
            }

        }
    }
}
