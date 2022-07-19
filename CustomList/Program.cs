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


            mylist.Add(5);
            mylist.Add(10);
            mylist.Add(15);
            mylist.Add(20);
            mylist.Add(25);
            mylist.Remove(15);
            mylist.Remove(10);

                foreach(int numVar in mylist) {
                Console.WriteLine(numVar);
                Console.WriteLine("Capacity " + mylist.Capacity + "ItemCount" + mylist.ItemCount);
                Console.ReadLine();
                }



        }
    }
}