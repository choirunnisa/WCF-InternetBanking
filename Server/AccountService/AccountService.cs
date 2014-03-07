using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AccountService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AccountService" in both code and config file together.
    public class AccountService : IAccountService
    {
        static List<Account> accounts;

        static AccountService()
        {
            if (accounts == null)
            {
                accounts = new List<Account>();
            }

            if (accounts.Count == 0)
            {
                Account dummy = new Account();
                dummy.number = 12345678;
                dummy.name = "Dony";
                dummy.password = "12345678";
                dummy.residence = "Bakerstraat 8, Eindhoven";
                dummy.balance = 100;
                dummy.mutations = new List<string>();
                dummy.mutations.Add("Welcome to Awesome Bank");
                accounts.Add(dummy);
            }
        }

        public Account Login(int number, string password)
        {
            Account account = new Account();
            foreach (Account a in accounts)
            {
                if (a.number == number && a.password == password)
                {
                    account.isLoggedin = true;
                    break;
                }
            }
            return account;
        }

        public void Register(Account account)
        {
            account.balance = 100;
            account.mutations = new List<string>();
            account.mutations.Add("Welcome to Awesome Bank");
            account.isLoggedin = true;
            accounts.Add(account);
            Console.WriteLine("New Account has been registered and logged in: " + account.number + " - " + account.name);
        }

        public int GenerateAccountNumber()
        {
            Random random = new Random();
            int accNumber = random.Next(10000000, 99999999);
            return accNumber;
        }

        public Account getAccount(int number)
        {
            Account account = new Account();
            foreach (Account a in accounts)
            {
                if (a.number == number)
                {
                    account.number = a.number;
                    account.password = a.password;
                    account.name = a.name;
                    account.residence = a.residence;
                    account.balance = a.balance;
                    account.mutations = a.mutations;
                    break;
                }
            }
            return account;
        }

        public void Transfer(Account sender, int receiver, decimal amount)
        {
            string receiverName = "";
            string receiverNumber = "";
            bool contains = accounts.Any(a => a.number == receiver);

            if (contains == true)
            {
                //set value for receiver
                foreach (Account a in accounts)
                {
                    if (a.number == receiver && a.number != sender.number)
                    {
                        receiverName = a.name;
                        receiverNumber = a.number.ToString();
                        a.balance += amount;
                        a.mutations.Add("€ " + amount + " has been received from " + sender.name + " - " + sender.number);
                        Console.WriteLine("New Debit: " + a.number + " - " + a.name + " balance is now " + a.balance.ToString());
                        break;
                    }
                }

                //set value for sender
                foreach (Account a in accounts)
                {
                    if (a.number == sender.number && a.number != receiver)
                    {
                        a.balance -= amount;
                        a.mutations.Add("€ " + amount.ToString() + " has been transferred to " + receiverName + " - " + receiverNumber);
                        Console.WriteLine("New Credit: " + a.number + " - " + a.name + " balance is now " + a.balance.ToString());
                        break;
                    }
                }
            }

            else
            {
                //set notexist value for sender
                foreach (Account a in accounts)
                {
                    if (a.number == sender.number)
                    {
                        a.mutations.Add("Transfer is failed. The account number is not exist");
                        Console.WriteLine("Failed Transfer: Account number is not exist. " + a.name + " - "+ a.number);
                        break;
                    }
                }     
            }
        }

        public decimal GetBalance(int number)
        {
            decimal balance = 0;
            foreach (Account a in accounts)
            {
                if (a.number == number)
                {
                    balance = a.balance;
                    break;
                }
            }
            return balance;
        }

        public List<string> GetMutations(int number)
        {
            List<string> list = new List<string>();
            foreach (Account a in accounts)
            {
                if (a.number == number)
                {
                    list = a.mutations;
                    break;
                }
            }
            return list;
        }

    }
}
