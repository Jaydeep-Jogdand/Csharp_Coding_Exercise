namespace Coding_Exercisee11
{
   
    public class MyClass
    {

        private readonly string _value;


        public string Value => _value;


        public MyClass(string value)
        {
            _value = value;
        }
    }

    public class Exercise
    {
        public void PrintReadOnlyProperty()
        {
            MyClass myInstance = new MyClass("Read-Only Property Value");

            Console.WriteLine(myInstance.Value);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintReadOnlyProperty();
        }

    }
}
