using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
    public class Crime_ZoneObject
    {
        public string RefNo { get; set; }
        public string Battalion { get; set; }
        public string District { get; set; }
        public string PoliceStation { get; set; }
        public string Village { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Remarks { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
