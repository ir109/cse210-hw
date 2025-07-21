using System;
//Exercise program with Polymorphism
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 7, 7), 30, 4.8),
            new Cycling(new DateTime(2025, 7, 17), 60, 30.0),
            new Swimming(new DateTime(2025, 12, 20), 41, 32)
        };
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}