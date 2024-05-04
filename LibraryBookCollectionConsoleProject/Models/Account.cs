namespace LibraryBookCollectionConsoleProject.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsCEO { get; set; }
    }
}
