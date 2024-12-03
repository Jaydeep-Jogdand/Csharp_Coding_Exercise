namespace Coding_Exerciseee24
{
    // Interface for logging service
    public interface ILoggingService
    {
        void Log(string message);
    }

    // Concrete logging service class
    public class LoggingService : ILoggingService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    // Class demonstrating Constructor Injection
    public class MyClassConstructorInjection
    {
        private readonly ILoggingService _loggingService;

        public MyClassConstructorInjection(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void PerformAction()
        {
            // Using _loggingService to log the message
            _loggingService.Log("Constructor Injection: Logging message.");
        }
    }

    // Class demonstrating Setter Injection
    public class MyClassSetterInjection
    {
        public ILoggingService LoggingService { private get; set; }

        public void PerformAction()
        {
            // Using LoggingService to log the message
            LoggingService?.Log("Setter Injection: Logging message.");
        }
    }

    // Interface for Interface Injection
    public interface IDependencyInjector
    {
        void SetDependency(ILoggingService loggingService);
    }

    // Class demonstrating Interface Injection
    public class MyClassInterfaceInjection : IDependencyInjector
    {
        private ILoggingService _loggingService;

        public void SetDependency(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void PerformAction()
        {
            // Using _loggingService to log the message
            _loggingService.Log("Interface Injection: Logging message.");
        }
    }

    // Main class to run the examples
    public class Exercise
    {
        public void Run()
        {
            // Instantiate the logging service
            var loggingService = new LoggingService();

            // Constructor Injection
            var constructorInjection = new MyClassConstructorInjection(loggingService);
            constructorInjection.PerformAction();

            // Setter Injection
            var setterInjection = new MyClassSetterInjection { LoggingService = loggingService };
            setterInjection.PerformAction();

            // Interface Injection
            var interfaceInjection = new MyClassInterfaceInjection();
            interfaceInjection.SetDependency(loggingService);
            interfaceInjection.PerformAction();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise ex = new Exercise();
            ex.Run();
         }
    }
}
