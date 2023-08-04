namespace WFAProject3_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kisiler = new List<Kisiler>();
        }
        List<Kisiler> kisiler;
        private void btn_YeniMusteri_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2(kisiler);
            form2.ShowDialog();
            ListBoxDoldur();
        }
        private void ListBoxDoldur()
        {
            listBox1.Items.Clear();
            foreach (Kisiler musteri in kisiler)
            {
                listBox1.Items.Add(musteri);
            }
        }
    }
}