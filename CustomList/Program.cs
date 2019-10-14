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
            MyList<bool> mine = new MyList<bool>();
            mine.Add(true);
            //mine.Add(10);
            //mine.Add(12);
            //mine.Add(14);
            //mine.Remove(10);
            Console.WriteLine(mine.ToString() +" " + mine.ToString());
        }
    }
}