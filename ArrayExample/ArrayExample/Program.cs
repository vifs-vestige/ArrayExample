using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {            
            //pretty much every array, collections, whatever, in C# are 0 based
            new Array();
            Console.ReadLine();
            MultiDimensionalArray.TwoDArray();
            Console.ReadLine();
            MultiDimensionalArray.ThreeDArray();
            Console.ReadLine();
            MultiDimensionalArray.JaggedArray();
            Console.ReadLine();
            new DynamicArray();
            Console.ReadLine();
        }
    }
}
