using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcountsOOP
{
    class Account
    {
        private double balance;
        private string type;
        private string owner;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public string Type
        {
            get { return type; }
            set 
            {
                if (value != "credit" && value != "debit" && value!= string.Empty)
                {
                    throw new Exception("The type cannot be other than credit or debit");
                }
                type = value; 
            }
        }
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public Account()
        {
            Balance = 0;
            Type = string.Empty;
            Owner = string.Empty;
        }

        public Account(string oowner, string typee, double balancee)
        {
            Balance = balancee;
            Type = typee;
            Owner = oowner;
        }

        public Account(string oowner, string typee)
        {
            Balance = 0;
            Type = typee;
            Owner = oowner;
        }

        public override string ToString()
        {
            return string.Format($"Owner: {this.Owner}, Type: {this.Type}, Balance: {this.Balance:0.00}");
        }
    }
}
