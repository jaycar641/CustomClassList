using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCLassList
{
    public class MyList<T> : IEnumerable
    {

        /// <summary>
        /// Assignments:
        /// 1. debug the Change replace values test.
        /// 2. finish add function
        /// </summary>

        //Fields
        private T[] listArray = new T[4];
        private int itemCount = 0;
        private int capacity;
        private T userInput;
        private T[] test = new T[4];


        //Constructor/s
        public void myList()
        {
            Capacity = ListArray.Length;
            

        }


        ////INDEXER
        public T this[int index]
        {
            get
            {
                return listArray[index];
            }
            set
            {

                value = listArray[index];
            }
        }

        //Properties

        public T[] ListArray
        {
            get
            {
                return listArray;
            }

            set
            {
                listArray = value;
            }

        }

        public int ItemCount
        {
            get
            {
                return itemCount;
            }

            set
            {
                itemCount = value;
            }

        }

        public T GetUserInput
        {
            get
            {
                return userInput;
            }

            set
            {
                userInput = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }


        }



        //Functions

        public IEnumerator GetEnumerator()
        {

            for (int i = 0; i <= ItemCount-1; i++)
            {
                
                test[i] = ListArray[i];
                             
                yield return ListArray[i];


            }

        }
        public void Add(T input)
        {
            if (ItemCount != Capacity)
            {
                listArray[ItemCount] = input;
                ItemCount++;
            }
            else
            {
                ChangeCapacity();
                ListArray[ItemCount] = input;
                ItemCount++;


            }
        }

        public void Remove (T input) 
        {

            IEnumerator enumerator = GetEnumerator();

            int[] tesdt = new int[4];
            tesdt[1] = 10;
          
            while (!tesdt[1].Equals(input)) //when input = 10 end loop
            {
               //add++;

                //  for (int i = 0; i <= ItemCount - 1; i++)
                //   {
                enumerator.MoveNext();


                //  }

                //(deleteObject == true)
           }
            tesdt[1] = default;
           // test[test.Length - 1] = default;
            Console.ReadLine();


        }


        public override string ToString()
        {
            // add indexer
            string arrayHolder = "";
            for (int i = 0; i < ItemCount - 1; i++)
            {
                arrayHolder += ListArray[i] + ", ";

            }
            arrayHolder += ListArray[ItemCount - 1];

            Console.WriteLine(arrayHolder);

            return arrayHolder;
        }





        public void Zip() //where T lists objects can be passed through with 2 parameters constraints
        {

        }

        public void ChangeCapacity()
        {
            Capacity += 4;
            T[] listArrayReplace = new T[ListArray.Length + 4];

            for (int i = 0; i < ListArray.Length; i++)
            {
                listArrayReplace[i] = ListArray[i];
            }
            ListArray = null;
            ListArray = listArrayReplace;

        }


    }
}