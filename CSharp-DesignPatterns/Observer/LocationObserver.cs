using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharp_DesignPatterns.Observer
{
    public class LocationObserver : IObserver<Location>
    {
        private readonly string name;
        private IDisposable unsubscriber;

        public LocationObserver(string name)
        {
            this.name = name;
        }

        public void Subscribe(IObservable<Location> provider) {
            unsubscriber = provider.Subscribe(this);
        }

        public void OnCompleted()
        {
            Console.WriteLine($"{name} - LocationReporter completed data send.");
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"LocationObserver Error: {name}");
        }

        public void OnNext(Location value)
        {
            Console.WriteLine($"{name} - {value.Latitude}:{value.Longitude}");
        }

        public void Unsubscribe()
        {
            Console.WriteLine($"{name} - Unsubscribe");
            unsubscriber.Dispose();
        }
    }
}
