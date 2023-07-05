
using GradingTheStudents;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Rachel", 70),
            new Student("Ross", 90),
            new Student("Monica", 99),
            new Student("Chandler", 88),
            new Student("Joey", 65),
            new Student("Phoebe", 76),
            new Student("Mike", 95),
            new Student("Gunther", 80),
            new Student("janice", 77),
            new Student("Ben", 87)
        };

        double sumGrades = 0;
        foreach (var student in students)
        {
            sumGrades += student.Grade;
        }
        double averageGrade = sumGrades / students.Count;

        Console.WriteLine("The average grade of the students is: " + averageGrade);

        Student studentWithHighestGrade = null;
        int highestGrade = -1;
        foreach (var student in students)
        {
            if (student.Grade > highestGrade)
            {
                highestGrade = student.Grade;
                studentWithHighestGrade = student;
            }
        }

        Console.WriteLine("The student with the highest grade is: " + studentWithHighestGrade.Name + " (" + studentWithHighestGrade.Grade + ")");
    }
}
