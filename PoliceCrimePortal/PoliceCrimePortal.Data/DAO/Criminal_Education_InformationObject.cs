using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
    public class Criminal_Education_InformationObject
    {
        public string RefNo { get; set; }
        public string EducationalStatus { get; set; }
        public string NameofInstitution { get; set; }
        public string PoliticalInvolvementinInstitution { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }
    }
}
