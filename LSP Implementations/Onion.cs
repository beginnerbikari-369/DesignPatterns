using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Implementations
{
    internal class Onion:Vegetables
    {
        public string type = "onion";

        public void WRU()
        {
            Console.WriteLine("these are "+type);
        }
    }
}
