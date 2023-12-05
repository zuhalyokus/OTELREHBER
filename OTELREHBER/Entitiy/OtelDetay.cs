namespace OTELREHBER.Entitiy
{
    public class OtelDetay
    {
        public string YetkiliAd { get; set; }
        public string YetkiliSoyad { get; set; }
        public string FirmaUnvan { get; set; }
        public List<Oteliletisim> Iletisimlistesi { get; set; }=new List<Oteliletisim>();

    }
}
