//***************************************************************************************
//                          Written By Mike Valchera
//***************************************************************************************

using System;
using NumberSorter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test.NumberSorter
{
    [TestClass]
    public class NumberSorterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NumberSorter_SortHighToLow_ThrowsArgumentNullException()
        {
            //  Assign
            Sorter sorter = new Sorter();

            //  Act
            sorter.SortHighToLow(null);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NumberSorter_SortHighToLow_ThrowsArgumentException()
        {
            //  Assign
            Sorter sorter = new Sorter();

            //  Act
            sorter.SortHighToLow("TextIsNotAllowed");

        }

        [TestMethod]
        public void NumberSorter_SortHighToLow_ReturnsValue()
        {
            //  Assign
            Sorter sorter1 = new Sorter();
            Sorter sorter2 = new Sorter();

            List<int> expected1 = new List<int> { 5, 4, 4, 2, 1 };
            List<int> expected2 = new List<int> { 6, 5, 4, 3, 2, 1 };

            //  Act
            List<int> result1 = sorter1.SortHighToLow(TestValue1);
            List<int> result2 = sorter2.SortHighToLow(TestValue2);

            //  Assert
            for(int i = 0; i < expected1.Count; i++)
            {
                Assert.AreEqual(expected1[i], result1[i]);
            }

            for (int i = 0; i < expected2.Count; i++)
            {
                Assert.AreEqual(expected2[i], result2[i]);
            }
        }

        private const string TestValue1 = "21445";
        private const string TestValue2 = "145263";

    }
}
