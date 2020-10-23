namespace ObserverPStocks
{
    public interface IObserver
    {
        void Update();

        void AddSubject(ISubject subject);
    }
}