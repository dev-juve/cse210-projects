class Program
{
    static void Main()
    {
        // Create instances of Address for each type of event
        Address lectureAddress = new Address("456 University Ave", "College City", "State", "54321");
        Address receptionAddress = new Address("789 Main St", "Downtown", "State", "67890");
        Address outdoorAddress = new Address("101 Park Blvd", "Parkville", "State", "12345");

        // Create instances of each event type with different dates
        LectureEvent lectureEvent = new LectureEvent("Interesting Lecture", "A captivating presentation", DateTime.Now.AddDays(7), "3:00 PM", lectureAddress, "John Doe", 50);
        ReceptionEvent receptionEvent = new ReceptionEvent("Networking Reception", "An evening of socializing", DateTime.Now.AddDays(14), "7:00 PM", receptionAddress, "rsvp@example.com");
        OutdoorGatheringEvent outdoorEvent = new OutdoorGatheringEvent("Community Picnic", "Enjoy food and games", DateTime.Now.AddDays(21), "12:00 PM", outdoorAddress, "Expect sunny weather");

        // Display event details
        Console.WriteLine("Lecture Event:\n");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + lectureEvent.GetShortDescription());

        Console.WriteLine("\n---------------------------------------\n");

        Console.WriteLine("Reception Event:\n");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + receptionEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + receptionEvent.GetShortDescription());

        Console.WriteLine("\n---------------------------------------\n");

        Console.WriteLine("Outdoor Gathering Event:\n");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + outdoorEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + outdoorEvent.GetShortDescription());
    }
}