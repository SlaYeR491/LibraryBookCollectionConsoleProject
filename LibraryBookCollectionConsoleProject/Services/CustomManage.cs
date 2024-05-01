namespace LibraryBookCollectionConsoleProject.Services
{
    public class CustomManage<T>
    {
        private  List<T> lst = new List<T>();
        public  IEnumerable<T> GetAll => lst;
        public  void Add(T account)
        {
            lst.Add(account);
        }
        public  void Remove(T account)
        {
            lst.Remove(account);
        }
    }
}
