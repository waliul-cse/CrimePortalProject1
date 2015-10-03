using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
   public class Criminal_Basic_InformationObject
    {
       public string refNo { get; set; }
       public string fullName { get; set; }
       public string nickName { get; set; }
       public string criminalName { get; set; }
       public string gender { get; set; }
       public string religion { get; set; }
       public string bloodGroup { get; set; }
       public DateTime dob { get; set; }
       public string regionofBirth { get; set; }
       public string usualDressUp { get; set; }
       public string maritalStatus { get; set; }
       public string dialectAccent { get; set; }
       public string drivingLicenseNo { get; set; }
       public string nationalID { get; set; }
       public string passport { get; set; }
       public string createby { get; set; }
       public string updateby { get; set; }
       public DateTime createdate { get; set; }
       public DateTime updateDate { get; set; }

    }
}
