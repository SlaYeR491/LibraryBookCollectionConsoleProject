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
        public void AddWish(Book book, int ClientId)
        {
            var CList = dataBase.ClientWishList.GetAll.FirstOrDefault(x => x.ClientId == ClientId, null);
            if (CList == null)
            {
                var NWL = new ClientWishList() { ClientId = ClientId };
                NWL.WishList.Add(book);
                dataBase.ClientWishList.Add(NWL);
            }
            else
                CList.WishList.Add(book);
        }
        public void RemoveWish(Book book, int ClientId)
        {
            var CList = dataBase.ClientWishList.GetAll.FirstOrDefault(x => x.ClientId == ClientId, null);
            if (CList == null)
                Console.WriteLine($"Empty Wish List");
            else
            {
                CList.WishList.Remove(book);
                Console.WriteLine($"Book With Title:{book.Title} Removed Succesfuly");
            }
        }
    }
}
