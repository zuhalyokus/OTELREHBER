using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OTELREHBER.DataBaseContext;
using OTELREHBER.Entitiy;
using OTELREHBER.Services.Abstract;
namespace OTELREHBER.Services.Concrete
{
    public class OtelService : IOtelService
    {
        private readonly ApplicationDbContext _context;
        public OtelService(ApplicationDbContext contex)
        {
            _context = contex;
          
        }
        public async Task<Otel> OtelOlusturma(Otel Yeniotel)
        {
            
                    await _context.Otels.AddAsync(Yeniotel);
                    await _context.SaveChangesAsync();
                    _context.Dispose();
                    return Yeniotel; 
        }
        public bool OtelSilme(long Otelid)
        {
         
            var otelIletisimler = _context.Oteliletisims.Where(iletisim => iletisim.OtelID == Otelid).ToList();
            if (otelIletisimler.Any())
            {
                _context.Oteliletisims.RemoveRange(otelIletisimler);
            }
            var otel = _context.Otels.Find(Otelid);

            if (otel != null)
            {
                _context.Otels.Remove(otel);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<Oteliletisim> OtelIletisimEkle(Oteliletisim oteliletisim)
        {
            await _context.Oteliletisims.AddAsync(oteliletisim);
            await _context.SaveChangesAsync();
            return oteliletisim;
        }
        public bool OtelIletisimSil(long Iletsimid)
        {
            var result = _context.Oteliletisims.Find(Iletsimid);

            if (result != null)
            {
                _context.Oteliletisims.Remove(result);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<YetkiliBilgisi>> OtelYetkilileri()
        {
            // Yetkili adları ve soyadları çek
            var yetkiliBilgileri = await _context.Otels
                .Select(otel => new YetkiliBilgisi { YetkiliAd = otel.YetkiliAd, YetkiliSoyad = otel.YetkiliSoyad })
                .ToListAsync();

            return yetkiliBilgileri;
        }
        public async Task<OtelDetay> OtelDetay(long id)
        {
            OtelDetay detay = new OtelDetay();

            var otelIletisimler = await _context.Oteliletisims
                .Where(iletisim => iletisim.OtelID == id)
                .ToListAsync();

            if (otelIletisimler.Any())
            {
            
                detay.Iletisimlistesi.AddRange(otelIletisimler);
            }

      
            var otel = await _context.Otels.FindAsync(id);

            if (otel != null)
            {
               
                detay.YetkiliSoyad = otel.YetkiliSoyad;
                detay.YetkiliAd = otel.YetkiliAd;
                detay.FirmaUnvan = otel.FirmaUnvan;
            }

            return detay;
        }
    }
}
