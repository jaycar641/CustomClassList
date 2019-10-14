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
            MyList<int> mylist = new MyList<int>();
            MyList<int> mylist2 = new MyList<int>();

            mylist.Add(5);
            mylist.Add(10);
            mylist2.Add(5);
            mylist2.Add(10);

            Console.WriteLine(mylist + mylist2);

            Console.ReadLine();


        }
    }
}