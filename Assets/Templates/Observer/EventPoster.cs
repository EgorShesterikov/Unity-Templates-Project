using System;
using System.Collections.Generic;

namespace Observer
{
    public class EventPoster : IObserved, IDisposable
    {
        private InputHandler _input;

        private List<IObserver> _observers;

        public EventPoster(InputHandler input, List<IObserver> observers)
        {
            _input = input;

            _input.ClickedAlpha1 += () => Notifly(MassageTypes.Jump);
            _input.ClickedAlpha2 += () => Notifly(MassageTypes.Attack);
            _input.ClickedAlpha3 += () => Notifly(MassageTypes.Move);

            _observers = new List<IObserver>(observers);
        }

        public void Dispose()
        {
            _input.ClickedAlpha1 -= () => Notifly(MassageTypes.Jump);
            _input.ClickedAlpha2 -= () => Notifly(MassageTypes.Attack);
            _input.ClickedAlpha3 -= () => Notifly(MassageTypes.Move);
        }

        public void AddObserver(IObserver observer)
            => _observers.Add(observer);

        public void RemoveObserver(IObserver observer)
            => _observers.Remove(observer);

        public void Notifly(MassageTypes massage)
        {
            foreach (IObserver observer in _observers)
                observer.OnNotify(massage);
        }
    }

}
