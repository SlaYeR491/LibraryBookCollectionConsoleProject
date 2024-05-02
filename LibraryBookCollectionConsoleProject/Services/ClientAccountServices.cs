using LibraryBookCollectionConsoleProject.SubServices;
using LibraryBookCollectionConsoleProject.Models;

namespace LibraryBookCollectionConsoleProject.Services
{
    public class ClientAccountServices : AccountServices, ICanBeRemoved
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
                Console.WriteLine($"Account With Id={IdCnt} Added Succesfully");
            }
            else
                Console.WriteLine($"Account Already Exist");
        }
        public void Remove(ClientAccount Account)
        {
            dataBase.Accounts.Remove(Account);
            Console.WriteLine($"Account With UserName:{Account.UserName} Removed");
        }
    }
}
