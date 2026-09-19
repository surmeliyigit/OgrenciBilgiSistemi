namespace OgrenciBilgiSistemi.Models
{
    public class Ogrenci
    {
        string ad;
        string soyad;
        string bolum;
        byte sinif;
        int numara;
        List<Ders> dersler=new List<Ders>();
        public List<Ders> Dersler
        {
            get {  return dersler; }
            set { dersler = value; }
        }
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Bolum
        {
            get { return bolum; }
            set { bolum = value; }
        }
        public byte Sinif
        {
            get { return sinif; }
            set { sinif = value; }
        }
        public int Numara
        {
            get { return numara; }
            set { numara = value; }
        }
    }
}
