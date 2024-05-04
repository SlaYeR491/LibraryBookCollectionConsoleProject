using LibraryBookCollectionConsoleProject.Abstractions;
using LibraryBookCollectionConsoleProject.Models;

namespace LibraryBookCollectionConsoleProject.Services
{
    internal class AdminAccountServices : AccountServices, IRemoveAccount
    {
        private readonly DataBase dataBase;
        public AdminAccountServices(DataBase dataBase) : base(dataBase)
        {
            this.dataBase = dataBase;
        }
        public override void Add(string UserName, string Password)
        {
            if (dataBase.Accounts.GetAll.FirstOrDefault(a => a.UserName == UserName, null) is null)
            {
                dataBase.Accounts.Add(new AdminAccount() { Password = Password, UserName = UserName, Id = ++IdCnt, IsAdmin = true });
                Console.WriteLine($"AdminAccount With Id={IdCnt} Added Succesfully");
            }
            else
                Console.WriteLine($"Account Already Exist");
        }
        public override void Add(Account Acc)
        {
            if (dataBase.Accounts.GetAll.FirstOrDefault(a => a.UserName == Acc.UserName, null) is null)
            {
                dataBase.Accounts.Add(new AdminAccount() { Password = Acc.Password, UserName = Acc.UserName, Id = ++IdCnt, IsAdmin = true });
                Console.WriteLine($"AdminAccount With Id={IdCnt} Added Succesfully");
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
                Console.WriteLine($"Account With UserName:{acc.UserName} Removed Not Exist");
        }
    }
}
