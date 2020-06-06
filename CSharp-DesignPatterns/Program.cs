using CSharp_DesignPatterns.Command;
using System;

namespace CSharp_DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns!");
            //TestSingleton(); 
            TestCommand();

            Console.ReadKey();
        }

        public static void TestSingleton() {
            Console.WriteLine("-- TEST SINGLETON --");
            //Only the first time Singleton.Instance is retrieved will it be constructed
            Singleton singletonObject = Singleton.Instance;
            Singleton singletonObjectTwo = Singleton.Instance;
            Singleton singletonObjectThree = Singleton.Instance;
        }

        public static void TestCommand()
        {
            Console.WriteLine("-- TEST COMMAND --");
            CommandClient client = new CommandClient();
            client.StartClient();
        }
    }
}
