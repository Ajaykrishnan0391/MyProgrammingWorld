using System;

namespace PracticeProblems.Algorithms
{
    public class SumSubsetExist : IPractice
    {
        public void Practice()
        {
            CheckIsSumExist();
        }
        public bool isSumSubsetExist(int[] arr, int sum, int n)
        {
            if (sum == 0)
                return true;

            if (sum < 0 || n < 0)
                return false;

            if (isSumSubsetExist(arr, sum - arr[n], n - 1) == true)
                return true;

            if (isSumSubsetExist(arr, sum, n - 1) == true)
                return true;

            return false;
        }
        public void CheckIsSumExist()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int sum = 10;
            if (isSumSubsetExist(arr, sum, arr.Length - 1))
            {
                Console.WriteLine("Sum subset Exists");
            }
            else
            {
                Console.WriteLine("Sum subset doesnot Exists");
            }
        }
    }
}
