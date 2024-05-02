using LibraryBookCollectionConsoleProject.Models;

namespace LibraryBookCollectionConsoleProject.Services
{
    public class ClientWishListServices
    {
        private readonly DataBase dataBase;
        public ClientWishListServices(DataBase dataBase)
        {
            this.dataBase = dataBase;
        }
        public void AddWish(Book book, Account Client)
        {
            var CList = dataBase.ClientWishList.GetAll.FirstOrDefault(x => x.ClientId == Client.Id, null);
            if (CList is null)
            {
                var NWL = new ClientWishList() { ClientId = Client.Id };
                NWL.WishList.Add(book);
                dataBase.ClientWishList.Add(NWL);
            }
            else
                CList.WishList.Add(book);
            Console.WriteLine($"Book With Title:{book.Title} Added To Account:{Client.UserName}");
        }
        public void RemoveWish(Book book, Account Client)
        {
            var CList = dataBase.ClientWishList.GetAll.FirstOrDefault(x => x.ClientId == Client.Id, null);
            if (CList is null)
                Console.WriteLine($"Empty Wish List");
            else
            {
                CList.WishList.Remove(book);
                Console.WriteLine($"Book With Title:{book.Title} Removed From Account:{Client.UserName}");
            }
        }
    }
}
