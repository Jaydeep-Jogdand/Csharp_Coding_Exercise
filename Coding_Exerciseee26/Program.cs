namespace Coding_Exerciseee26
{
    public struct Event
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Event(DateTime s, DateTime e)
        {
            StartDate = s;
            EndDate = e;
        }
        public double GetDuration()
        {
            return (EndDate - StartDate).TotalDays;
        }
        public bool IsOverlapping(Event otherEvent)
        {
            return (StartDate < otherEvent.EndDate && EndDate > otherEvent.StartDate);
        }
    }

    public class Exercise
    {
        public void TestEvents()
        {


            Event event1 = new Event(new DateTime(2024, 7, 1), new DateTime(2024, 7, 10));
            Event event2 = new Event(new DateTime(2024, 7, 5), new DateTime(2024, 7, 15));


            Console.WriteLine($"Event 1 Duration: {event1.GetDuration()} days");
            Console.WriteLine($"Event 2 Duration: {event2.GetDuration()} days");


            bool overlap = event1.IsOverlapping(event2);
            Console.WriteLine($"Events Overlap: {overlap}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise ex = new Exercise();
            ex.TestEvents();
        }
    }
}
