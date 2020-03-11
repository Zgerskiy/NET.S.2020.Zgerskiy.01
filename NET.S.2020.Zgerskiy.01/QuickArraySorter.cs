using System;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2020.Zgerskiy._01
{
    public static class QuickArraySorter
    {


        /// <summary>
        /// Searches partition index
        /// </summary>
        /// <param name="array">Array of integers</param>
        /// <param name="startIndex">Start index for partition</param>
        /// <param name="lastIndex">Last index for partition</param>
        /// <returns>Index of partiton</returns>
        static int GetPartitionIndex(int[] array, int startIndex, int lastIndex)
        {
            int pivot = lastIndex - 1;
            for (int i = startIndex; i < lastIndex; i++)
            {
                if (array[i] < array[lastIndex])
                {
                    pivot++;
                    int temp = array[pivot];
                    array[pivot] = array[i];
                    array[pivot] = temp;
                }
            }

            pivot++;
            int temp1 = array[pivot];
            array[pivot] = array[lastIndex];
            array[lastIndex] = temp1;
            return pivot;
        }


        /// <summary>
        /// Sorts array starts from the start index to last index
        /// </summary>
        /// <param name="array">Array of integers</param>
        /// <param name="startIndex">Start index for sorting</param>
        /// <param name="lastIndex">Last index for sorting</param>
        /// <returns></returns>
        static int[] QuickSort(int[] array, int startIndex, int lastIndex)
        {
            int partitionIndex = GetPartitionIndex(array, startIndex, lastIndex);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sort array
        /// </summary>
        /// <param name="array">Array of integers</param>
        /// <returns>Returns sorted array of integers</returns>
        public static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
    }
}
