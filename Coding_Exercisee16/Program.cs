namespace Coding_Exercisee16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PrintStudents();
        }
        public void PrintStudents()
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>
            {
                { "John", new Student { Id = 1, Name = "John", Grade = 85 } },
                { "Alice", new Student { Id = 2, Name = "Alice", Grade = 90 } },
                { "Bob", new Student { Id = 3, Name = "Bob", Grade = 78 } }
            };


            foreach (var s in students)
            {
                Student student = s.Value;
                Console.WriteLine($"Name: {student.Name}, Id: {student.Id}, Grade: {student.Grade}");
            }
        }
    }
    
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
    }
}
