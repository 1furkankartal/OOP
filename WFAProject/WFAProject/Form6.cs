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
    public partial class Form6 : Form
    {
        int i = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

            Random rnd1 = new Random();
            int sayi1 = rnd1.Next(0, 700);
            int sayi2 = rnd1.Next(0, 380);

            button1.Location = new Point(sayi1, sayi2);
            i++;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bravoo yakaladınn.." + i + " adımda");
        }
    }
}
