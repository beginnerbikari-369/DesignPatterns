using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Implementations
{
    internal class Groceries
    {
        public string type = "groceries";

        public void sendGroceries()
        {
            Console.WriteLine(type+" are ready to delivery.");
        }
    }
}
