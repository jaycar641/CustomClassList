﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomClassList;

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
            CustomList<int> testClass = new CustomList<int>();
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
            CustomList<int> testClass = new CustomList<int>();
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
            CustomList<int> testClass = new CustomList<int>();
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
            CustomList<int> testClass = new CustomList<int>();
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
        public void Remove_Object_DecreasesCount()
        {
            //arrange
            CustomList<int> testClass = new CustomList<int>();
            int test1 = 5;
            //testArray[0] = test1;

            //  int expectedResult = testArray.Length;
            int actualResults = 1;
            int expectedResults = 0;

            //act
            testClass.Remove(test1);
          //  actualResults = testArray.Length;
            //assert
          Assert.AreEqual(actualResults, expectedResults);
        }

        [TestMethod]
        public void Remove_Object_ReturnsTrue()
        {
            int actualResults = 1;
            int expectedResults = 0;
            Assert.AreEqual(actualResults, expectedResults);

        }

        [TestMethod]
        public void Remove_Object_ShiftsArrayElements()
        {
            int actualResults = 1;
            int expectedResults = 0;
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
