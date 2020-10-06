namespace ObserverPStocks
{
    public interface IObserver<T>
    {
        void Update(T subject);
    }
}