using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
    public class Criminal_Bank_Account_DetailsObject
    {
        public string RefNo { get; set; }
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public string AccountType { get; set; }
        public string CreditCardNo { get; set; }
        public string DebitCardNo { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
