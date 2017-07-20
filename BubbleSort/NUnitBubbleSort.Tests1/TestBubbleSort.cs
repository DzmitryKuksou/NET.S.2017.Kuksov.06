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
        public bool Test_BubbleSort_interfaces(params int[][] array)
        {
            BubbleSortArray.BubbleSort(array, new delegateCompareTo(new BySumOfArrayIncrement().CompareTo));
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Sum() > array[i + 1].Sum()) return false;
            }
            return true;
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3, 3 }, new int[] { 0, 0 }, new int[] { 6 }, ExpectedResult = true)]
        public bool Test_BubbleSort_delegate(params int[][] array)
        {
            BubbleSortArray.BubbleSort(array, new BySumOfArrayIncrement().CompareTo);
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Sum() > array[i + 1].Sum()) return false;
            }
            return true;
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
        public int CompareTo(int[] lhs, int[] rhs) => -lhs.Min() + rhs.Min();
    }

}
