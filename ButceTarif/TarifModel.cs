using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButceTarif
{
    public class TarifModel
    {
        public int TarifId { get; set; }
        public byte[] TarifResim { get; set; }
        public string TarifAdi { get; set; }
        public string TarifTuru { get; set; }
        public string TarifKisilik { get; set; }
        public string TarifZaman { get; set; }
        public string TarifMalzeme { get; set; }
        public string TarifIcerik { get; set; }
        public decimal TarifFiyat { get; set; }

    }
}
