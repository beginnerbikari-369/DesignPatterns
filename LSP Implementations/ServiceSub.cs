using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Implementations
{
    internal class ServiceSub: Service
    {
        string provides = "food delivery";

        public void doSomething(Groceries items)
        {
            Console.WriteLine("this class provides "+ provides);
            Console.WriteLine(items.type+" are being delivered.");
        }
    }
}
