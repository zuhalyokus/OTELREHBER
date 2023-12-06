using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTELREHBERISTEK.Entity
{
    public class Otel
    {
        public long UUID { get; set; }
        public string YetkiliAd { get; set; }
        public string YetkiliSoyad { get; set; }
        public string FirmaUnvan { get; set; }
    }
}
