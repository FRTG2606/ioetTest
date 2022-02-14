using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSchedules
{
    public class PaySchedules
    {
        public string day { get; set; }
        public string dayAbbr { get; set; }
        public DateTime HourIni { get; set; }
        public DateTime HourEnd { get; set; }
        public decimal pay { get; set; }
        //public object Identity { get => identity; set => identity = value; }
        
    }
}
