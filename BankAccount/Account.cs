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
        public string IntrestRate { get; set; }


        public Account()
        {
            //default constructor
        }

        public Account(string name, string acctType, double acctBal, string intrestRate)
        {
            this.Name = name;
            this.AcctType = acctType;
            this.AcctBal = acctBal;
            this.IntrestRate = intrestRate;
        }

        public double Withdraw()
        {
            double withdrawlAmt = 0;

            withdrawlAmt =double.Parse(Console.ReadLine());
            this.AcctBal = AcctBal - withdrawlAmt;

            if((AcctBal == 0) || (withdrawlAmt > AcctBal))
            {
                Console.WriteLine("Insufficent Funds!!!!");
            }
            return AcctBal;
        }

        public virtual void AddIntrest() //this is like the Tick() method in our last project
        {
            int intrestTick = 0;
            double interestRate = this.AcctBal / 100;
            intrestTick = intrestTick + 1;
            if(intrestTick == 3 )
            {
                this.AcctBal = this.AcctBal + interestRate;
                intrestTick = 0;
            }
            else
            {
                this.AcctBal = this.AcctBal;
            }
            
        }

        public double Deposit()
        {

            double depositAmt = 0;

            depositAmt = double.Parse(Console.ReadLine());
            this.AcctBal = AcctBal + depositAmt;

         
            return AcctBal;
        }

        public double BalInq()
        {
            return this.AcctBal;
        }

        public abstract void ViewAccount();// abstract method
    }
}
