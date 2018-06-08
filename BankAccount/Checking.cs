using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {
        public Checking()
        {

        }


        public override void ViewAccount() // abstract method from abstract class
        {
            Console.WriteLine("Acccount Balance: {0}",this.AcctBal);
            Console.WriteLine("Account Type: {0}",this.AcctType);
            Console.WriteLine("Interest Rate:");
        }

    }
}
