using System.ComponentModel;
using System.Globalization;
using System.Text.Json;

namespace PersonelApp
{
    public partial class Form1 : Form
    {


        BindingList<Personel> liste = new();//personeller i�in liste tan�mlad�k
        Personel gosterilenPersonel;//ilerisi i�in ekranda g�r�nen personeli sakla
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("bilgiler.txt"))
            {
                string metin = File.ReadAllText("bilgiler.txt");
                var okunanListe = JsonSerializer.Deserialize<List<Personel>>(metin);
                liste = new(okunanListe);
            }
            //listBox ile ba�lant� yap
            lbPersonel.DataSource = liste;
            lbPersonel.DisplayMember = "FullName";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (gosterilenPersonel == null)
                YeniEkle();
            else
                Guncelle();

        }
        void YeniEkle()
        {
            Personel yeniPers = new();//Personel s�n�f�ndan yeni bir nesne olu�turduk
            //Verileri form �zerinden kontrollerden ald�k
            yeniPers.Ad = txtAd.Text;
            yeniPers.Soyad = txtSoyad.Text;
            yeniPers.Yas = Convert.ToInt32(txtYas.Text);
            yeniPers.Tel = txtTelNo.Text;
            yeniPers.Adres = txtAdres.Text;

            //listeye ekleme i�lemi
            liste.Add(yeniPers);
            //alanlar� temizle
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelNo.Clear();
            txtAdres.Clear();
            txtYas.Clear();
            //ilk kontrole txtad odaklan 
            txtAd.Focus();
        }

        

        private void lbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bana listedeki se�ili olan eleman� Personel olarakver 
            Personel pers = lbPersonel.SelectedItem as Personel;
            if (pers != null)
            {
                //Personeli g�ster
                txtAd.Text = pers.Ad;
                txtSoyad.Text = pers.Soyad;
                txtYas.Text = pers.Yas.ToString();
                txtTelNo.Text = pers.Tel;
                txtAdres.Text = pers.Adres;

                gosterilenPersonel = pers;
                pbYeni.Visible = true;
            }
            else
            {
                gosterilenPersonel = null;
                pbYeni.Visible = true;//buyeni personel

            }
        }
        void Guncelle()
        {
            gosterilenPersonel.Ad = txtAd.Text;
            gosterilenPersonel.Soyad = txtSoyad.Text;
            gosterilenPersonel.Yas = Convert.ToInt32(txtYas.Text);
            gosterilenPersonel.Tel = txtTelNo.Text;
            gosterilenPersonel.Adres = txtAdres.Text;

            //listeyi yenile
            liste.ResetBindings();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            //se�ili personeli kald�r yani yeni personeli ekle 
            lbPersonel.SelectedIndex = -1;
            //alanlar� temizle
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
            txtTelNo.Clear();
            txtAdres.Clear();
            //ilk kontrole txtAd odaklan
            txtAd.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string metin = JsonSerializer.Serialize(liste);

            File.WriteAllText("bilgiler.txt",metin);

            MessageBox.Show("Bilgiler kay�t edildi!");
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gosterilenPersonel != null)
            {
                liste.Remove(gosterilenPersonel);
                liste.ResetBindings();

                txtAd.Clear();
                txtSoyad.Clear();
                txtYas.Clear();
                txtTelNo.Clear();
                txtAdres.Clear();

                gosterilenPersonel = null;
                MessageBox.Show("Personel silindi!");
            }
            else
            {
                MessageBox.Show("L�tfen silinecek personeli se�in!"); //
            }
        }
    }
}
