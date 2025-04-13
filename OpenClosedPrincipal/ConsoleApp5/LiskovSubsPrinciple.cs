using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.Product;

namespace ConsoleApp5
{
    public class HTMLElement
    {
        public string Name, Text;
        public List<HTMLElement> Elements = new List<HTMLElement>();
        private const int indentSize = 2;
        public HTMLElement()
        {
                
        }
    }
    public class BuilderDesignPattern
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> valuePairs = new Dictionary<int, int>();
        }
    }
}
