using LibraryBookCollectionConsoleProject.Services;

var _database = new DataBase();
//AdminAccountServices AAS = new AdminAccountServices(_database);
//AAS.Add("Slayer", "123");
ClientAccountServices CAS = new ClientAccountServices(_database, new ClientWishListServices(_database));
CAS.Add("Hamada", "123");
CAS.Add("Ahmed", "321");
Console.WriteLine("**************************************************");
//AAS.EditUserName(1, "Ahmed");
//AAS.EditPassword(2, "password");
//foreach(var acc in _database.Accounts.GetAll)
//    Console.WriteLine(acc.UserName+" "+acc.Password);
var BS = new BookServices(_database);
BS.Add("Harry Potter");
BS.Add("Alis In Wonder World");
Console.WriteLine("**************************************************");
CAS.AddToWishList(1, 1);
CAS.AddToWishList(2, 1);
Console.WriteLine("**************************************************");
CAS.RemoveFromWishList(2, 1);
foreach (var Cwish in _database.ClientWishList.GetAll)
{
    Console.Write(Cwish.ClientId + ":");
    foreach (var wish in Cwish.WishList)
    {
        Console.Write(wish.Title + ",");
    }
    Console.WriteLine();
}