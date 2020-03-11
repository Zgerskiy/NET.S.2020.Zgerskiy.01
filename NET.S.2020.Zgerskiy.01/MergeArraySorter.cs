using System;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2020.Zgerskiy._01
{
    class MergeArraySorter
    {

        /// <summary>
        /// Sorting array
        /// </summary>
        /// <param name="array">Array for </param>
        /// <param name="startIndex">First index of the first array</param>
        /// <param name="middleIndex">Last index of the first array</param>
        /// <param name="lastIndex">Last index of the second array</param>
        static void MergeArrays(int[] array,int startIndex, int middleIndex, int lastIndex)
        {
            //temp array 
            int[] newArray = new int[lastIndex - startIndex+1];
            int index = -1;


            //current indexes of arrays
            int leftIndex = startIndex;
            int rightIndex = middleIndex + 1;
           
            //copy minimal values until one of the arrays end 
            while(leftIndex<=middleIndex && rightIndex<=lastIndex)
            {
                if (array[leftIndex]<array[rightIndex])
                {
                    index++;
                    newArray[index] = array[leftIndex];
                    leftIndex++;
                }
                else
                {
                    index++;
                    newArray[index] = array[rightIndex];
                    rightIndex++;
                }
            }

            //copy remaining values in left part
            for (int i =leftIndex;i<=middleIndex;i++)
            {
                index++;
                newArray[index] = array[i];
            }

            //copy remaining values in right part
            for (int j = rightIndex; j <= lastIndex; j++)
            {
                index++;
                newArray[index] = array[j];
            }

            //overwrite main array  
            Array.Copy(newArray, 0, array, startIndex, newArray.Length);
        }

        /// <summary>
        /// Sorts array starts from the start index to last index
        /// </summary>
        /// <param name="array">Array of integers</param>
        /// <param name="startIndex">Start index for sorting</param>
        /// <param name="lastIndex">Last index for sorting</param>
        /// <returns>Returns sorted array of integers</returns>
        static int[] MergeSort(int[] array,int startIndex,int lastIndex)
        {
            if (startIndex<lastIndex)
            {
                int midIndex = (lastIndex + startIndex) / 2;
                
                MergeSort(array, startIndex, midIndex);
                MergeSort(array, midIndex + 1, lastIndex);
                MergeArrays(array, startIndex, midIndex, lastIndex);
            }            
            
            return array;
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
