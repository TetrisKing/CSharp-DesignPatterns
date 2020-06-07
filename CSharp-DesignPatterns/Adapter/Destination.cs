using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Adapter
{
    public class Destination
    {
        private readonly IAdapter adapter;

        public Destination(IAdapter adapter)
        {
            this.adapter = adapter;
        }

        public void RecieveData()
        {
            string data = adapter.TransferData();
            Console.WriteLine($"Destination - Call adapter method TransferData() - {data}");
        }
    }
}
