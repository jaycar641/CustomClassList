using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassList
{
    public class CustomList<T>
    {
        //Fields
        private T[] listArray = new T[4];
        private int itemCount = 0;
        private int capacity;
        
        //Constructor/s
        public CustomList()
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
                if (ItemCount == Capacity)
                {
                    Capacity += 4;
                }
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

        public void CheckCapacity ()
        {
            
                   // T[] listArrayReplace = new T[ListArray.Length + 4];
                    
                   // ListArray = null;
                  
                  //  ListArray = listArrayReplace;

        }

            

    }



       

    
}
