using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
    public class Crime_Basic_InformationObject
    {
        public string CreminalRef { get; set; }
        public string CriminalStatus { get; set; }
        public string GangName { get; set; }
        public string CrimeType { get; set; }
        public string IllegalArmsPossession { get; set; }
        public string Remarks { get; set; }
        public string LegalArmsPossession { get; set; }
        public string PriorityListGovt { get; set; }
        public string CaseDetails { get; set; }
        public string LastState { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
