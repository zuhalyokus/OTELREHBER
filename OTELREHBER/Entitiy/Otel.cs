using System.ComponentModel.DataAnnotations;

namespace OTELREHBER.Entitiy
{
    public class Otel
    {
        [Key]
        public long UUID {  get; set; }
        public string YetkiliAd {  get; set; }
        public string YetkiliSoyad { get; set; }
        public string FirmaUnvan {  get; set; }
    }
}
