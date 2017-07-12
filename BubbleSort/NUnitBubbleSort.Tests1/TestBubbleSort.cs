using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BubbleSortOfArray;

namespace NUnitBubbleSort.Tests1
{
    [TestFixture]
    public class TestBubbleSort
    {    
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3, 3 }, new int[] { 0, 0, 0 }, ExpectedResult = true)]
        public bool Test_BubbleSort(params int[][] array)
        {
            ICompare refe = new ByMinElementIncrement();
            BubbleSortArray.BubbleSort(array, refe);
            int[,] myArr = { { 0, 0, 0 }, { 1, 2, 3 }, { 2, 3, 3 } };
            return Array.Equals(array, myArr);
        }
    }
    class BySumOfArrayIncrement : ICompare
    {
        public int CompareTo(int[] lhs, int[] rhs)=>lhs.Sum() - rhs.Sum();
    }
    class ByMinElementIncrement : ICompare
    {
        public int CompareTo(int[] lhs, int[] rhs) => lhs.Min() - rhs.Min();
    }
    class ByMaxElementIncrement : ICompare
    {
        public int CompareTo(int[] lhs, int[] rhs) => lhs.Max() - rhs.Max();
    }
    class BySumOfArrayDecrease : ICompare
    {
        public int CompareTo(int[] lhs, int[] rhs) => -lhs.Sum() + rhs.Sum();
    }
    class ByMaxElementDecrease : ICompare
    {
        public int CompareTo(int[] lhs, int[] rhs) => -lhs.Max() + rhs.Max();
    }
    class ByMinElementDecrease : ICompare
    {
        public int CompareTo(int[] lhs, int[] rhs) => lhs.Min() - rhs.Min();
    }

}
