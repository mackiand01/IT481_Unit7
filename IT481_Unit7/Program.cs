using System;

namespace IT481_Unit7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] smallDataSet = DataSetStorage.smallDataSet;
                     
            int[] mediumDataSet = DataSetStorage.mediumDataSet;

            int[] largeDataSet = DataSetStorage.largeDataSet;

            //*********************************************************
            //****Assignment 7, Section 1
            //*********************************************************
            Console.WriteLine("The small set has 100 numbers, the medium data set has 1,000 numbers, and the large data set has 10,000 numbers\n");
            Console.WriteLine("********************************************\n");
            Console.WriteLine("**********Section 1 - Bubble Sort **********");
            Console.WriteLine();
            
            var watch1Bubble = System.Diagnostics.Stopwatch.StartNew();
            sortArrayAscBS(smallDataSet);
            watch1Bubble.Stop();
            Console.WriteLine("The time taken to sort the small data set with a bubble sort is: " + watch1Bubble.ElapsedMilliseconds + " milliseconds\n");

            var watch2Bubble = System.Diagnostics.Stopwatch.StartNew();
            sortArrayAscBS(mediumDataSet);
            watch2Bubble.Stop();
            Console.WriteLine("The time taken to sort the medium data set with a bubble sort is: " + watch2Bubble.ElapsedMilliseconds + " milliseconds\n");

            var watch3Bubble = System.Diagnostics.Stopwatch.StartNew();
            sortArrayAscBS(largeDataSet);
            watch3Bubble.Stop();
            Console.WriteLine("The time taken to sort the large data set with a bubble sort is: " + watch3Bubble.ElapsedMilliseconds + " milliseconds\n");
            
            //*********************************************************
            //****Assignment 7, Section 2
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine("**********Section 2 - Quick Sort **********");
            Console.WriteLine();


            int low_small = 0;
            int high_small = smallDataSet.Length - 1;

            var watch1QS = System.Diagnostics.Stopwatch.StartNew();
            sortArrayAscQS(smallDataSet, low_small, high_small);
            watch1QS.Stop();
            Console.WriteLine("The time taken to sort the small data set with a quick sort is: " + watch1QS.ElapsedMilliseconds + " milliseconds\n");

            int low_medium = 0;
            int high_medium = mediumDataSet.Length - 1;

            var watch2QS = System.Diagnostics.Stopwatch.StartNew();
            sortArrayAscQS(mediumDataSet, low_medium, high_medium);
            watch2QS.Stop();
            Console.WriteLine("The time taken to sort the medium data set with a quick sort is: " + watch2QS.ElapsedMilliseconds + " milliseconds\n");

            int low_large = 0;
            int high_large = largeDataSet.Length - 1;

            var watch3QS = System.Diagnostics.Stopwatch.StartNew();
            sortArrayAscQS(largeDataSet, low_large, high_large);
            watch3QS.Stop();
            Console.WriteLine("The time taken to sort the large data set with a quick sort is: " + watch3QS.ElapsedMilliseconds + " milliseconds\n");
        }


        public static void sortArrayAscQS(int[] arr, int low, int high)
        {
            if (arr == null || arr.Length == 0)
                return;
            if (low >= high)
                return;
            // pick the pivot 
            int middle = low + (high - low) / 2;
            int pivot = arr[middle];
            // make left < pivot and right > pivot 
            int i = low, j = high;
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }
                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            // recursively sort two sub parts 
            if (low < j)
                sortArrayAscQS(arr, low, j);
            if (high > i)
                sortArrayAscQS(arr, i, high);
        }
                
        public static void sortArrayAscBS(int[] arr)
        {
            int t;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        t = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                    }
                }
            }

        }

        static void printArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                Console.Write(arr[i]);
                if (i != arr.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
        }
    }
}
