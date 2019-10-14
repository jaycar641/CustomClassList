using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomCLassList;

namespace ListTest
{
    [TestClass]
    public class UnitTest1
    {
       


        [TestMethod]
        public void Add_Object_CountIncreases()
        {
            //arrange
            MyList<int> testClass = new MyList<int>();
            
            int test1 = 5;
            int expectedResult = 1;
            int actualResults;

            //act
            testClass.Add(test1);
            actualResults = testClass.ItemCount;
            //assert
            Assert.AreEqual(actualResults, expectedResult);
        }

        [TestMethod]
        public void Add_Object_ListReturnsValue()
        {
            //arrange
            MyList<int> testClass = new MyList<int>();
            int test1 = 5;
            int expectedResult = test1;
            int actualResults;

            //act
            testClass.Add(test1);
            actualResults = testClass.ListArray[0];
            //assert
            Assert.AreEqual(actualResults, expectedResult);
        }

        [TestMethod]
        public void Add_Object_AddedAtNewIndex()
        {
            //arrange
            MyList<int> testClass = new MyList<int>();
            int test1 = 5;
            int test2 = 3;
            int testindex = 1;

            int expectedResult = test2;
            int actualResults;

            //act
            testClass.Add(test1);
            testClass.Add(test2);
            actualResults = testClass[1];
            //assert
            Assert.AreEqual(actualResults, expectedResult);
        }


        [TestMethod]
        public void Add_ObjectCountIsEqualCapacity_ReturnsNewCapacity()
        {
            //arrange
            MyList<int> testClass = new MyList<int>();
            int expectedResults = 8;
            int actualResults;


            //act
            testClass.Add(4);
            testClass.Add(4);
            testClass.Add(4);
            testClass.Add(4);
            testClass.Add(4);
            actualResults = testClass.Capacity;

            //assert
            Assert.AreEqual(actualResults, expectedResults);
        }


             [TestMethod]
        public void Add_ObjectCountIsEqualCapacity_ValuesInOldArrayReturnsInNewArray()
        {
            //arrange
            MyList<int> testClass = new MyList<int>();
            int test1 = 16;
            int expectedResults = test1;
            int actualResults;

            //act
            testClass.Add(4);
            testClass.Add(8);
            testClass.Add(12);
            testClass.Add(test1);
            testClass.Add(20);
            testClass.Add(24);


            actualResults = testClass.ListArray[3];

            //assert
            Assert.AreEqual(actualResults, expectedResults);
        }


        [TestMethod]
        public void Remove_Object_ObjectRemovedFromIndex()
        {

            //arrange
            MyList<int> testClass = new MyList<int>();

            testClass.Add(5);
            testClass.Add(4);
            testClass.Add(6);
            int actualResults;
            int expectedResults = 0;

            //act
           
            testClass.Remove(6);
            actualResults = testClass.ListArray[2];

            //assert
           Assert.AreEqual(actualResults, expectedResults);
        }
      
        [TestMethod]
        public void Remove_Object_ShiftsArrayElements()
        {
            //arrange
            MyList<int> testClass = new MyList<int>();

            testClass.Add(5);
            testClass.Add(4);
            testClass.Add(6);
            int expectedResults = 6;
            int actualResults;

            //act
            testClass.Remove(4);
            actualResults = testClass.ListArray[1];
            
            //assert

            Assert.AreEqual(actualResults, expectedResults);
        }

        [TestMethod]
        public void Remove_Object_ReturnsNewCount()
        {
            //arrange
            MyList<int> testClass = new MyList<int>();
            testClass.Add(5);
            testClass.Add(4);
            testClass.Add(6);
            int actualResults;
            int expectedResults = 2;

            //act
            testClass.Remove(4);
            actualResults = testClass.ItemCount;
            //assert
            Assert.AreEqual(actualResults, expectedResults);

        }

        [TestMethod]
        public void Remove_CounterLessThanCounterThreshold_DecrementsCapacity()
        {
            //act
            MyList<int> testClass = new MyList<int>();
            testClass.Add(5);
            testClass.Add(4);
            testClass.Add(6);
            testClass.Add(10);
            testClass.Add(15);
            int actualResults;
            int expectedResults = 4;

            //arrange
            testClass.Remove(15);
            actualResults = testClass.Capacity;

            //assert

            Assert.AreEqual(actualResults, expectedResults);
        }


        [TestMethod]
        public void Send_ObjectToString_ReturnsStringsInOrder()
        {
            //act
            MyList<int> testList = new MyList<int>();

            testList.Add(10);
            testList.Add(20);
            testList.Add(30);
            testList.Add(40);
            testList.Add(50);
            string expectedResults = "10, 20, 30, 40, 50";
            string actualResults;
            
            //arrange
            actualResults = testList.ToString();

            //assert

            Assert.AreEqual(actualResults, expectedResults);
        }

        [TestMethod]
        public void Send_ObjectToString_ReturnsJoinedPhroases()
        {
            //arrange
            MyList<int> testList = new MyList<int>();
            testList.Add(5);
            int test = testList[0];
            string expectedResults = Convert.ToString(test) + " " + Convert.ToString(test);

            //act
            string actualResults = testList.ToString() + " " + testList.ToString();

            //assign
            Assert.AreEqual(actualResults, expectedResults);
        }

        [TestMethod]
        public void Send_ObjectToString_CanBePassedAsAnArgument()
        {
            //arrange
            MyList<int> testList = new MyList<int>();
            int test1 = 5;
            testList.Add(5);
            string expectedResults = Convert.ToString(test1);
            string actualResults;

            //act
            MyList<string> testList2 = new MyList<string>();
            testList2.Add(testList.ToString());
            actualResults = testList2[0];
            //assign
            Assert.AreEqual(actualResults, expectedResults);
        }



        public void Zip_BothObjects_ReturnsAllElements ()
        {
            MyList<int> testList = new MyList<int>();
            MyList<int> testList2 = new MyList<int>();

            testList.Add(0);
            testList.Add(2);
            testList.Add(4);
            testList.Add(6);
            testList.Add(8);
            testList.Add(10);
            testList2.Add(1);
            testList2.Add(3);
            testList2.Add(5);
            testList2.Add(7);
            testList2.Add(9);
            int[] actualResults;
            int[] expectedResults = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            testList.Zip(testList, testList2);
            actualResults = testList.ListArray;
            Assert.AreEqual(actualResults, expectedResults);

        }

        public void Zip_BothObjects_IncreaseCount ()
        {
            MyList<int> testList = new MyList<int>();
            MyList<int> testList2 = new MyList<int>();

            testList.Add(0);
            testList.Add(2);
            testList.Add(4);
            testList.Add(6);
            testList.Add(8);
            testList.Add(10);
            testList2.Add(1);
            testList2.Add(3);
            testList2.Add(5);
            testList2.Add(7);
            testList2.Add(9);
            int actualResults;
            int expectedResults = 11;

            testList.Zip(testList, testList2);
            actualResults = testList.ItemCount;

            Assert.AreEqual(actualResults, expectedResults);


        }

        public void Zip_BothObjects_IncreaseCapacity ()
        {
            MyList<int> testList = new MyList<int>();
            MyList<int> testList2 = new MyList<int>();

            testList.Add(0);
            testList.Add(2);
            testList.Add(4);
            testList.Add(6);
            testList.Add(8);
            testList.Add(10);
            testList2.Add(1);
            testList2.Add(3);
            testList2.Add(5);
            testList2.Add(7);
            testList2.Add(9);
            int actualResults;
            int expectedResults = 12;

            testList.Zip(testList, testList2);
            actualResults = testList.Capacity;

            Assert.AreEqual(actualResults, expectedResults);


        }







        public void Index_SelectIndex_SetsIndex()
        {
            int actualResults = 1;
            int expectedResults = 0;
            Assert.AreEqual(actualResults, expectedResults);
        }

        public void Index_SelectIndex_GetsIndex()
        {
            int actualResults = 1;
            int expectedResults = 0;
            Assert.AreEqual(actualResults, expectedResults);
        }

        public void Index_SelectIndex_ReturnIndex()
        {
            int actualResults = 1;
            int expectedResults = 0;
            Assert.AreEqual(actualResults, expectedResults);
        }

        public void Index_SelectIndex_ReturnsIndexOutOfRangeException()
        {
            int actualResults = 1;
            int expectedResults = 0;
            Assert.AreEqual(actualResults, expectedResults);
        }







    }
}
