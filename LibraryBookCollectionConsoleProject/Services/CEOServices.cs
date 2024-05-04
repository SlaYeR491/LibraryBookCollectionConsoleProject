using LibraryBookCollectionConsoleProject.Models;

namespace LibraryBookCollectionConsoleProject.Services
{
    public class CEOServices : AccountServices
    {
        private readonly DataBase dataBase;
        public CEOServices(DataBase dataBase) : base(dataBase)
        {
            this.dataBase = dataBase;
        }
        public override void Add(string UserName, string Password)
        {
            dataBase.Accounts.Add(new CEOAccount() { UserName = UserName, Password = Password, IsCEO = true, Id = ++IdCnt });
            Console.WriteLine($"CEOAccount with Id={IdCnt} Added");
        }
        public override void Add(Account Acc)
        {
            Acc.Id = ++IdCnt;
            dataBase.Accounts.Add(Acc);
            Console.WriteLine($"CEOAccount with Id={IdCnt} Added");
        }
    }
}
