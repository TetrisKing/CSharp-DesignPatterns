using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CSharp_DesignPatterns
{
    public sealed class Singleton
    {
        //Singleton is constructed once the first time it is accessed by the public Instance method. Thread-safe.

        //Lazy initialization of an object means that its creation is deferred until it is first used.
        //Guaranteed to never be null.
        private static Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        //Expose static param 'Instance' allowing retrieval of the internal singleton object
        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("Instance called");
                return instance.Value;
            }
        }

        //Constructor called the first time Nested._instance is retrieved
        private Singleton()
        {
            Console.WriteLine("Constructor invoked");
        }
    }
}
