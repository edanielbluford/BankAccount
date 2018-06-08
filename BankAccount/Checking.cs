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
            throw new NotImplementedException();
        }

    }
}
