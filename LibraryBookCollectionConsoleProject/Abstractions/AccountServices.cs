using LibraryBookCollectionConsoleProject.Services;

namespace LibraryBookCollectionConsoleProject.Models
{
    public abstract class AccountServices
    {
        protected static int IdCnt = 0;
        private readonly DataBase dataBase;
        public AccountServices(DataBase dataBase)
        {
            this.dataBase = dataBase;
        }
        public abstract void Add(string UserName, string Password);
        public abstract void Add(Account Acc);
        protected bool Check(int Id)
        {
            return dataBase.Accounts.GetAll.FirstOrDefault(a => a.Id == Id) != null;
        }
        public void EditUserName(int Id, string NewUserName)
        {
            if (Check(Id))
            {
                if (!dataBase.Accounts.GetAll.Any(a => a.UserName == NewUserName))
                {
                    var Acc = dataBase.Accounts.GetAll.First(x => x.Id == Id);
                    Acc.UserName = NewUserName;
                    Console.WriteLine($"UserName Changed For AccountId={Acc.Id}");
                }
                else
                    Console.WriteLine($"UserName:{NewUserName} Already Exist");
            }
            else
                Console.WriteLine($"No Such Client With Id={Id}");
        }
        public void EditPassword(int Id, string NewPassword)
        {
            if (Check(Id))
            {
                var Acc = dataBase.Accounts.GetAll.First(x => x.Id == Id);
                Acc.Password = NewPassword;
                Console.WriteLine($"Password Changed For AccountId={Acc.Id}");

            }
            else
                Console.WriteLine($"No Such Client With Id={Id}");
        }
    }
}
