using System;

namespace PracticeProblems.Algorithms
{
    public class BinarySearch : IPractice
    {
        public void Practice()
        {
            TestBinarySearch();
        }
        void TestBinarySearch()
        {
            int proceed = 0;
            int[] a = { 1, 3, 5, 9, 10, 15, 16, 18, 19, 20 };
            int[] inputs = { 1, 3, 5, 9, 10, 15, 16, 18, 19, 20 };
            do
            {
                Console.WriteLine("1. Using while loop \n2. Using Recursion");
                int method = int.Parse(Console.ReadLine());
                Console.WriteLine("-----output-----");
                foreach (int input in inputs)
                {
                    var position = 0;
                    if (method == 1)
                    {
                        position = UsingWhileLoop(a, input);
                    }
                    else
                    {
                        position = UsingRecursion(a, input, 0, a.Length - 1);
                    }
                    Console.WriteLine(position);
                }
                Console.WriteLine("-----output-----");
                Console.WriteLine("Do you want to continue Binary Search \n1. Yes.\n2. No");
                proceed = int.Parse(Console.ReadLine());

            } while (proceed == 1);
        }
        public int UsingWhileLoop(int[] arr, int key)
        {
            int start = 0, end = arr.Length - 1, mid = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (key == arr[mid])
                {
                    return mid;
                }
                else if (key > arr[mid])
                {
                    start = mid + 1;
                }
                else if (key < arr[mid])
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
        public int UsingRecursion(int[] arr, int key, int start, int end)
        {
            int mid = (start + end) / 2;
            if (key == arr[mid])
            {
                return mid;
            }
            else if (key > arr[mid])
            {
                return UsingRecursion(arr, key, mid + 1, end);
            }
            else if (key < arr[mid])
            {
                return UsingRecursion(arr, key, start, mid - 1);
            }
            return -1;
        }
    }
}
