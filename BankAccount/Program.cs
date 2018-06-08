using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitResponse = true;
            string exitChecker = "no";
            Savings savings = new Savings();
            Checking checking = new Checking();
            while (exitResponse == true)
            {

                string[] choiceArray = new string[] {"1. View Client Information","2. View Account Balance","3. Deposit Funds", "4. Withdraw Funds", "5. Exit"};
                int menuChoice;
                int accountChoice;
                Console.WriteLine("Welcome to Local Bank? How can we help you today?");

                for (int i = 0; i < choiceArray.Length; i++)
                {
                    Console.WriteLine(choiceArray[i]);
                }

                menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1: // Method (Remember to also Call Intrest Method)
                        savings.AddIntrest();
                        checking.AddIntrest();
                        break;
                    case 2: Console.WriteLine("Which account would you like to view?");
                        savings.AddIntrest();
                        checking.AddIntrest();
                        
                        bool accountwhile = true;
                        while (accountwhile == true)
                        {
                            accountChoice = int.Parse(Console.ReadLine());
                            if (accountChoice == 1)
                            {
                                accountwhile = false;
                            }
                            else if (accountChoice == 2)
                            {
                                accountwhile = false;
                            }
                            else
                            {
                                Console.WriteLine("You have made an incorrect choice, please choose again.");
                            }

                        }
                            break;
                        
                    case 3: // Method
                        savings.AddIntrest();
                        checking.AddIntrest();
                        Console.WriteLine("Which account would you like to deposit funds into?");
                        bool accountwhile2 = true;
                        while (accountwhile2 == true)
                        {
                            accountChoice = int.Parse(Console.ReadLine());
                            if (accountChoice == 1)
                            {
                                accountwhile = false;
                            }
                            else if (accountChoice == 2)
                            {
                                accountwhile = false;
                            }
                            else
                            {
                                Console.WriteLine("You have made an incorrect choice, please choose again.");
                            }

                        }
                        break;
                    case 4: // Method
                        savings.AddIntrest();
                        checking.AddIntrest();
                        Console.WriteLine("Which account would you like to withdraw funds from?");
                        bool accountwhile3 = true;
                        while (accountwhile3 == true)
                        {
                            accountChoice = int.Parse(Console.ReadLine());
                            if (accountChoice == 1)
                            {
                                accountwhile = false;
                            }
                            else if (accountChoice == 2)
                            {
                                accountwhile = false;
                            }
                            else
                            {
                                Console.WriteLine("You have made an incorrect choice, please choose again.");
                            }

                        }
                        break;
                    case 5:// Method for exit
                        savings.AddIntrest();
                        checking.AddIntrest();
                        break;
                    default: Console.WriteLine("You have made an incorrect choice please choose again");
                        savings.AddIntrest();
                        checking.AddIntrest();
                        break;
                }
                













                if (exitChecker.Equals("yes"))
                {
                    exitResponse = false;
                }
                else
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
