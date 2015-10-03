using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
    public class Crime_Remand_InformationObject
    {
        public string RefNo { get; set; }
        public string RemandNo { get; set; }
        public DateTime DateofRemand { get; set; }
        public string Duration { get; set; }
        public string ReasonofRemand { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
