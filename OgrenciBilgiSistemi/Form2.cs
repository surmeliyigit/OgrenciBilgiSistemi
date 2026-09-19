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
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDers.Text))
            {
                MessageBox.Show("Ders adı boş bırakılamaz.");
                return;
            }
            bool isVizeTrue = byte.TryParse(txtVize.Text,out byte vize);
            bool isFinalTrue = byte.TryParse(txtFinal.Text,out byte final);
            bool isAktsTrue = byte.TryParse(txtAkts.Text,out byte akts);
            if (!isVizeTrue || vize>100)
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
            ders.Vize= vize;
            ders.Final= final;
            ders.Akts = akts;
            
            if (ogrenci.Dersler.Any(x => x.DersAdi == ders.DersAdi))
            {
                MessageBox.Show("Aynı isimli bir ders zaten ekli.");
                return;
            }

            ogrenci.Dersler.Add(ders);
            dgvDersler.Rows.Clear();

            double dersOrtalama = 0;
            double toplamAgirlikliNot = 0;
            int toplamAkts = 0;

            foreach (Ders dersGez in ogrenci.Dersler)
            {
                dersOrtalama = dersGez.Vize * 0.4 + dersGez.Final * 0.6;
                toplamAgirlikliNot += DortlukNotHesapla(dersOrtalama)*dersGez.Akts;
                toplamAkts += dersGez.Akts;
                dgvDersler.Rows.Add(
                    dersGez.DersAdi,
                    dersGez.Vize,
                    dersGez.Final,
                    dersGez.Akts,
                    dersOrtalama
                );
            }

            double gano = toplamAgirlikliNot/toplamAkts;
            lblOgrenciAdi.Text = ogrenci.Ad.ToString();
            lblOgrenciNo.Text = ogrenci.Numara.ToString();
            lblGenelOrtalama.Text = gano.ToString("F2");
        }
        private double DortlukNotHesapla(double ortalama)
        {
            double dortlukNot;

            if (ortalama >= 88)
                return dortlukNot = 4.0;
            else if (ortalama >= 80 && ortalama<=87)
                return dortlukNot = 3.5;
            else if (ortalama >= 73 && ortalama<=79)
                return dortlukNot = 3.0;
            else if (ortalama >= 66 && ortalama<=72)
                return dortlukNot = 2.5;
            else if (ortalama >= 60 && ortalama<=65)
                return dortlukNot = 2.0;
            else if (ortalama >= 50 && ortalama<=59)
                return dortlukNot = 1.5;
            else
                return dortlukNot = 0.0;
        }
    }
}
