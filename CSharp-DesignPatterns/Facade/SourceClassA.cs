using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharp_DesignPatterns.Facade
{
    public static class SourceClassA
    {
        public static void SourceAMethodA() { Console.WriteLine(MethodBase.GetCurrentMethod().Name); }
        public static void SourceAMethodB() { Console.WriteLine(MethodBase.GetCurrentMethod().Name); }
        public static void SourceAMethodC() { Console.WriteLine(MethodBase.GetCurrentMethod().Name); }
        public static void SourceAMethodD() { Console.WriteLine(MethodBase.GetCurrentMethod().Name); }
    }
}
