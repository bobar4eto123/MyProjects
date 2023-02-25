using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcountsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            string cr;

            Console.WriteLine("Hello, User!");
            Console.WriteLine("If you want to see all the commands you can use here, please write down \"Help\"!");

            start:
            cr = Console.ReadLine();   

            switch (cr)
            {
                case "Help":
                    Console.WriteLine("If you want to create a new account in our bank system, please write down \"CreateAccount\"!");
                    Console.WriteLine("If you want to remove an existing bank account from our system, please write down \"RemoveAccount\"!");
                    Console.WriteLine("If you want to deposit amount of money in an existing account in our system, please write down \"Deposit\"!");
                    Console.WriteLine("If you want to withdraw amount of money from an existing bank account in our system, please write down \"Withdraw\"!");
                    Console.WriteLine("If you want to see all the existing bank accounts in our system, please write down \"Display\"!");
                    goto start;

                case "CreateAccount":
                    Console.WriteLine("You have two options for creating an account");
                    Console.WriteLine("If you write down \"1st\", you have to write next: {account owner's name} {type of account (credit/deposit)}");
                    Console.WriteLine("If you write down \"2nd\", you have to write next: {account owner's name} {type of account (credit/deposit)} {starting balance in the account}");

                    ff:

                    string choiseForCreatingAnAccount = Console.ReadLine();

                    if (choiseForCreatingAnAccount == "1st")
                    {
                        back:
                        var line1 = Console.ReadLine().Split(' ').ToArray();
                        Account newAccount = new Account();
                        try
                        {
                            newAccount = new Account(line1[0], line1[1]);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto back;
                        }
                        bank.CreateAccount(newAccount);
                    }
                    else if (choiseForCreatingAnAccount == "2nd")
                    {
                        back1:
                        var line2 = Console.ReadLine().Split(' ').ToArray();
                        Account newAccount = new Account();
                        try
                        {
                            newAccount = new Account(line2[0], line2[1], double.Parse(line2[2]));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto back1;
                        }
                        bank.CreateAccount(newAccount);
                    }
                    else
                    {
                        Console.WriteLine("Please, enter a valid option (1st/2nd)");
                        goto ff;
                    }
                    break;

                case "RemoveAccount":
                    Console.WriteLine("Write down an existing account owner whose account you want to delete from the system");
                    fg:
                    string ownerToDelete = Console.ReadLine();
                    try
                    {
                        bank.RemoveAccount(ownerToDelete);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto fg;
                    }
                    break;

                case "Deposit":
                    Console.WriteLine("Please, write down: {an existing account owner} {amount of the deposit}");
                    pp:
                    var line = Console.ReadLine().Split(' ').ToArray();
                    try
                    {
                        bank.MakeDeposit(line[0], double.Parse(line[1]));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto pp;
                    }
                    break;

                case "Withdraw":
                    Console.WriteLine("Please, write down: {an existing account owner} {amount of withdraw}");
                    pg:
                    var linee = Console.ReadLine().Split(' ').ToArray();
                    try
                    {
                        bank.Withdraw(linee[0], double.Parse(linee[1]));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto pg;
                    }                    
                    break;
                case "Display":
                    bank.Display();
                    break;

                default:
                    Console.WriteLine("Please enter a valid command!");
                    goto start;             
            }

            Console.WriteLine(new String('-', 35));
            Console.WriteLine("Write down \"Continue\" if you want to continue!");
            if (Console.ReadLine() == "Continue") goto start;
        }
    }
}
