using LibraryBookCollectionConsoleProject.Models;

namespace LibraryBookCollectionConsoleProject.Abstractions
{
    public interface IRemoveAccount
    {
        public void RemoveAccount(ICanBeRemoved Acc);
    }
}
