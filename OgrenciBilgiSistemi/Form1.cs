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

        //if bloklari ile textboxlarin null veya  bos olmasi engellendi
        private bool AlanlarBosMu()
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Ad alanı boş bırakılamaz.");
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Soyad alanı boş bırakılamaz.");
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtBolum.Text))
            {
                MessageBox.Show("Bölüm alanı boş bırakılamaz.");
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtSinif.Text))
            {
                MessageBox.Show("Sınıf alanı boş bırakılamaz.");
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtNumara.Text))
            {
                MessageBox.Show("Numara alanı boş bırakılamaz.");
                return true;
            }

            return false;
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if (AlanlarBosMu())
            {
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
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğrenciyi seçin.");
                return;
            }
            DataGridViewRow seciliSatir = dgvOgrenciler.SelectedRows[0];
            int numara = (int)(seciliSatir.Cells[4].Value ?? -1);

            Ogrenci silinecekOgrenci = null;
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                if (numara == ogrenci.Numara)
                {
                    silinecekOgrenci = ogrenci;
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

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz öğrenciyi seçin.");
                return;
            }
            DataGridViewRow seciliSatir = dgvOgrenciler.SelectedRows[0];
            int numara = (int)(seciliSatir.Cells[4].Value ?? -1);

            Ogrenci guncellenecekOgrenci = null;

            foreach (Ogrenci ogrenci in ogrenciler)
            {
                if (numara == ogrenci.Numara)
                {
                    guncellenecekOgrenci = ogrenci;
                    break;
                }
            }

            if (guncellenecekOgrenci == null)
            {
                MessageBox.Show("Öğrenci bulunamadı.");
                return;
            }
            if (AlanlarBosMu())
            {
                return;
            }

            bool isSinifTrue = byte.TryParse(txtSinif.Text, out byte guncelSinif);
            bool isNumaraTrue = int.TryParse(txtNumara.Text, out int guncelNumara);

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
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                if (ogrenci != guncellenecekOgrenci && guncelNumara == ogrenci.Numara)
                {
                    MessageBox.Show("Bu numaraya ait başka bir öğrenci zaten kayıtlı.");
                    return;
                }
            }

            guncellenecekOgrenci.Ad = txtAd.Text;
            guncellenecekOgrenci.Soyad = txtSoyad.Text;
            guncellenecekOgrenci.Bolum = txtBolum.Text;
            guncellenecekOgrenci.Sinif = guncelSinif;
            guncellenecekOgrenci.Numara = guncelNumara;
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
        private void btnBilgileriGoruntule_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen görüntülemek istediğiniz öğrenciyi seçin.");
                return;
            }

            DataGridViewRow seciliSatir = dgvOgrenciler.SelectedRows[0];
            int numara = (int)(seciliSatir.Cells[4].Value ?? -1);

            Ogrenci goruntulenecekOgrenci = null;
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                if (numara == ogrenci.Numara)
                {
                    goruntulenecekOgrenci = ogrenci;
                    break;
                }
            }
            if (goruntulenecekOgrenci == null)
            {
                MessageBox.Show("Öğrenci bulunamadı.");
                return;
            }

            txtAd.Text = goruntulenecekOgrenci.Ad;
            txtSoyad.Text = goruntulenecekOgrenci.Soyad;
            txtBolum.Text = goruntulenecekOgrenci.Bolum;
            txtSinif.Text = goruntulenecekOgrenci.Sinif.ToString();
            txtNumara.Text = goruntulenecekOgrenci.Numara.ToString();
        }

        private void btnDersler_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen derslerini görüntülemek istediğiniz öğrenciyi seçin.");
                return;
            }

            DataGridViewRow seciliSatir = dgvOgrenciler.SelectedRows[0];

            int numara = (int)(seciliSatir.Cells[4].Value ?? -1);

            Ogrenci seciliOgrenci = null;

            foreach (Ogrenci ogrenci in ogrenciler)
            {
                if (numara == ogrenci.Numara)
                {
                    seciliOgrenci = ogrenci;
                    break;
                }
            }

            if (seciliOgrenci == null)
            {
                MessageBox.Show("Öğrenci bulunamadı.");
                return;
            }

            Form2 form2 = new Form2(seciliOgrenci);
            form2.Show();
        }
    }
}
