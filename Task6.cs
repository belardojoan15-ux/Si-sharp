namespace ConsoleApp1;
public class Task6
{
    class Student
    {
        public string Name{ get; set;}
        public int Age{ get; set;}
        public double Grade{ get; set;}
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Student's Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
        }
        public bool IsPassed()
        {
            if(Grade >= 75)
                return true;
            else
                return false;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter name of students:");
        string name = Console.ReadLine()??"";
        Console.WriteLine("Enter age of students:");
        int age = int.Parse(Console.ReadLine()??"0");
        Console.WriteLine("Enter grade of students:");
        double grade = double.Parse(Console.ReadLine()??"0");

        Student student = new Student(name, age, grade);
        student.DisplayInfo();
        Console.WriteLine(student.IsPassed() ? "Status: Passed" : "Status: Failed");
    }
}