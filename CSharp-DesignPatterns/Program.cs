using CSharp_DesignPatterns.Builder;
using CSharp_DesignPatterns.Command;
using CSharp_DesignPatterns.Facade;
using System;

namespace CSharp_DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns!");
            //TestSingleton(); 
            //TestCommand();
            //TestBuilder();
            TestFacade();

            Console.ReadKey();
        }

        public static void TestSingleton()
        {
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

        public static void TestBuilder()
        {
            Console.WriteLine("-- TEST BUILDER --");

            ConcreteBuilderLowerCase lowercaseBuilder = new ConcreteBuilderLowerCase();
            Director lowercaseDirector = new Director(lowercaseBuilder);
            Product lowercaseProduct = lowercaseDirector.BuildFull();
            Console.WriteLine($"{nameof(lowercaseProduct)} - ID:{lowercaseProduct.Id} Name:{lowercaseProduct.Name}");

            ConcreteBuilderUpperCase uppercaseBuilder = new ConcreteBuilderUpperCase();
            Director uppercaseDirector = new Director(uppercaseBuilder);
            Product uppercaseProduct = uppercaseDirector.BuildNameOnly();
            Console.WriteLine($"{nameof(uppercaseProduct)} - ID:{uppercaseProduct.Id} Name:{uppercaseProduct.Name}");
        }

        public static void TestFacade()
        {
            Console.WriteLine("-- TEST FACADE --");

            FacadeClass.FacadeMethodA();
            FacadeClass.FacadeMethodB();
            FacadeClass.FacadeMethodWorkerVariant();
        }
    }
}
