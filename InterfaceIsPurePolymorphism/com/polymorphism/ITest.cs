using InterfaceIsPurePolymorphism.com.polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIsPurePolymorphism.com.polymorphism
{
    interface ITest
    {
       void test();
        
    }
}

class inherit: ITest
{
    public void test()
    {
        Console.WriteLine("Inheriting");
    }
}

class next: ITest
{
    public void test()
    {
        Console.WriteLine("hello");
    }
}