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
        public void Send_ObjectToString_ReturnsString()
        {
            int actualResults = 1;
            int expectedResults = 0;
            Assert.AreEqual(actualResults, expectedResults);
        }

        [TestMethod]
        public void Send_NoObjectToString_ReturnsNull()
        {
            int actualResults = 1;
            int expectedResults = 0;
            Assert.AreEqual(actualResults, expectedResults);
        }

        [TestMethod]
        public void Send_NullTypeToString_ReturnsNull()
        {
            int actualResults = 1;
            int expectedResults = 0;
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
