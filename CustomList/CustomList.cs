using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassList
{

    /// <summary>
    /// Assignments:
    /// 1. debug the Change replace values test.
    /// 2. finish add function
    /// </summary>
    public class MyList<T>
    {
        //Fields
        private T[] listArray = new T[4];
        private int itemCount = 0;
        private int capacity;
        
        //Constructor/s
        public MyList()
        {
            Capacity = ListArray.Length;

        }


        //INDEXER
        public T this[int index]
        {
            get {


                return listArray[index];
            }
            set {

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
        public void Add(T input)
        {
            if (ItemCount != Capacity)
            {
                listArray[ItemCount] = input;
                ItemCount++;
            }
            else
            {
                    ItemCount++;
                    ChangeCapacity();
            }
        }

        public void Remove(T input)
        {
            if (ListArray.Contains(input))
            {
               
            }

        }

        public void Zip()
        {

        }

        public void ChangeCapacity ()
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
