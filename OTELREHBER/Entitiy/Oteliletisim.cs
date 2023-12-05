using System.ComponentModel.DataAnnotations;

namespace OTELREHBER.Entitiy
{
    public class Oteliletisim
    {
        [Key]
        public long Id { get; set; }
 
        public string Telefon_Numarası {  get; set; }
        public string Email { get; set; }
        public string Location {  get; set; }
        public long OtelID { get; set; }
      


    }
}
