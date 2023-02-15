using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace yellow_cheese
{
    internal class Program
    {
        static void addOneToRefParam(ref int i)
        {
            i += 1;
            Console.WriteLine("i is : " + i);
        }
        public static void Main()
        {
            int test = 20;
            addOneToRefParam(ref test);
            Console.WriteLine("test is : " + test);
            Console.ReadLine() ;
        }


    }
}
