using LibraryBookCollectionConsoleProject.SubServices;

namespace LibraryBookCollectionConsoleProject.Services
{
    public class ClientServices
    {
        private readonly DataBase dataBase;
        private readonly ClientWishListServices clientWish;
        public ClientServices(DataBase dataBase, ClientWishListServices clientWish)
        {
            this.dataBase = dataBase;
            this.clientWish = clientWish;
        }
        public void RemoveFromWishList(int BookId, int ClientId)
        {
            var book = dataBase.Books.GetAll.FirstOrDefault(x => x.Id == BookId);
            var Client = dataBase.Accounts.GetAll.FirstOrDefault(x => x.Id == ClientId);
            if (book is null)
                Console.WriteLine($"No Such A Book With Id:{BookId}");
            else if (Client is null)
                Console.WriteLine($"No Such A Client With Id:{ClientId}");
            else
                clientWish.RemoveWish(book, Client);
        }
        public void AddToWishList(int BookId, int ClientId)
        {
            var book = dataBase.Books.GetAll.FirstOrDefault(x => x.Id == BookId);
            var Client = dataBase.Accounts.GetAll.FirstOrDefault(x => x.Id == ClientId);
            if (book is null)
                Console.WriteLine($"No Such A Book With This Id");
            else if (Client is null)
                Console.WriteLine($"No Such A Client With This Id");
            else
                clientWish.AddWish(book, Client);
        }

    }
}
