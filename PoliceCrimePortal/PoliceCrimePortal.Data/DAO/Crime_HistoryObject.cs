using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
    public class Crime_HistoryObject
    {
        public string RefNo { get; set; }
        public string CrimeType { get; set; }
        public string Description { get; set; }
        public string CrimeCode { get; set; }
        public DateTime CrimeDate { get; set; }
        public string Crimetime { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
