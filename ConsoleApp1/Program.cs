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



        //face animation
        string animation = "(^_^)(-_-)";
        while (DateTime.Now < endTime)
        {
            Console.Write(animation[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animation[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
        }

        //countdown
        //     while (DateTime.Now < endTime)
        //     {
        //         Console.Write(count--);
        //         Thread.Sleep(1000);
        //         Console.Write("\b");
        //     }

        // //spinner
        // while (DateTime.Now < endTime)
        // {
        //     Console.Write("+");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        //     Console.Write("-");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }
    }
}

    