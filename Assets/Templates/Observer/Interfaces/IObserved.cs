namespace Observer
{
    public interface IObserved
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void Notifly(MassageTypes massage);
    }
}
