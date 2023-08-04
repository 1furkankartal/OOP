namespace WFAOOPProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calisanlar = new List<Calisan>(); // Genl kullanım
        }
        List<Calisan> calisanlar;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Calisan calisan= new Calisan(); // her seferinde yeni nesne olarak üretilmeli

            try
            {
                calisan.Ad = txtAd.Text;
                calisan.Soyad= txtSoyad.Text;
                calisan.Email= txtEmail.Text;
                calisan.Telefon= txtTelefon.Text;
                calisan.DogumTarihi = dtpDogumTarihi.Value;
                calisan.Cinsiyet = rbKadın.Checked ? "kadın" : "erkek";
                MessageBox.Show("kayıt aşarılı");
                //Helper.Temizle
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            lboxKisiler.Items.Clear();
            foreach ( Calisan calisan in calisanlar)
            {
                lboxKisiler.Items.Add(calisan.Bilgilerigetir()); // Nesne yollama metoda !!!!!!!!!!!!!
            }
        }
    }
}