
using System;

namespace MaximumInSubArraysOfSizeK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum subarrays of size K!");
            Console.WriteLine("----------------------------");

            try
            {
                int[] array = GetArrayFromInput();
                Console.WriteLine("Enter the size for subarray");
                int K = int.Parse(Console.ReadLine());
                Console.WriteLine("---Printing the maximum in every subarray of size " +
                    ""+K+"---");
                PrintMaximumInSubArraysOfSizeK(array, K);
            }
            catch (Exception exception) {
                Console.WriteLine("Main: Thrown exception is "+exception.Message);
            }


            Console.ReadLine();
        }

        private static int[] GetArrayFromInput() {
            int[] array = null;

            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int noElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                array = new int[noElements];
                for (int index = 0; index < noElements; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("GetArrayFromInput(): Thrown exception is "+exception.Message);
            }


            return array;
        }

        private static void PrintMaximumInSubArraysOfSizeK(int []array, int K) {
            if (array.Length < K)
            {
                Console.WriteLine("Size of subarray cannot be greater than" +
                    "the length of the array");
            }
            else if (K <= 0) {

                Console.WriteLine("Subarray size shoud be greater than 0");
            }
            else
            {
                for (int index = 0; index < (array.Length - K + 1); index++)
                {
                    Console.Write(GetMaximumInSubArray(index, index + K - 1, array)+" ");
                }
            }
        }

        private static int GetMaximumInSubArray(int startIndex, int endIndex, int[] array) {

            int maxValue = int.MinValue;
            int arrayLength = array.Length;

            for (int index = startIndex; index <= endIndex &&
                startIndex < arrayLength && endIndex < arrayLength; index++) {
                if (array[index] > maxValue) {
                    maxValue = array[index];
                }
            }

            return maxValue;
        }
    }
}
