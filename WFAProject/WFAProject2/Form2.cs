using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProject2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string _name, int _not1, int _not2, int _not3)
        {
            this.name = _name;
            this.not1 = _not1;
            this.not2 = _not2;
            this.not3 = _not3;
            InitializeComponent();
        }
        string name;
        int not1, not2, not3;

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text= name;
            int ortalama = ((not1 + not2 + not3) / 3);
            label5.Text = ortalama.ToString();

            if (ortalama > 50) { label6.Text = "geçti"; }
            else { label6.Text = "kaldı"; }
        }
    }
}
