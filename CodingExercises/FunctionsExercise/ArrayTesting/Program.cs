using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTesting
{
    class Program
    {
        static string myName;
        static void MyPrinter(string _var)
        {
            Console.WriteLine(_var);
        }

        static void Main(string[] args)
        {
            string temp;
            Example ex = new Example();
            MyPrinter("Hello World");
            //temp = ex.myFax("test");
            Console.ReadKey();
        }
    }
}
