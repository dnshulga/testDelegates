using System;

namespace TestDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b1 = new Base();
            b1.Name = "DimaShulga";
            Print p = testOfDelegate;
            b1.Output(b1.Name, p);
        }

        static void testOfDelegate(string arg)
        {
            Console.WriteLine(arg + " is using the Delegate method");
        }
    }
}
