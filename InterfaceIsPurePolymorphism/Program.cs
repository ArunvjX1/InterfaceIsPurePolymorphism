using InterfaceIsPurePolymorphism.com.polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIsPurePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITest it = new inherit();
            it.test();
            it = new next();
            it.test();
            Console.ReadLine();
        }
    }
}
