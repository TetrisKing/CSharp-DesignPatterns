using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharp_DesignPatterns.Facade
{
    public static class FacadeClass
    {
        public static void FacadeMethodA() {
            Console.WriteLine($"\n--{MethodBase.GetCurrentMethod().Name}--");
            SourceClassA.SourceAMethodA();
            SourceClassA.SourceAMethodC();
        }
        public static void FacadeMethodB()
        {
            Console.WriteLine($"\n--{MethodBase.GetCurrentMethod().Name}--");
            SourceClassB.SourceBMethodA();
            SourceClassB.SourceBMethodB();
        }
        public static void FacadeMethodWorkerVariant()
        {
            Console.WriteLine($"\n--{MethodBase.GetCurrentMethod().Name}--");
            SourceClassA.SourceAMethodA();
            SourceClassB.SourceBMethodB();
        }
    }
}
