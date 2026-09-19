using OgrenciBilgiSistemi.Models;
namespace OgrenciBilgiSistemi
{
    public partial class Form2 : Form
    {
        Ogrenci ogrenci;
        public Form2(Ogrenci ogrenci)
        {
            InitializeComponent();
            this.ogrenci = ogrenci;
            lblOgrenciAdi.Text = ogrenci.Ad.ToString();
            lblOgrenciNo.Text = ogrenci.Numara.ToString();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDers.Text))
            {
                MessageBox.Show("Ders adı boş bırakılamaz.");
                return;
            }
            bool isVizeTrue = byte.TryParse(txtVize.Text, out byte vize);
            bool isFinalTrue = byte.TryParse(txtFinal.Text, out byte final);
            bool isAktsTrue = byte.TryParse(txtAkts.Text, out byte akts);
            if (!isVizeTrue || vize > 100)
            {
                MessageBox.Show("Vize notu 0-100 arasında olmalıdır.");
                return;
            }
            if (!isFinalTrue || final > 100)
            {
                MessageBox.Show("Final notu 0-100 arasında olmalıdır.");
                return;
            }
            if (!isAktsTrue)
            {
                MessageBox.Show("Geçerli akts degeri giriniz.");
                return;
            }

            Ders ders = new Ders();
            ders.DersAdi = txtDers.Text;
            ders.Vize = vize;
            ders.Final = final;
            ders.Akts = akts;

            if (ogrenci.Dersler.Any(x => x.DersAdi == ders.DersAdi))
            {
                MessageBox.Show("Aynı isimli bir ders zaten ekli.");
                return;
            }

            ogrenci.Dersler.Add(ders);
            DersleriGoster();

            GanoHesapla();

        }
        private void btnDersSil_Click(object sender, EventArgs e)
        {
            if (dgvDersler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz dersi seçin.");
                return;
            }
            DataGridViewRow seciliSatir = dgvDersler.SelectedRows[0];
            string dersAdi = seciliSatir.Cells[0].Value.ToString();
            Ders silinecekDers = null;

            foreach (Ders d in ogrenci.Dersler)
            {
                if (d.DersAdi == dersAdi)
                {
                    silinecekDers = d;
                    break;
                }
            }
            if (silinecekDers != null)
            {
                ogrenci.Dersler.Remove(silinecekDers);
            }
            DersleriGoster();
            GanoHesapla();
        }
        private double DortlukNotHesapla(double ortalama)
        {
            if (ortalama >= 88)
                return 4.0;
            else if (ortalama >= 80)
                return 3.5;
            else if (ortalama >= 73)
                return 3.0;
            else if (ortalama >= 66)
                return 2.5;
            else if (ortalama >= 60)
                return 2.0;
            else if (ortalama >= 50)
                return 1.5;
            else
                return 0.0;
        }
        private void GanoHesapla()
        {
            double toplamAgirlikliNot = 0;
            int toplamAkts = 0;

            foreach (Ders d in ogrenci.Dersler)
            {
                double dersOrtalama = d.Vize * 0.4 + d.Final * 0.6;

                toplamAgirlikliNot += DortlukNotHesapla(dersOrtalama) * d.Akts;
                toplamAkts += d.Akts;
            }

            double gano = 0;

            if (toplamAkts > 0)
            {
                gano = toplamAgirlikliNot / toplamAkts;
            }

            lblGenelOrtalama.Text = gano.ToString("F2");
        }
        private void DersleriGoster()
        {
            dgvDersler.Rows.Clear();

            foreach (Ders d in ogrenci.Dersler)
            {
                double ortalama = d.Vize * 0.4 + d.Final * 0.6;

                dgvDersler.Rows.Add(
                    d.DersAdi,
                    d.Vize,
                    d.Final,
                    d.Akts,
                    ortalama
                );
            }
        }
    }
}
