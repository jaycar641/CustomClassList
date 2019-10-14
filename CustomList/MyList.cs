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
        private T[] listArray = new T[4];
        private int itemCount = 0;
        private int capacity;
        private T userInput;
        private T[] test = new T[4];

        public void myList()
        {
            Capacity = ListArray.Length;

        }

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


        public IEnumerator GetEnumerator()
        {

            for (int i = 0; i <= ItemCount-1; i++)
            {
                
                test[i] = ListArray[i];
                             
                yield return ListArray[i];
            }

        }

        public IEnumerator altEnumerator()
        {
            for (int i = 0; i <= ItemCount-1; i++)
            {
                yield return ListArray[i];
               
            }
        }
        public void Add(T input)
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

        public void Remove(T input)
        {

            IEnumerator enumerator = GetEnumerator();
            enumerator.MoveNext();

                for (int i = 0; i <= ItemCount - 1; i++)
                {

                    if (enumerator.Current.Equals(input))
                    {
                        T[] listArrayReplace = new T[8];

                        for (int j = 0; j < ListArray.Length; j++)
                        {
                            listArrayReplace[j] = ListArray[j];
                            ListArray[j] = default;
                        }
                        ItemCount = 0;
                        Capacity = 0;

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

        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2) //check count and capacity for every function
        {
            MyList<T> mylist = new MyList<T>();

            for (int i = 0; i < list1.ListArray.Length; i++)
            {
                mylist.Add(list1[i]);
            }
            for (int i = 0; i < list2.ListArray.Length; i++)
            {
                mylist.Add(list2[i]);
            }

            return mylist;
        }

        public static MyList<T> operator -(MyList<T> list1, MyList<T> list2) //check count and capacity for every function
        {
            MyList<T> mylist = new MyList<T>();

            for (int i = 0; i < list1.ListArray.Length; i++)
            {

                mylist.Add(list1[i]);

            }


            return mylist;
        }

        public void Zip(MyList<T> listOne, MyList<T> listTwo) //where T lists objects can be passed through with 2 parameters constraints
        {

            MyList<T> tempList = new MyList<T>();
            ItemCount = 0;
            Capacity = 0;

            for (int j = 0; j < listOne.ListArray.Length; j++)
            {
                tempList.Add(listOne.ListArray[j]);
                tempList.Add(listTwo.ListArray[j]);

            }
            ListArray = tempList.ListArray;
        }
        public override string ToString()
        {
            // add indexer
            string arrayHolder = "";
            if (ItemCount == 0)
            {
                string mess = "Does not have any values";
                return mess;
            }
            for (int i = 0; i < ItemCount - 1; i++)
            {
                arrayHolder += ListArray[i] + ", ";

            }
            arrayHolder += ListArray[ItemCount - 1];

            Console.WriteLine(arrayHolder);

            return arrayHolder;
        }

        public void ChangeCapacity()
        {
            T[] listArrayReplace = new T[ListArray.Length + 4];

            for (int i = 0; i < ListArray.Length; i++)
            {
                listArrayReplace[i] = ListArray[i];
            }
            ListArray = null;
            ListArray = listArrayReplace;
            Capacity = ListArray.Length;
        }


    }
}