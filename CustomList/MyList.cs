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

        public MyList()
        {
            Capacity = ListArray.Length;

            
        }

        public T this[int index] /// this gets and sets values using the index
        {
            get
            {
                return listArray[index];
            }
            set
            {
                
                listArray[index] = value;
                    
            }
        }

        public T[] ListArray //this is returning the entire array
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
                       // ItemCount = 0;
                        //Capacity = 0;

                int index;
            IEnumerator enumerator = GetEnumerator();
                enumerator.MoveNext();

                while(!enumerator.Current.Equals(input))
                {
                    enumerator.MoveNext();
                }

                     //the item that is to be removed
                  index = Array.IndexOf(listArray, enumerator.Current); //the index of the removed item
                    //1914 n prospect embassy apartments 2nd of 414305

                        MyList<T> listArrayReplace = new MyList<T>();
                            
                            int arrayOne = index; // 2
                            int arrayTwo = ListArray.Length; //5-2= 2
                        for (int j = 0; j < arrayOne; j++) //the first half, index is 2, this is where it stops
                        {
                            
                             // 0, 1, the index of the item being removed will not be in the array
                                        listArrayReplace.Add(ListArray[j]);
                                        
                        
                        }

                        for(int k = index+1; k < arrayTwo; k++)//
                        {
                       //  2 3 4 5
                        listArrayReplace.Add(ListArray[k]); //at the index where the old value was the next value is placed

                        }    


                        ListArray = listArrayReplace.ListArray;

                        ////The capacitys and Item count have to be the same factor of 4
                        if(listArrayReplace.Capacity == ListArray.Capacity) {


                        }
///listreplace 0;5. 1:10;;; 2:20 3:25:
//// 5, 10 15 20 25
                    

            
            
        }

        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2) //check count and capacity for every function
        {
            MyList<T> mylist = new MyList<T>();

            for (int i = 0; i < list1.ItemCount; i++)
            {
                mylist.Add(list1[i]);
            }
            for (int i = 0; i < list2.ItemCount; i++)
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