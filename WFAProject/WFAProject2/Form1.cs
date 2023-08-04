namespace WFAProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int not1 = int.Parse(textBox2.Text);
            int not2 = int.Parse(textBox3.Text);
            int not3 = int.Parse(textBox4.Text);

            Form2 form2= new Form2(name,not1,not2,not3);
            form2.ShowDialog();

        }
    }
}