using System;
using System.Collections;
using System.Linq;

namespace NET.S._2020.Zgerskiy._01
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Task is done when all test cases are correct:");

			int testCaseNumber = 1;

			Console.WriteLine("\tTesting merge sort:");

			TestMergeSort(testCaseNumber++, new int[] { 2, 4, 9, 3, 6, 0, 1, 56 }, new int[] { 0, 1, 2, 3, 4, 6, 9, 56 });
			TestMergeSort(testCaseNumber++, new int[] { 3, 17, 47, 5, 2, 0, 4 }, new int[] { 0, 2, 3, 4, 5, 17, 47 });
			TestMergeSort(testCaseNumber++, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
			TestMergeSort(testCaseNumber++, new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 });
			TestMergeSort(testCaseNumber++, new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 });
			TestMergeSort(testCaseNumber++, new int[] { }, new int[] { });

			Console.WriteLine("\tTesting quick sort:");

			TestQuickSort(testCaseNumber++, new int[] { 2, 4, 9, 3, 6, 0, 1, 56 }, new int[] { 0, 1, 2, 3, 4, 6, 9, 56 });
			TestQuickSort(testCaseNumber++, new int[] { 3, 17, 47, 5, 2, 0, 4 }, new int[] { 0, 2, 3, 4, 5, 17, 47 });
			TestQuickSort(testCaseNumber++, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
			TestQuickSort(testCaseNumber++, new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 });
			TestQuickSort(testCaseNumber++, new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 });
			TestMergeSort(testCaseNumber++, new int[] { }, new int[] { });

			if (correctTestCaseAmount == testCaseNumber - 1)
			{
				Console.WriteLine("Task is done.");
			}
			else
			{
				Console.WriteLine("TASK IS NOT DONE.");
			}
		}

		private static void TestMergeSort(int testCaseNumber, int[] array, int[] expectedArray)
		{
			try
			{
				int[] resultArray = MergeArraySorter.MergeSort(array);

				if (resultArray.SequenceEqual(expectedArray))
				{
					Console.WriteLine(correctCaseTemplate, testCaseNumber);
					correctTestCaseAmount++;
				}
				else
				{
					Console.WriteLine(incorrectCaseTemplate, testCaseNumber);
				}
			}
			catch (Exception)
			{
				Console.WriteLine(incorrectCaseTemplate, testCaseNumber);
			}
		}

		private static void TestQuickSort(int testCaseNumber, int[] array, int[] expectedArray)
		{
			try
			{
				int[] resultArray = QuickArraySorter.QuickSort(array);

				if (resultArray.SequenceEqual(expectedArray))
				{
					Console.WriteLine(correctCaseTemplate, testCaseNumber);
					correctTestCaseAmount++;
				}
				else
				{
					Console.WriteLine(incorrectCaseTemplate, testCaseNumber);
				}
			}
			catch (Exception)
			{
				Console.WriteLine(incorrectCaseTemplate, testCaseNumber);
			}
		}

		
		private static string correctCaseTemplate = "Case #{0} is correct.";
		private static string incorrectCaseTemplate = "Case #{0} is incorrect";
		private static int correctTestCaseAmount = 0;
	}
}
