using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharp_DesignPatterns.Facade
{
    public class SourceClassB
    {
        public static void SourceBMethodA() { Console.WriteLine(MethodBase.GetCurrentMethod().Name); }
        public static void SourceBMethodB() { Console.WriteLine(MethodBase.GetCurrentMethod().Name); }
        public static void SourceBMethodC() { Console.WriteLine(MethodBase.GetCurrentMethod().Name); }
    }
}
