using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortOfArray
{
    /// <summary>
    /// 
    /// </summary>
    public delegate int delegateCompareTo(int[] lhs, int[] rhs);
    /// <summary>
    /// interface provides method for compare two array
    /// </summary>
    public interface ICompare
    {
        int CompareTo(int[] lhs, int[] rhs);
    }
    /// <summary>
    /// class BubbleSort of array
    /// </summary>
    public static class BubbleSortArray
    {
        /// <summary>
        /// BubbleSort
        /// </summary>
        /// <param name="array">array with 2 measure</param>
        public static void BubbleSort(int[][] array, ICompare compare)
        {
            for (int i = 0; i < array.Length - 1; i++) 
            {
                for(int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (compare.CompareTo(array[j], array[j + 1]) > 0) Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
        public static void BubbleSort(int[][] array, delegateCompareTo compare)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (compare.Invoke(array[j], array[j + 1]) > 0) Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
        /// <summary>
        /// swap of array
        /// </summary>
        /// <param name="a">first array</param>
        /// <param name="b">second array</param>
        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] t = a;
            a = b;
            b = t;
        }
    }
}
