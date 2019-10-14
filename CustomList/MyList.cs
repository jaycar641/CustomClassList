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
                
                             
                yield return ListArray[i];


            }

        }
        public void Add(T input)
        {
            CheckCapacity(input);
           
        }

        public void Remove(T input)
        {

            IEnumerator enumerator = GetEnumerator();


            enumerator.MoveNext();

            
                for (int i = 0; i <= ItemCount - 1; i++)
                {

                    if (enumerator.Current.Equals(input))
                    {
                        int tempItemCount;

                        int remain = (ItemCount - 1) - i;

                        T[] listArrayReplace = new T[ListArray.Length];

                        for (int j = 0; j < ListArray.Length; j++)
                        {
                            listArrayReplace[j] = ListArray[j];
                            ListArray[j] = default;

                        }
                    ItemCount = 0;
                        Capacity = 4;

                        for (int j = 0; j < listArrayReplace.Length; j++)
                        {
                           
                            if (j == i)
                            {
                                continue;
                            }
                            else
                            {
                               
                                    Add(listArrayReplace[j]);   
                            }

                        } 
                                       


                    }

                    enumerator.MoveNext();

                
            }


            
        }

        public void CheckCapacity(T input)
        {
            if (ItemCount != Capacity)
            {
                ListArray[ItemCount] = input;
                ItemCount++;
            }
            else
            {
                ChangeCapacity();
                ListArray[ItemCount] = input;
                ItemCount++;
            }

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