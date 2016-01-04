using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class TableTests
    {
        [TestMethod()]
        public void CreateGroupsTest_UnknownName_AnySize()
        {
            // arrange
            Table table = new Table();
            table.SetSellPrices(new List<int> { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 });
            List<int> expected = new List<int>();
            // act
            List<int> actual = table.CreateGroups("SellPrice", 10);
            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CreateGroupsTest_Cost_3()
        {
            // arrange
            Table table = new Table();
            table.SetCosts(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
            List<int> expected = new List<int> { 6, 15, 24, 21 };
            // act
            List<int> actual = table.CreateGroups("Cost", 3);
            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CreateGroupsTest_Revenue_4()
        {
            // arrange
            Table table = new Table();
            table.SetRevenues(new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 });
            List<int> expected = new List<int> { 50, 66, 60 };
            // act
            List<int> actual = table.CreateGroups("Revenue", 4);
            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
