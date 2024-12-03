namespace Coding_Exerciseee20  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John Doe", 123);
        }
    }
    public class Person
    {
        // TODO: Declare a constructor that takes a name and prints a message
        public string name { get; private set; }

        public Person(string name)
        {
            this.name = name;
            Console.WriteLine($"Person constructor: {this.name}");
        }
    }

    public class Employee : Person
    {
        // TODO: Declare a constructor that takes a name and an ID, and calls the base class constructor
        public int id { get; private set; }
        public Employee(string name, int id) : base(name)
        {
            this.id = id;
            Console.WriteLine($"Employee constructor: {name}, ID: {this.id}");
        }
    }
}
