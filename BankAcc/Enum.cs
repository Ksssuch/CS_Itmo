using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{

    public enum AccountType { Checking, Deposit }
    class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;
            Console.WriteLine("The custumer Account Type is {0}", goldAccount);
            Console.WriteLine("The custumer Account Type is {0}", platinumAccount);


        }
    }
}
