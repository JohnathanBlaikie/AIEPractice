using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet
{
    class Program
    {
        
        //public void ListExample()
        //{
        //    List<int> myList = new List<int>();
        //    myList.Add(10); myList.Add(1);
        //    foreach (int item in myList)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        static void Main(string[] args)
        {
            int uInt;
            int.TryParse(Console.ReadLine(), out uInt);
            ArrayExample(uInt);
            void ArrayExample(int size)
            {

                int[] array = new int[size];
                foreach (int i in array)
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.ReadKey();
        }
        
    }
}
