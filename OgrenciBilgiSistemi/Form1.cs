using OgrenciBilgiSistemi.Models;
namespace OgrenciBilgiSistemi
{
    public partial class Form1 : Form
    {
        List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            //if bloklari ile textboxlarin null veya  bos olmasi engellendi
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Ad alanı boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Soyad alanı boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBolum.Text))
            {
                MessageBox.Show("Bölüm alanı boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSinif.Text))
            {
                MessageBox.Show("Sınıf alanı boş bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNumara.Text))
            {
                MessageBox.Show("Numara alanı boş bırakılamaz.");
                return;
            }

            //Ogrencilerin bilgileri textboxlardan alinmasi saglandi ve kontrol edildi
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txtAd.Text;
            ogrenci.Soyad = txtSoyad.Text;
            ogrenci.Bolum = txtBolum.Text;
            bool isSinifTrue = byte.TryParse(txtSinif.Text, out byte sinif);
            bool isNumaraTrue = int.TryParse(txtNumara.Text, out int numara);

            if (!isSinifTrue)
            {
                MessageBox.Show("Sınıf bilgisi sayı olmalıdır.");
                return;
            }
            if (!isNumaraTrue)
            {
                MessageBox.Show("Numara bilgisi sayı olmalıdır.");
                return;
            }
            ogrenci.Sinif = sinif;
            ogrenci.Numara = numara;
            if (ogrenciler.Any(x => x.Numara == ogrenci.Numara))
            {
                MessageBox.Show("Bu numaraya ait bir öğrenci zaten kayıtlı.");
                return;
            }

            ogrenciler.Add(ogrenci);
            dgvOgrenciler.Rows.Clear();

            foreach (Ogrenci ogr in ogrenciler)
            {
                dgvOgrenciler.Rows.Add(
                ogr.Ad,
                ogr.Soyad,
                ogr.Bolum,
                ogr.Sinif,
                ogr.Numara
               );
            }
            txtAd.Clear();
            txtSoyad.Clear();
            txtBolum.Clear();
            txtSinif.Clear();
            txtNumara.Clear();

        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.SelectedRows.Count==0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğrenciyi seçin.");
                return;
            }
            DataGridViewRow seciliSatir=dgvOgrenciler.SelectedRows[0];
            int numara=(int)seciliSatir.Cells[4].Value;

            Ogrenci silinecekOgrenci=null;
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                if (numara==ogrenci.Numara)
                {
                    silinecekOgrenci=ogrenci;
                    break;
                }
            }
            
            if (silinecekOgrenci != null)
            {
                ogrenciler.Remove(silinecekOgrenci);
            }
            
            dgvOgrenciler.Rows.Clear();

            foreach (Ogrenci ogr in ogrenciler)
            {
                dgvOgrenciler.Rows.Add(
                ogr.Ad,
                ogr.Soyad,
                ogr.Bolum,
                ogr.Sinif,
                ogr.Numara
               );
            }
        }
    }
}
