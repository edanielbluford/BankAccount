using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account
    {
        public string Name { get; set; }
        public string AcctType { get; set; }
        public double AcctBal { get; set; }
        public double MinBal { get; set; }


        public Account()
        {
            //default constructor
        }

        public Account(string name, string acctType, double acctBal)
        {
            this.Name = name;
            this.AcctType = acctType;
            this.AcctBal = acctBal;
        }

        //double Withdraw()
        //{
        //    return;
        //}

        public virtual void AddIntrest() //this is like the Tick() method in our last project
        {
            int intrestTick = 0;
            double interestRate = this.AcctBal / 100;
            intrestTick = intrestTick + 1;
            if(intrestTick % 3 == 0)
            {
                this.AcctBal = this.AcctBal + interestRate;
            }
            else
            {
                this.AcctBal = this.AcctBal;
            }
            
        }

        public double Deposit()
        {

            return this.AcctBal;
        }

        public double BalInq()
        {
            return this.AcctBal;
        }

        public abstract void ViewAccount();// abstract method
    }
}
