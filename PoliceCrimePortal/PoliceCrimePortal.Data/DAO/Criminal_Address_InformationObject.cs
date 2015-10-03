using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
    /// <summary>
    /// 
    /// </summary>
   public class Criminal_Address_InformationObject
    {
       public Criminal_Address_InformationObject()
        {
            PermanentAddress = new AddressObject();
            PresentAddress = new AddressObject();
        }
        public string RefNo { get; set; }
        public AddressObject PermanentAddress { get; set; }
        public AddressObject PresentAddress { get; set; }
        public string LastAddressRegion { get; set; }
        public string DurationofStay { get; set; }
        public string Remarks { get; set; }
        public string WorkingArea { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string email { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }


    }
}
