using LibraryBookCollectionConsoleProject.Models;

namespace LibraryBookCollectionConsoleProject.Services
{
    public class DataBase
    {
        public DataBase()
        {
            Books = new CustomManage<Book>();
            Accounts = new CustomManage<Account>();
            ClientWishList = new CustomManage<ClientWishList>();
        }
        public CustomManage<Book> Books { get; }
        public CustomManage<Account> Accounts { get; }
        public CustomManage<ClientWishList> ClientWishList { get; }
    }
}
