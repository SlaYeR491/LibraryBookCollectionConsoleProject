using LibraryBookCollectionConsoleProject.Abstractions;
using LibraryBookCollectionConsoleProject.Models;
using LibraryBookCollectionConsoleProject.Services;

var _database = new DataBase();
new CEOServices(_database).Add("Mohamed", "Ahmed");
//AdminAccountServices AAS = new AdminAccountServices(_database);
//AAS.Add("Slayer", "123");
ClientAccountServices CAS = new ClientAccountServices(_database);
IRemoveAccount remove = new ClientAccountServices(_database);
var cleintacc = new ClientAccount() { UserName = "Hamada", Password = "123" };
CAS.Add(cleintacc);
Console.WriteLine("**************************************************");
remove.RemoveAccount(cleintacc);
//CAS.Add("Ahmed", "321");
Console.WriteLine("**************************************************");
//AAS.EditUserName(1, "Ahmed");
//AAS.EditPassword(2, "password");
//foreach(var acc in _database.Accounts.GetAll)
//    Console.WriteLine(acc.UserName+" "+acc.Password);
//var BS = new BookServices(_database);
//BS.Add("Harry Potter");
//BS.Add("Alis In Wonder World");
//Console.WriteLine("**************************************************");
//ClientServices CS = new ClientServices(_database, new ClientWishListServices(_database));
//CS.AddToWishList(1, 1);
//CS.AddToWishList(2, 1);
//Console.WriteLine("**************************************************");
//CS.RemoveFromWishList(2, 1);
//foreach (var Cwish in _database.ClientWishList.GetAll)
//{
//    Console.Write(Cwish.ClientId + ":");
//    foreach (var wish in Cwish.WishList)
//    {
//        Console.Write(wish.Title + ",");
//    }
//    Console.WriteLine();
//}