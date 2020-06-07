using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Adapter
{
    public class SourceToDestinationAdapter : IAdapter
    {
        private readonly Source source;

        public SourceToDestinationAdapter(Source source)
        {
            this.source = source;
        }

        public string TransferData()
        {
            string data = source.GetData();
            Console.WriteLine($"Adapter - Use Source GetData() method and provide the TransferData method Destination class expects: {data}");
            return data;
        }
    }
}
