using System;

namespace SOLIDexperimentation
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Name of the Student?");
            var name = Console.ReadLine();
            Console.WriteLine("Student ID");
            var Id = Console.ReadLine();
            Console.WriteLine("Marks in SubjectA");
            var subjectA = float.Parse(Console.ReadLine());
            Console.WriteLine("Marks in SubjectB");
            var subjectB = float.Parse(Console.ReadLine());
            Console.WriteLine("Marks in SubjectC");
            var subjectC = float.Parse(Console.ReadLine());
            Console.WriteLine("Marks in SubjectD");
            var subjectD = float.Parse(Console.ReadLine());

            Student newEntry = new Student(new StudentMarksCalculator(), new StudentFeeCalculator());
            newEntry.Name = name;
            newEntry.ID = Id;
            var studentPercentage = newEntry.GetPercentage(subjectA, subjectB, subjectC, subjectD);
            Console.WriteLine("The percentage of Student: {0} is {1}", name, studentPercentage);
            Console.WriteLine("The fee for the student {0} is {1}", name, newEntry.GetTution(studentPercentage));
        }
    }
}
