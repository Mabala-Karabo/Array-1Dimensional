using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1Dimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] LuckyNumbers = { 1, 2, 5, 9, 7, 8, 10, 11, 12 };
            Console.WriteLine(LuckyNumbers.Length);
            Console.WriteLine(LuckyNumbers[0]);
            Console.WriteLine("The maximum number in Lucky numbers array is " + LuckyNumbers.Max());

            string[] friends = new string[5];// creating a new array which is gonna hold 5 elements
            friends[0] = "Karabo";
            friends[1] = "Peter";
            friends[4] = "John";
            Console.WriteLine("for now friend number1 is " + friends[1]);
            friends[1] = Console.ReadLine();
            Console.WriteLine("Now after updating friend number one is " + friends[1]);
            Console.ReadLine();
        }
    }
}
