using System;
using System.Collections.Generic;
using System.Linq;
using SharingVictory;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        students.Add(new Student("Rachel", 70));
        students.Add(new Student("Ross", 90));
        students.Add(new Student("Monica", 99));
        students.Add(new Student("Chandler", 88));
        students.Add(new Student("Joey", 65));
        students.Add(new Student("Phoebe", 76));
        students.Add(new Student("Mike", 99));
        students.Add(new Student("Gunther", 80));
        students.Add(new Student("janice", 77));
        students.Add(new Student("Ben", 87));

        double sum = 0;
        foreach (var student in students)
        {
            sum += student.Grade;
        }
        double average = sum / students.Count;

        Console.WriteLine("The grade point average is: " + average);

        int highestGrade = students.Max(student => student.Grade);

        List<Student> highestGradeStudents = students.Where(student => student.Grade == highestGrade).ToList();

        highestGradeStudents.Sort((student1, student2) => string.Compare(student1.Name, student2.Name));

        Console.WriteLine("The students with the highest marks are:");

        foreach (var student in highestGradeStudents)
        {
            Console.WriteLine(student.Name + " (" + student.Grade + ")");
        }
    }
}
