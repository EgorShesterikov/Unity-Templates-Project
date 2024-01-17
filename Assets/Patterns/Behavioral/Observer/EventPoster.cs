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

            _input.ClickedAlpha1 += NotiflyJump;
            _input.ClickedAlpha2 += NotiflyAttack;
            _input.ClickedAlpha3 += NotiflyMove;

            _observers = new List<IObserver>(observers);
        }

        public void Dispose()
        {
            _input.ClickedAlpha1 -= NotiflyJump;
            _input.ClickedAlpha2 -= NotiflyAttack;
            _input.ClickedAlpha3 -= NotiflyMove;
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

        private void NotiflyJump()
            => Notifly(MassageTypes.Jump);
        private void NotiflyAttack()
            => Notifly(MassageTypes.Attack);
        private void NotiflyMove()
            => Notifly(MassageTypes.Move);
    }

}
