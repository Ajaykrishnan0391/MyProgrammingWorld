using System;
using System.Collections.Generic;
using System.Text;
using PracticeProblems;
using PracticeProblems.Algorithms;

namespace ProgrammingConsole
{
    class ExecutePrograms
    {
        internal void Start()
        {
            var extInput = "";
            do
            {
                PrintList();
                int input;
                if(int.TryParse(Console.ReadLine(), out input))
                {
                    if (GetProgramCollection().ContainsKey(input))
                    {
                        IPractice obj = GetObjectFromFactory(input);
                        obj.Practice();
                    }
                    else
                    {
                        PrintInputError();
                    }
                }
                else
                {
                    PrintInputError();
                }
                Console.WriteLine("Do You want to proceed ? \n Yes : Enter 1 \n No : Press any other key");
                extInput = Console.ReadLine();
            } while (extInput == "1");
        }
        void PrintList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Enter an Option \n");
            foreach (var item in GetProgramCollection())
            {
                sb.Append(item.Key + " : " + item.Value + " \n");
            }
            Console.WriteLine(sb.ToString());
        }
        void PrintInputError()
        {
            Console.WriteLine("Provide a valid input");
        }
        Dictionary<int,string> GetProgramCollection()
        {
            var dict = new Dictionary<int, string>();
            dict.Add(1, "Binary Search");
            dict.Add(2, "Bubble Sort");
            return dict;
        }
        IPractice GetObjectFromFactory(int input)
        {
            switch(input)
            {
                case 1: return new BinarySearch();
                case 2: return new BubbleSort();
                default: return new BinarySearch();
            }
        }
        static int[] GetInputArrayFromFile()
        {
            // copy the below line to a notepad called "input" and put it in D drive
            //1 3 5 9 10 15 16 18 19 20
            System.IO.StreamReader file = new System.IO.StreamReader("D:\\input.txt");
            string input = file.ReadToEnd();
            String[] listInts = input.Split(' ');
            int[] arr = Array.ConvertAll(listInts, int.Parse);
            return arr;
        }

    }
}
