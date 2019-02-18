using System;

namespace PracticeProblems.Algorithms
{
    public class BubbleSort : IPractice
    {
        public void Practice()
        {
            TestBubbleSort();
        }

        void TestBubbleSort()
        {
            int proceed = 0;
            int[] arr = { 8, 3, 2, 9, 1, 7, 5, 4, 6, 3, 3 };
            do
            {
                int[] result;
                Console.WriteLine("1. Bubble Sort \n2. Modified bubble sort");
                int method = int.Parse(Console.ReadLine());
                if (method == 1)
                {
                    result = Sort(arr);
                }
                else
                {
                    result = ModifiedSort(arr);
                }
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Do you want to continue Bubble sort? \n1. Yes.\n2. No");
                proceed = int.Parse(Console.ReadLine());

            } while (proceed == 1);
        }
        int[] Sort(int[] arr)
        {
            for (int j = 1; j <= arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
            return arr;
        }
        public int[] ModifiedSort(int[] arr)
        {
            for (int j = 1; j <= arr.Length; j++)
            {
                int swapCount = 0;
                for (int i = 0; i < arr.Length - j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapCount++;
                    }
                }
                if (swapCount == 0)
                {
                    return arr;
                }
            }
            return arr;
        }
    }
}
