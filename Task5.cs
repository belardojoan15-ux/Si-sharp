using System.Data;
namespace ConsoleApp1;
public class Task5
{
    class Student
    {
        public string? Name; 
        public int English; 
        public int Math; 
        public int Computer;
        public int Total;        
    }
    static void Main(string[] args)
    {
        Console.WriteLine("****************************");
        Console.WriteLine("*      Report Card      *");
        Console.WriteLine("****************************");
        Console.WriteLine("Enter number of student:");
        string? input = Console.ReadLine();
        int numberOfStudents = 0;
        if (!string.IsNullOrEmpty(input) && int.TryParse(input, out numberOfStudents))
        {
            Student[] students = new Student[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                students[i] = new Student();
                Console.WriteLine($"Entering name of student #{i + 1}:");
                students[i].Name = Console.ReadLine();
                Console.WriteLine($"Enter English grade for {students[i].Name} out of 100:");
                students[i].English = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine($"Enter Math grade for {students[i].Name} out of 100:");
                students[i].Math = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine($"Enter Computer grade for {students[i].Name} out of 100:");
                students[i].Computer = int.Parse(Console.ReadLine() ?? "0");
                students[i].Total = students[i].English + students[i].Math + students[i].Computer;
                Console.WriteLine("****************************");
                
            }
           Array.Sort(students, (s1, s2) => s2.Total.CompareTo(s1.Total));
            Console.WriteLine("*** Report Card ***");
            Console.WriteLine("Name\tEnglish\tMath\tComputer\tTotal\tPosition");

            for (int i = 0; i < numberOfStudents; i++)
            {
               Console.WriteLine($"{students[i].Name} Position {i + 1}\t{students[i].English}\t{students[i].Math}\t{students[i].Computer}\t{students[i].Total}");
               Console.WriteLine($"{students[i].Name}'s Total grades {students[i].Total}/300");
               Console.WriteLine("****************************");
            }
            Console.WriteLine("End of Report Card");
            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
    }
}