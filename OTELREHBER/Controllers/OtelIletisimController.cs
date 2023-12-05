using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OTELREHBER.Entitiy;
using OTELREHBER.Services.Abstract;

namespace OTELREHBER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtelIletisimController : ControllerBase
    {
        private readonly IOtelService _otelService;
        public OtelIletisimController(IOtelService otelService)
        {
            _otelService = otelService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateOteliletisim(long otelid, string Telefon, string Email, string Adres)
        {
            Oteliletisim Yeniiletisim = new Oteliletisim();
            Yeniiletisim.OtelID = otelid;
            Yeniiletisim.Telefon_Numarası = Telefon;
            Yeniiletisim.Email = Email;
            Yeniiletisim.Location = Adres;
            var result = await _otelService.OtelIletisimEkle(Yeniiletisim);
            return Ok(result);
        }
        [HttpDelete("DeleteOtelIletisim")]
        public IActionResult DeleteGetOteliletisim(long id)
        {
            var result = _otelService.OtelSilme(id);
            return Ok(result);
        }
    }
}
