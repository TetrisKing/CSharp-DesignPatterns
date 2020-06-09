using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Observer
{
    public class LocationReporter : IObservable<Location>
    {
        private List<IObserver<Location>> observers = new List<IObserver<Location>>();

        public IDisposable Subscribe(IObserver<Location> observer)
        {
            if(!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        public void TrackLocation(Location? loc) {
            foreach (var observer in observers)
            {
                if (loc.HasValue)
                    observer.OnNext(loc.Value);
                else
                    observer.OnError(new Exception("LocationNull"));
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
            {
                observer.OnCompleted();
            }
            observers.Clear();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Location>> _observers;
            private IObserver<Location> _observer;

            public Unsubscriber(List<IObserver<Location>> observers, IObserver<Location> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
