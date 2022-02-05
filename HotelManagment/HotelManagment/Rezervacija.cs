using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment
{
    public class Rezervacija
    {
        public Gost gost { get; set; }
        public Soba soba { get; set; }
        public String ukupnaCena { get; set; }
        public DateTime datumOd { get; set; }
        public DateTime datumDo { get; set; }
    }
}
