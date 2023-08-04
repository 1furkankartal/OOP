namespace WFA_Uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void MusteriEkle(Musteri _musteri)
            
        {
            listBox1.Items.Add(_musteri.Name + " " + _musteri.Adress + " " + _musteri.Year);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 _form2 = new Form2();
            _form2.ShowDialog();
        }

        private void ListBoxDoldur()
        {
            foreach(Musteri musteri0 listBox1.Items) 
            { }
        }
    }
}