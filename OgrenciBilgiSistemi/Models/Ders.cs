namespace OgrenciBilgiSistemi.Models
{
    public class Ders
    {
        string dersAdi;
        byte vize;
        byte final;
        byte akts;
        public string DersAdi
        {
            get
            {
                return dersAdi;
            }
            set
            {
                dersAdi= value;
            }
        }
        public byte Vize
        {
            get { return vize; }
            set { vize = value; }
        }

        public byte Final
        {
            get { return final; }
            set { final = value; }
        }
        public byte Akts
        {
            get => akts;
            set { akts = value; }
        }
    }
}
