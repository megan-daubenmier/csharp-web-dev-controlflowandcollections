using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newID;
            string studentName;
            do
            {
                Console.WriteLine("Please enter the student's ID. Press enter to finish list.");
                newID = Console.ReadLine();
                if (!Equals(newID, ""))
                {
                    Console.WriteLine("Please enter student's name.");
                    studentName = Console.ReadLine();
                    students.Add(int.Parse(newID), studentName);
                }
                
            } while (!Equals(newID, ""));
            
            foreach(KeyValuePair<int,string> student in students)
            {
                Console.WriteLine(student.Key + ": " + student.Value);
            }
        }
    }
}
