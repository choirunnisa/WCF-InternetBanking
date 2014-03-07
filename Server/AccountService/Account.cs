using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountService
{
    public class Account
    {
        private int _number;
        private string _name;
        private string _residence;
        private string _password;
        private decimal _balance;
        private bool _isLoggedin;
        private List<string> _mutations;
        

        public int number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string residence
        {
            get { return _residence; }
            set { _residence = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public decimal balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public bool isLoggedin
        {
            get { return _isLoggedin; }
            set { _isLoggedin = value; }
        }

        public List<string> mutations
        {
            get { return _mutations; }
            set { _mutations = value; }
        }

    }
}
