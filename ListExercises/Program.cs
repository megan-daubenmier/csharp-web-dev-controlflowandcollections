using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(sumEvens(nums));

            Console.WriteLine("Please enter a word length for the search.");
            int length = int.Parse(Console.ReadLine());
            string drSuess = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            List<string> words = drSuess.Split(" ").ToList();
            printWords(words, length);
        }
        private static int sumEvens(List<int> nums)
        {
            int sum = 0;
            foreach(int num in nums)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        private static void printWords(List<string> words, int length)
        {
            foreach(string word in words)
            {
                if(word.Length==length)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
