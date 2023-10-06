using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer._1ConcreteSomutDegerlerClass
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; } //Sonuna ID gelince [key] eklemesine gerek kalmaz
        public string CustomerAccountNumber { get; set; }
        public string Currency { get; set; }
        public decimal CustomerAccountBalance { get; set; }
        public string BankBranch { get; set; }
        


    }
}
