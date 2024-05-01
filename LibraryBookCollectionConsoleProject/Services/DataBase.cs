using LibraryBookCollectionConsoleProject.Models;
using LibraryBookCollectionConsoleProject.Services;

namespace LibraryBookCollectionConsoleProject.Services
{
    public class DataBase
    {
        public DataBase()
        {
            Books = new CustomManage<Book>();
            Accounts = new CustomManage<Account>();
        }
        public CustomManage<Book> Books { get; }
        public CustomManage<Account> Accounts { get; }
    }
}
