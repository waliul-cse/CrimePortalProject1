using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
    public class Crime_Case_DetailsObject
    {
        public string RefNo { get; set; }
        public string CaseNo { get; set; }
        public string District { get; set; }
        public string Thana { get; set; }
        public DateTime Date { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
