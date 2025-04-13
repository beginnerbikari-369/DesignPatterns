using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Implementations
{
    internal class Vegetables:Groceries
    {
        public string type = "vegetables";

        public void sendGroceries()
        {
            Console.WriteLine(type + " are ready to delivery.");
        }
    }
}
