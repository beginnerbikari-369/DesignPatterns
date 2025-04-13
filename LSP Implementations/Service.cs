using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Implementations
{
    internal class Service
    {
        public string provides = "delivery services";
        
        public void doSomething(Vegetables items)
        {
            Console.WriteLine("this class provides "+this.provides);
            Console.WriteLine(items.type+" are being delivered.");
        }
    }
}
