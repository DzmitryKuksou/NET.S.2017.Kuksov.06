using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortOfArray
{
    /// <summary>
    /// delegate of compare
    /// </summary>
    /// <param name="lhs">first array</param>
    /// <param name="rhs">second array</param>
    /// <returns>number</returns>
    public delegate int Compare(int[] lhs, int[] rhs);
    /// <summary>
    /// class BubbleSort of array
    /// </summary>
    public static class BubbleSortArray
    {
        #region BubbleSort
        /// <summary>
        /// BubbleSort
        /// </summary>
        /// <param name="array">array with 2 measure</param>
        public static void BubbleSort(int[][] array, string namefunc)
        {

            /* Console.WriteLine("Enter: maxI, minI,...");
             switch (namefunc)
             {
                 case "maxI":
                     compare = new Compare (ByMaxElementIncrement);
                     break;
                 case "sumI":
                     compare = BySumOfArrayIncrement;
                     break;
                 case "minI":
                     compare = ByMinElementIncrement;
                     break;
                 case "maxD":
                     compare = ByMaxElementDecrease;
                     break;
                 case "sumD":
                     compare = BySumOfArrayDecrease;
                     break;
                 case "minD":
                     compare = ByMinElementDecrease;
                     break;
                 default:
                     Console.WriteLine("Default case");
                     break;
             }*/
            Compare compare = BySumOfArrayIncrement;
            for (int i = 0; i < array.Length; i++) 
            {
                for(int j = 0; i < array.Length - 1 - i; i++)
                {
                    if (compare(array[j], array[j + 1]) > 0) Swap(ref array[j], ref array[j+1]);  
                }
            }
        }
        #endregion

        #region IncrementOrDecrease
        /// <summary>
        /// sum of array Increment
        /// </summary>
        /// <param name="lhs">first array</param>
        /// <param name="rhs">second array</param>
        /// <returns>number</returns>
        private static int BySumOfArrayIncrement(int[] lhs, int[] rhs) => SumOfArray(lhs) - SumOfArray(rhs);
        /// <summary>
        /// sum of array Increment
        /// </summary>
        /// <param name="lhs">first array</param>
        /// <param name="rhs">second array</param>
        /// <returns>number</returns>
        private static int ByMinElementIncrement(int[] lhs, int[] rhs) => FindMinElement(lhs) - FindMinElement(rhs);
        /// <summary>
        /// Max Element Increment
        /// </summary>
        /// <param name="lhs">first array</param>
        /// <param name="rhs">second array</param>
        /// <returns>number</returns>
        private static int ByMaxElementIncrement(int[] lhs, int[] rhs) => FindMaxElement(lhs) - FindMaxElement(rhs);
        /// <summary>
        /// sum of array decrease
        /// </summary>
        /// <param name="lhs">first array</param>
        /// <param name="rhs">second array</param>
        /// <returns>number</returns>
        private static int BySumOfArrayDecrease(int[] lhs, int[] rhs) => -SumOfArray(lhs) + SumOfArray(rhs);
        /// <summary>
        /// Min Elemen Decrease
        /// </summary>
        /// <param name="lhs">first array</param>
        /// <param name="rhs">second array</param>
        /// <returns>number</returns>
        private static int ByMinElementDecrease(int[] lhs, int[] rhs) => -FindMinElement(lhs) + FindMinElement(rhs);
        /// <summary>
        /// Max Element Decrease
        /// </summary>
        /// <param name="lhs">first array</param>
        /// <param name="rhs">second array</param>
        /// <returns>number</returns>
        private static int ByMaxElementDecrease(int[] lhs, int[] rhs) => -FindMaxElement(lhs) + FindMaxElement(rhs);
        #endregion

        #region AditionMethod
        /// <summary>
        /// sum of array
        /// </summary>
        /// <param name="arr">array</param>
        /// <returns>number</returns>
        private static int SumOfArray(int[] arr)
        {
            int sum = 0;
            foreach (int el in arr)
                sum += el;
            return sum;
        }
        /// <summary>
        /// Max Element
        /// </summary>
        /// <param name="arr">array</param>
        /// <returns>number</returns>
        private static int FindMaxElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (max < arr[i]) max = arr[i];
            return max;
        }
        /// <summary>
        /// Min Element
        /// </summary>
        /// <param name="arr">array</param>
        /// <returns>number</returns>
        private static int FindMinElement(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (min > arr[i]) min = arr[i];
            return min;
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
        #endregion
    }
}
