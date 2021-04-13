using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(120, "Merry K. Sullivan");
            students.Add(247, "Leola J. Ortiz");
            students.Add(359, "Sam G. Hall");
            students.Add(481, "George E.Olsen");
            students.Add(667, "Andrew L. Powell");

            Console.WriteLine("We have {0} students in our system.", students.LengthOfKeys);

            for (int i = 0; i < students.LengthOfKeys; i++)
            {
                Console.WriteLine("Student's ID: {0} | Student's Name: {1}", students.keys[i], students.values[i]);
            }
        }
    }
}
