using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CSharp_DesignPatterns.Factory.AbstractFactory
{
    public static class FactoryLoader
    {
        private static Dictionary<string, Type> factories;
        static FactoryLoader()
        {
            LoadTypesFactoryCanReturn();
        }

        public static ICarFactory GetCarFactory(string factoryName) {
            Type t = GetTypeToCreate(factoryName);
            return Assembly.GetExecutingAssembly().CreateInstance(t.FullName) as ICarFactory;
        }

        private static Type GetTypeToCreate(string factoryName)
        {
            if (factories.ContainsKey(factoryName))
                return factories[factoryName];
            return null;
        }

        //Find all Types implementing ICarFactory interface and add to dictionary
        private static void LoadTypesFactoryCanReturn()
        {
            factories = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            var factoryTypes = typesInThisAssembly.Where(t => t.GetInterface(typeof(ICarFactory).ToString()) != null);

            foreach (var factory in factoryTypes)
            {
                factories.Add(factory.Name, factory);
            }
        }
    }
}
