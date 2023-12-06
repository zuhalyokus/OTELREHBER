using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTELREHBERISTEK.Entity
{
    public class Oteliletisim
    {
        public long Id { get; set; }

        public string Telefon_Numarası { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public long OtelID { get; set; }
    }
}
