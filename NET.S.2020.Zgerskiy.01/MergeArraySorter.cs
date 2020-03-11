using System;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2020.Zgerskiy._01
{
    class MergeArraySorter
    {

       

        /// <summary>
        /// Sorts array starts from the start index to last index
        /// </summary>
        /// <param name="array">Array of integers</param>
        /// <param name="startIndex">Start index for sorting</param>
        /// <param name="lastIndex">Last index for sorting</param>
        /// <returns>Returns sorted array of integers</returns>
        static int[] MergeSort(int[] array,int startIndex,int lastIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sort array
        /// </summary>
        /// <param name="array">Array of integers</param>
        /// <returns>Returns sorted array of integers</returns>
        public static int[] MergeSort(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }
    }
}
