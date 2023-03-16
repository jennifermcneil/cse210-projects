using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("345 Main St.", "Rexburg", "ID", "83440");
        Lectures lectures = new Lectures("Devotional", "Subject on Grace", DateTime.Now, address, "Emily Belle Freeman", 96);
        Receptions receptions = new Receptions("Girls Weekend", "Inklings gathering", DateTime.Now, address, "emailtest@gmail.com");
        OutdoorGatherings outdoorGatherings = new OutdoorGatherings("Camping Trip", "Song at the campfire", DateTime.Now, address, "Sunny");

        List<Event> eventList = new List<Event>();
        eventList.Add(lectures);
        eventList.Add(receptions);
        eventList.Add(outdoorGatherings);

        foreach (Event item in eventList)
        {
            Console.WriteLine($"Standard Details\n{item.GetStandardDetails()}\n\nFull Details\n{item.GetFullDetails()}\n\nShort Description\n{item.GetShortDescription()}\n");
        }



    }
}