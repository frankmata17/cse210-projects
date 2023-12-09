using System;

class Program
{
    static void Main(string[] args)
    {
        // Create event objects
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        LectureEvent lecture = new LectureEvent("Tech Talk", "A discussion on new technologies", new DateTime(2023, 1, 15, 14, 0, 0), "Conference Room 1", address1, "Bruce Wayne", 100);

        Address address2 = new Address("456 Oak St", "Townsville", "NY", "USA");
        ReceptionEvent reception = new ReceptionEvent("Wedding Reception", "Welcoming the future Mr. and Mrs. Incredible", new DateTime(2023, 2, 20, 18, 30, 0), "Event Hall", address2, "rsvp@example.com");

        Address address3 = new Address("789 Pine St", "Park City", "UT", "USA");
        OutdoorGatheringEvent outdoorGathering = new OutdoorGatheringEvent("Summer Festival", "Music and Fun", new DateTime(2023, 6, 10, 16, 0, 0), "City Park", address3, "Sunny");

        // Display event details
        DisplayEventDetails(lecture);
        Console.WriteLine();
        DisplayEventDetails(reception);
        Console.WriteLine();
        DisplayEventDetails(outdoorGathering);
    }

    static void DisplayEventDetails(Event myEvent)
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(myEvent.GetStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(myEvent.GetFullDetails());

        Console.WriteLine("\nShort Description:");
        Console.WriteLine(myEvent.GetShortDescription());

        Console.WriteLine();
    }
}
