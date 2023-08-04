using System.Xml.Serialization;

namespace WFAOOPProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            musteriler = new List<Musteri>();
        }
        // I. YOL
        //public static List<Musteri> musteriler;

        // II. YOL
        List<Musteri> musteriler;
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            //I. YOL
            //Form2 form2 = new Form2();
            //form2.ShowDialog();
            //ListBoxuDoldur();

            // II. YOL
            Form2 form2= new Form2(musteriler);
            form2.ShowDialog();
            Helper.Temizle(this.Controls);
            ListBoxuDoldur();
        }
        private void ListBoxuDoldur()
        {
            lboxMusteriler.Items.Clear();
            foreach(Musteri musteri in musteriler)
            {
                lboxMusteriler.Items.Add(musteri);
            }
        }
    }
}