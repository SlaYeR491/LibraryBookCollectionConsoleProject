namespace LibraryBookCollectionConsoleProject.Models
{
    public class ClientWishList
    {
        public int ClientId { get; set; }
        public List<Book>? WishList { get; } = new List<Book>();
    }
}
