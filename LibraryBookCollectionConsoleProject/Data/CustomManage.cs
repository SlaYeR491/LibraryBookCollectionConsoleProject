namespace LibraryBookCollectionConsoleProject.Data
{
    public class CustomManage<T>
    {
        private static List<T> lst = new List<T>();
        public IEnumerable<T> GetAll => lst;
        public void Add(T account)
        {
            lst.Add(account);
        }
        public void Remove(T account)
        {
            lst.Remove(account);
        }
    }
}
