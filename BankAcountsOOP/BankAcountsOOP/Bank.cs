using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcountsOOP
{
    class Bank
    {
        private List<Account> accounts;
        private string name;
        private string address;

        public List<Account> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Bank()
        {
            Accounts = new List<Account>();
            Name = string.Empty;
            Address = string.Empty;
        }

        public Bank(List<Account> accountsInTheBank, string nameOfTheBank, string location)
        {
            Accounts = accountsInTheBank;
            Name = nameOfTheBank;
            Address = location;
        }

        public Bank(string bankName, string bankAddress)
        {
            Accounts = new List<Account>();
            Name = bankName;
            Address = bankAddress;
        }

        public void CreateAccount(Account account)
        {
            Accounts.Add(account);
        }

        public void RemoveAccount(string owner)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].Owner == owner)
                {
                    Accounts.Remove(Accounts[i]);
                    return;
                }
            }

            throw new Exception("Please, enter an existing account owner!");
        }

        public void MakeDeposit(string owner, double deposit)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].Owner == owner)
                {
                    Accounts[i].Balance += deposit;
                    return;
                }
            }
            throw new Exception("Please, enter valid values!");
        }

        public void Withdraw(string owner, double withdrawAmount)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].Owner == owner)
                {
                    if (Accounts[i].Type == "debit" && Accounts[i].Balance - withdrawAmount <= 0)
                    {
                        throw new Exception("You don't have enough balance to withdraw this amount of money!");
                    }
                    else
                    {
                        Accounts[i].Balance -= withdrawAmount;
                        return;
                    }
                }
            }
            throw new Exception("Please, enter valid values!");
        }

        public void Display()
        {
            foreach (var item in Accounts)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
