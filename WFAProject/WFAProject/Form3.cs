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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text.ToString();
            listBox1.Items.Add(deger);
            comboBox1.Items.Add(deger);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            comboBox1.ResetText();
        }
    }
}
