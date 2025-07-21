using System;
using ConsoleApp1;
//Event planning with Inheritance
//
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 St", "Ricksburg", "Blidaho", "USA");
        Lecture lecture = new Lecture("Coding in C#", "Learn to pragram in C#.", "2/29/26", "12:00 PM", address1, "Guy Person", 8314923);

        Address address2 = new Address("456 Blvd", "Blidaho Falls", "Blidaho", "USA");
        Reception reception = new Reception("Cool Event", "It will be cool.", "4/31/91", "8:01 PM", address2, "rsvp@mail.com");

        Address address3 = new Address("789 Dr", "Grigby", "Blidaho", "USA");
        OutdoorGathering gathering = new OutdoorGathering("Some gathering", "Just show up, I guess.", "12/12/12", "12:12 PM", address3, "good");

        Event[] events = { lecture, reception, gathering };

        foreach (Event evt in events)
        {
            Console.WriteLine("Standard Details:\n" + evt.GetStandardDetails());
            Console.WriteLine("\nFull Details:\n" + evt.GetFullDetails());
            Console.WriteLine("\nShort Description:\n" + evt.GetStandardDetails());
            Console.WriteLine(new string('-', 40));
        }
    }
}