using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        public string Name { get; set; }
        public int AcctNumber { get; set; }
        public string AcctStartDate { get; set; }
        public string PhoneNumber { get; set; }

        public Client()
        {
            //default constuctor
        }

        public Client(string name, int acctNumber,string acctStartDate, string phoneNumber)
        {
            this.Name = name;
            this.AcctNumber = acctNumber;
            this.AcctStartDate = acctStartDate;
            this.PhoneNumber = phoneNumber;
        }

    }
}
