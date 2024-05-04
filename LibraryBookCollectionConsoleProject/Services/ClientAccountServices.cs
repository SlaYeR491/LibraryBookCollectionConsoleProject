using LibraryBookCollectionConsoleProject.Abstractions;
using LibraryBookCollectionConsoleProject.Models;

namespace LibraryBookCollectionConsoleProject.Services
{
    public class ClientAccountServices : AccountServices, IRemoveAccount
    {
        private readonly DataBase dataBase;
        public ClientAccountServices(DataBase dataBase) : base(dataBase)
        {
            this.dataBase = dataBase;
        }
        public override void Add(string UserName, string Password)
        {
            if (dataBase.Accounts.GetAll.FirstOrDefault(a => a.UserName == UserName, null) is null)
            {
                dataBase.Accounts.Add(new ClientAccount() { Password = Password, UserName = UserName, Id = ++IdCnt });
                Console.WriteLine($"ClientAccount With Id={IdCnt} Added Succesfully");
            }
            else
                Console.WriteLine($"Account Already Exist");
        }
        public override void Add(Account Acc)
        {
            if (dataBase.Accounts.GetAll.FirstOrDefault(a => a.UserName == Acc.UserName, null) is null)
            {
                dataBase.Accounts.Add(new ClientAccount() { Password = Acc.Password, UserName = Acc.UserName, Id = ++IdCnt });
                Console.WriteLine($"ClientAccount With Id={IdCnt} Added Succesfully");
            }
            else
                Console.WriteLine($"Account Already Exist");
        }
        public void RemoveAccount(ICanBeRemoved Account)
        {
            var acc = Account as Account;
            if (dataBase.Accounts.GetAll.FirstOrDefault(a => a.UserName == acc.UserName, null) is not null)
            {
                dataBase.Accounts.Remove(acc);
                Console.WriteLine($"Account With UserName:{acc.UserName} Removed");
            }
            else
                Console.WriteLine($"Account With UserName:{acc.UserName} Not Exist");
        }
    }
}
