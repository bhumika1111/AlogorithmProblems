using System;

namespace AlgorithamProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("::::::::::Welcome To Algorithm Programs:::::::::::::");
            Console.WriteLine("**Press Enter 0 For Exit**");
            Console.WriteLine("**1.Check Anagram**");
            Console.WriteLine("**2.Check Bubble Sort**");
            Console.WriteLine("**3.IInsertion Sort**");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Console.WriteLine("****Output For Checking Two Strings Are Anagram Or Not****");
                    AnagramDetection anagram = new AnagramDetection();
                    anagram.CheckAnagram();
                    break;

                case 2:
                    Console.WriteLine("****Output For Print The Sorted List****");
                    BubbleSorting bubbleSorting = new BubbleSorting();
                    bubbleSorting.Sorting();
                    break;
                case 3:
                    Console.WriteLine("****Output For Print The Sorted List****");
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.CheckSorting();
                    break;
            }
        }
    }
}
