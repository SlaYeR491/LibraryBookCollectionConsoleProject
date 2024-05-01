using LibraryBookCollectionConsoleProject.Services;
using LibraryBookCollectionConsoleProject.Models;

var _database = new DataBase();
AccountServices AAS = new AdminAccountServices(_database);
AAS.Add("Slayer", "123");
AccountServices CAS = new ClientAccountServices(_database);
CAS.Add("Hamada", "56");
//*****************************************
var BS = new BookServices(_database);
BS.Add("adsd");
BS.Remove(1);