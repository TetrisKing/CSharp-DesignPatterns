using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CSharp_DesignPatterns.Factory
{
    public class FactoryShapeDoubleSide : IFactory
    {
        Dictionary<string, Type> shapes;
        public FactoryShapeDoubleSide()
        {
            LoadTypesFactoryCanReturn();
        }

        public IShape CreateInstance(string shapeName, int sidesLength)
        {
            Type t = GetTypeToCreate(shapeName);
            if (t == null)
                return new ShapeNull();

            var shape = Activator.CreateInstance(t) as IShape;
            shape.SetValues(sidesLength * 2);
            return shape;
        }

        private Type GetTypeToCreate(string shapeName)
        {
            if (shapes.ContainsKey(shapeName))
                return shapes[shapeName];
            return null;
        }

        //Find all Types implementing IShape interface and add to shape dictionary
        private void LoadTypesFactoryCanReturn()
        {
            shapes = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            var shapeTypes = typesInThisAssembly.Where(t => t.GetInterface(typeof(IShape).ToString()) != null);

            foreach (var shape in shapeTypes)
            {
                shapes.Add(shape.Name.ToLower(), shape);
            }
        }

    }
}
