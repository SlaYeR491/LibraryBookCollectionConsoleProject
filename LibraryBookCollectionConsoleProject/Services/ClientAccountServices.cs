using LibraryBookCollectionConsoleProject.Models;

namespace LibraryBookCollectionConsoleProject.Services
{
    public class ClientAccountServices : AccountServices, ICanBeRemoved
    {
        private readonly DataBase dataBase;
        private readonly ClientWishListServices clientWish;
        public ClientAccountServices(DataBase dataBase, ClientWishListServices clientWish) : base(dataBase)
        {
            this.dataBase = dataBase;
            this.clientWish = clientWish;
        }
        public override void Add(string UserName, string Password)
        {
            if (dataBase.Accounts.GetAll.FirstOrDefault(a => a.UserName == UserName, null) is null)
            {
                dataBase.Accounts.Add(new ClientAccount() { Password = Password, UserName = UserName, Id = ++IdCnt });
                Console.WriteLine($"Account With Id={IdCnt} Added Succesfully");
            }
            else
                Console.WriteLine($"Account Already Exist");
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
        public void Remove(ClientAccount Account)
        {
            dataBase.Accounts.Remove(Account);
            Console.WriteLine($"Account With UserName:{Account.UserName} Removed");
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
    }
}
