// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        int duration = 9;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        int sleepTime = 350;
        int count = duration;

        //countdown
        while (DateTime.Now < endTime)
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        //spinner
        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
    }
}

    