using DesignPattern.Observer.DataAccessLayer;

namespace DesignPattern.Observer.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
