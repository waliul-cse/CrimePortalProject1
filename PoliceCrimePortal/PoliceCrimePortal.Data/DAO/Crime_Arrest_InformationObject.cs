using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
    public class Crime_Arrest_InformationObject
    {
        public string RefNo { get; set; }
        public string District { get; set; }
        public string Upozila { get; set; }
        public DateTime DateofArrest { get; set; }
        public string ArrestBy { get; set; }
        public string Disposal { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
