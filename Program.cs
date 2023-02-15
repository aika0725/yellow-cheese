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
        // out keyword means the parameter has to be modified in the method. However, we can not use it. like using i+=1
        static void addOneToRefParam(out int i)
        {
            i =1;
            Console.WriteLine("i is : " + i);
        }
        public static void Main()
        {
            int test = 20;
            addOneToRefParam(out test);
            
            Console.WriteLine("test is : " + test);
            Console.ReadLine() ;
        }


    }
}
