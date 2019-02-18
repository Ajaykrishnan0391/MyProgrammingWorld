using System;

namespace PracticeProblems.Algorithms
{
    public class PrintSubsetCount : IPractice
    {
        public void Practice()
        {
            PrintSubsetSumCount();
        }
        public bool GetSumSubsetCount(int[] arr, int sum, int n, ref int count)
        {
            if (sum == 0)
                return true;

            if (sum < 0 || n < 0)
                return false;

            if (GetSumSubsetCount(arr, sum - arr[n], n - 1, ref count) == true)
                count++;

            if (GetSumSubsetCount(arr, sum, n - 1, ref count) == true)
                count++;

            return false;
        }
        public void PrintSubsetSumCount()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int sum = 10;
            int count = 0;
            var result = GetSumSubsetCount(arr, sum, arr.Length - 1, ref count);
            Console.WriteLine(string.Format("There are {0} subsets with the sum {1}", count, sum));
        }
    }
    
}
