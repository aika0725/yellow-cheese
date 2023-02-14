using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yellow_cheese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string i = "33";
            double f = 1234.56789;
            Console.WriteLine("i: {0,10:0.0} f: {1,15:0.00}", i, f);
            Console.WriteLine("i: {0,10:0.0} f: {1,15:0.00}", 0, 0);


            Console.WriteLine("i: {0,10:0} f: {1,10:0.00}", i, f);
            Console.WriteLine("i: {0,10:0} f: {1,10:0.00}", 0, 0);

            Console.WriteLine("i: {0,-6:0} f: {1,-10:0.00}", i, f);
            Console.WriteLine("i: {0,10:0} f: {1,-10:0.00}", 0, 0);
            Console.ReadKey();


    }
}
}
