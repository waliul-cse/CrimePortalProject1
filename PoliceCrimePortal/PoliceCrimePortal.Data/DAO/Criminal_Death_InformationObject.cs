using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
    public class Criminal_Death_InformationObject
    {
        public Criminal_Death_InformationObject()
        {
            Address = new AddressObject();
        }

        public string RefNo { get; set; }
        public string DeathTime { get; set; }
        public string DeathDate { get; set; }
        public string Reason { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public AddressObject Address { get; set; }
    }
}
