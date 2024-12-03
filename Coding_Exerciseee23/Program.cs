namespace Coding_Exerciseee23
{
    public interface IPayment
    {
        // TODO: Declare a method ProcessPayment
        public void ProcessPayment();
    }

    public class CreditCardPayment : IPayment
    {
        // TODO: Implement the ProcessPayment method
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment");
        }
    }

    public class PayPalPayment : IPayment
    {
        // TODO: Implement the ProcessPayment method
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.ProcessPayment();


            PayPalPayment payPalPayment = new PayPalPayment();
            payPalPayment.ProcessPayment();
        }
    }
}
