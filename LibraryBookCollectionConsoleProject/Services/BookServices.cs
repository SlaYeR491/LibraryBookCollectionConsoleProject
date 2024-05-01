using LibraryBookCollectionConsoleProject.Models;

namespace LibraryBookCollectionConsoleProject.Services
{
    public class BookServices
    {
        private static int BookIdCnt = 0;
        private readonly DataBase dataBase;
        public BookServices(DataBase dataBase)
        {
            this.dataBase = dataBase;
        }
        public void Add(string Title)
        {
            if (dataBase.Books.GetAll.Any(x => x.Title == Title))
            {
                Console.WriteLine($"This Book Is Already Exist");
            }
            else
            {
                dataBase.Books.Add(new Book() { Title = Title, Id = ++BookIdCnt });
                Console.WriteLine($"Book With ID={BookIdCnt} Succesfully Added");
            }
        }
        public void Remove(int Id)
        {
            var Exist = dataBase.Books.GetAll.FirstOrDefault(x => x.Id == Id,null);
            if (Exist != null)
            {
                dataBase.Books.Remove(Exist);
                Console.WriteLine($"Book With ID={Id} Succefully Removed");
            }
            else
            {
                Console.WriteLine($"The Book Doesnt Exist!");
            }
        }
        public bool IsAvailable(string Title)
        {
            return dataBase.Books.GetAll.Any(x => x.Title == Title);
        }
    }
}
