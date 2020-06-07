using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Adapter
{
    public class Source
    {
        public string GetData()
        {
            string data = "Data" + Guid.NewGuid().ToString();
            Console.WriteLine($"Source-Data Sent: {data}");
            return data;
        }
    }
}
