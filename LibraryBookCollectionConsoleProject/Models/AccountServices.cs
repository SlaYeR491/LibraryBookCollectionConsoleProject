namespace LibraryBookCollectionConsoleProject.Models
{
    public abstract class AccountServices
    {
        protected static int IdCnt = 0;
        public abstract void Add(string UserName, string Password);
        public abstract void Edit(int Id);
        public static void Remove(ClientAccount Account)
        {

        }
    }
}
