using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OTELREHBER.Entitiy;
using OTELREHBER.Services.Abstract;

namespace OTELREHBER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtelController : Controller
    {
        private readonly IOtelService _otelService;
        public OtelController(IOtelService otelService)
        {
            _otelService = otelService;
        }
        [HttpPost]
        public async Task< IActionResult> CreateOtel(string YetkiliAd, string Yetkilisoyad, string firmaunvan)
        {
            Otel Yeniotel = new Otel();
            Yeniotel.YetkiliSoyad = Yetkilisoyad;
            Yeniotel.YetkiliAd = YetkiliAd;
            Yeniotel.FirmaUnvan = firmaunvan;
            var result = await _otelService.OtelOlusturma(Yeniotel);
            return Ok(result);
        }
        [HttpDelete("DeleteOtel")]
        public IActionResult DeleteGetOtel(long id)
        {
            var result = _otelService.OtelSilme(id);
            return Ok(result);
        }

        [HttpGet("OtelYetkilileri")]
        public async Task<IActionResult> OtelYetkilileri()
        {
            var result = await _otelService.OtelYetkilileri();
            return Ok(result);
        }
        [HttpGet("OtelDetay")]
        public async Task<IActionResult> OtelDetay(long id)
        {
            var result = await _otelService.OtelDetay( id);
            return Ok(result);
        }
    }
}
