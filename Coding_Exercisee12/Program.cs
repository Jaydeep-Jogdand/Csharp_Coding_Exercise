namespace Coding_Exercisee12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person("John",30);
            person.Greet();
        }
    }

    public class Person
    {

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be greater than 0.");
                }
            }
        }
        public Person(string name, int age)
        {
            _name = name;
            Age = age;
        }
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}
