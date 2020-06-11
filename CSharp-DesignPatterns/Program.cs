using CSharp_DesignPatterns.Adapter;
using CSharp_DesignPatterns.Builder;
using CSharp_DesignPatterns.Command;
using CSharp_DesignPatterns.Composite;
using CSharp_DesignPatterns.Decorator;
using CSharp_DesignPatterns.Facade;
using CSharp_DesignPatterns.Factory;
using CSharp_DesignPatterns.Factory.AbstractFactory;
using CSharp_DesignPatterns.Iterator;
using CSharp_DesignPatterns.Observer;
using CSharp_DesignPatterns.Prototype;
using CSharp_DesignPatterns.State;
using System;
using System.Collections.Generic;
using System.Linq;

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
            //TestFactory();
            //TestDecorator();
            //TestAdapter();
            //TestState();
            //TestObserver();
            //TestPrototype();
            //TestComposite();
            TestIterator();

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
            Console.WriteLine("-- TEST FACTORY --");

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

        public static void TestDecorator()
        {
            Console.WriteLine("-- TEST DECORATOR --");

            IComponent basicHero = new Component();
            Console.WriteLine(basicHero.GetEquipment());

            IComponent shieldHero = new DecoratorEquipShield(basicHero);
            Console.WriteLine(shieldHero.GetEquipment());

            IComponent loggedShieldHero = new DecoratorLogging(shieldHero);
            Console.WriteLine(loggedShieldHero.GetEquipment());

            IComponent wrappedHero = new DecoratorLogging(new DecoratorEquipShield(new Component()));
            Console.WriteLine(wrappedHero.GetEquipment());
        }

        public static void TestAdapter()
        {
            Console.WriteLine("-- TEST ADAPTER --");

            Source source = new Source();
            IAdapter adapter = new SourceToDestinationAdapter(source);
            Destination destination = new Destination(adapter);
            destination.RecieveData();
        }

        public static void TestState()
        {
            Console.WriteLine("-- TEST STATE --");

            StateContext context = new StateContext(new StateOpen());
            context.DoWork();
            context.ChangeState();
            context.DoWork();
            context.ChangeState();
            context.DoWork();
        }

        public static void TestObserver()
        {
            Console.WriteLine("-- TEST OBSERVER IObservable Pattern --");
            LocationReporter reporter = new LocationReporter();
            LocationObserver observer1 = new LocationObserver("observer1");
            LocationObserver observer2 = new LocationObserver("observer2");
            LocationObserver observer3 = new LocationObserver("observer3");
            observer1.Subscribe(reporter);
            observer2.Subscribe(reporter);
            observer3.Subscribe(reporter);

            reporter.TrackLocation(new Location(10, 10));
            observer3.Unsubscribe();

            reporter.TrackLocation(new Location(100, 333));

            reporter.TrackLocation(null);

            reporter.EndTransmission();
        }

        public static void TestPrototype() {
            Console.WriteLine("-- TEST PROTOTYPE --");
            IPrototype proA = new PrototypeA("ProtoA");
            IPrototype proB = proA.Clone();
            Console.WriteLine($"Original - {proA.GetName()}");
            Console.WriteLine($"Clone - {proB.GetName()}");
        }

        public static void TestComposite()
        {
            Console.WriteLine("-- TEST COMPOSITE --");
            ICompositeCompenent main = new CompositeComponent("TOP");

            ICompositeCompenent componentA = new CompositeComponent("ComponentA");
            ICompositeCompenent componentB = new CompositeComponent("ComponentB");
            ICompositeCompenent componentC = new CompositeComponent("ComponentC");

            ICompositeCompenent leaf = new Leaf("Leaf");
            ICompositeCompenent leafA1 = new Leaf("LeafA1");
            ICompositeCompenent leafA2 = new Leaf("LeafA2");
            ICompositeCompenent leafB1 = new Leaf("LeafB1");
            ICompositeCompenent leafC1 = new Leaf("LeafC1");

            componentA.Add(leafA1);
            componentA.Add(leafA2);
            componentB.Add(leafB1);
            componentB.Add(componentC);
            componentC.Add(leafC1);

            main.Add(leaf);
            main.Add(componentA);
            main.Add(componentB);
            main.Display(0);
        }

        public static void TestIterator()
        {
            Console.WriteLine("-- TEST ITERATOR --");

            Console.WriteLine("ForwardIterator");
            IteratorDataCollection data = new IteratorDataCollection();
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("ReverseIterator");
            IteratorDataCollection reverseData = new IteratorDataCollection(true);
            foreach (var item in reverseData)
            {
                Console.WriteLine(item);
            }
        }
    }
}
