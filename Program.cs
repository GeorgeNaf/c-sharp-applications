using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // How to fill an array way 1
            string[] strings1 = new string[2];
            strings1[0] = "strA";
            strings1[1] = "strB";
            int[] integers1 = new int[2];
            integers1[0] = 1;
            integers1[1] = 2;
            double[] doubles1 = new double[2];
            doubles1[0] = 3.4;
            doubles1[1] = 5.6;
            bool[] booleans1 = new bool[2];
            booleans1[0] = true;
            booleans1[1] = false;

            // How to fill an array way 2
            string[] strings2 = new string[5] { "strA", "strB", "strC", "strD", "strE" };
            int[] integers2 = new int[5] { 1, 2, 3, 4, 5 };
            double[] doubles2 = new double[5] { 3.5, 2.8, 1.7, 3.4, 6.7 };
            bool[] booleans2 = new bool[5] { true, false, true, true, false };

            // How to print an element of array. Try the same pattern on all
            Console.WriteLine(strings1[1]);
        }
    }
}
