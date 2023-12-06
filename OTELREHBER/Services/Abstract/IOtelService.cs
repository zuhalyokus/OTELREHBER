using OTELREHBER.Entitiy;

namespace OTELREHBER.Services.Abstract
{
    public interface IOtelService
    {
        public Task<Otel> OtelOlusturma(Otel otel);
        public  bool OtelSilme(long Otelid);
        public Task<Oteliletisim> OtelIletisimEkle(Oteliletisim otel);
        public bool OtelIletisimSil(long Iletsimid);
        public Task<List<YetkiliBilgisi>> OtelYetkilileri();
        public Task<OtelDetay> OtelDetay(long id);
        public Task<List<Otel>> OtelListesi();
        public Task<List<Oteliletisim>> OteliletisimListesi(long id);
    }
}
