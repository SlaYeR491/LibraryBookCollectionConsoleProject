using LibraryBookCollectionConsoleProject.Models;

namespace LibraryBookCollectionConsoleProject.Services
{
    public class ClientAccountServices : AccountServices
    {
        private readonly DataBase dataBase;
        public ClientAccountServices(DataBase dataBase)
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
            {
                Console.WriteLine($"Account Already Exist");
            }
        }
        public override void Edit(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
