namespace Coding_Exerciseee22
{

    public interface IVehicle
    {
        // TODO: Declare a method Drive
        public void Drive();
    }

    public class Car : IVehicle
    {
        // TODO: Implement the Drive method
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Drive();
        }
    }

}
