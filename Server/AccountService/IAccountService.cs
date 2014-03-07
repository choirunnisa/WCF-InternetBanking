using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AccountService
{
    //server bener
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAccountService" in both code and config file together.
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        Account Login(int Number, string Password);

        [OperationContract]
        void Register(Account Account);

        [OperationContract]
        int GenerateAccountNumber();

        [OperationContract]
        void Transfer(Account sender, int receiver, decimal amount);

        [OperationContract]
        Account getAccount(int number);

        [OperationContract]
        decimal GetBalance(int number);

        [OperationContract]
        List<string> GetMutations(int number);
    }
}
