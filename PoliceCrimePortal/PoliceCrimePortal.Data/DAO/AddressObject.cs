using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
    public class AddressObject
    {
        public string ID { get; set; }
        public string District { get; set; }
        public string Upozila { get; set; }
        public string UnionWard { get; set; }
        public string Village { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }

    }
}
