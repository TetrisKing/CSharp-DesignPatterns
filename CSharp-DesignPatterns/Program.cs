using CSharp_DesignPatterns.Builder;
using CSharp_DesignPatterns.Command;
using CSharp_DesignPatterns.Facade;
using CSharp_DesignPatterns.Factory;
using CSharp_DesignPatterns.Factory.AbstractFactory;
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
            //TestFacade();
            TestFactory();

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
        
        public static void TestFactory()
        {
            //Factory that creates all shapes but with different factory implementations
            Console.WriteLine("\nShapeFactory");
            IFactory factory = new FactoryShape();
            IShape square = factory.CreateInstance("shapesquare", 5);
            IShape triangle = factory.CreateInstance("shapetriangle", 5);
            Console.WriteLine(square.GetInfo());
            Console.WriteLine(triangle.GetInfo());

            Console.WriteLine("\nShapeDoubleSideFactory");
            IFactory doubleFactory = new FactoryShapeDoubleSide();
            IShape doubleSquare = doubleFactory.CreateInstance("shapesquare", 5);
            IShape doubleTriangle = doubleFactory.CreateInstance("shapetriangle", 5);
            Console.WriteLine(doubleSquare.GetInfo());
            Console.WriteLine(doubleTriangle.GetInfo());

            //Load a Factory to create a specific type of ICar
            ICarFactory bmwFactory = FactoryLoader.GetCarFactory("FactoryBMW");
            ICarFactory miniFactory = FactoryLoader.GetCarFactory("FactoryMiniCooper");
            ICar bmw = bmwFactory.CreateInstance();
            ICar mini = miniFactory.CreateInstance();
            Console.WriteLine(bmw.TurnOn());
            Console.WriteLine(bmw.TurnOff());
            Console.WriteLine(mini.TurnOn());
            Console.WriteLine(mini.TurnOff());
        }
    }
}
