using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCLassList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mine = new MyList<int>();
            mine.Add(5);

            Console.WriteLine(mine);
            Console.ReadLine();

            foreach (int test in mine)
            {
                Console.WriteLine(test);

            }
            Console.ReadLine();
        }
    }
}