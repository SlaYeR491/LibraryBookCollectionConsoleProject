using LibraryBookCollectionConsoleProject.Models;

namespace LibraryBookCollectionConsoleProject.Services
{
    internal class AdminAccountServices : AccountServices
    {
        private readonly DataBase dataBase;
        public AdminAccountServices(DataBase dataBase) : base(dataBase)
        {
            this.dataBase = dataBase;
        }
        public override void Add(string UserName, string Password)
        {
            if (dataBase.Accounts.GetAll.FirstOrDefault(a => a.UserName == UserName,null) is null)
            {
                dataBase.Accounts.Add(new AdminAccount() { Password = Password, UserName = UserName, Id = ++IdCnt, IsAdmin = true });
                Console.WriteLine($"Account With Id={IdCnt} Added Succesfully");
            }
            else
                Console.WriteLine($"Account Already Exist");
        }
    }
}
