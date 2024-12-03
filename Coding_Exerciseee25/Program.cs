namespace Coding_Exerciseee25
{
    public interface IShape
    {
        double GetArea();
    }
    public class Circle : IShape
    {
        public double radius { get; set; }
        public Circle(double r)
        {
            radius = r;
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
    public class Rectangle : IShape
    {
        public double width { get; set; }
        public double height { get; set; }
        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }
        public double GetArea()
        {
            return width*height;
        }
    }
    public class Exercise
    {
        public void PrintAreas()
        {
            // TODO: Add your code here
            IShape[] shapes = new IShape[]
        {
            new Circle(5),
            new Rectangle(4, 6)
        };
            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Area: {shape.GetArea()}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintAreas();
        }
    }
}
