using System;
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int userChoice;

        do
        {
            userChoice = menu.DisplayMenu();

            switch (userChoice)
            {
                case 1:
                    new BreathingActivity("Breathing Activity", "Help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find more peace and less stress through the exercise.", 0).RunActivity();
                    break;
                case 2:
                    new ReflectingActivity("Reflection Activity", "Guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience. They might discover more depth than they previously realized.", 0).RunActivity();
                    break;
                case 3:
                    new ListingActivity("Listing Activity", "Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity. They might discover more breadth than they previously realized.", 0).RunActivity();
                    break;
                case 0:
                    Console.WriteLine("Goodbye.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }   

            Console.WriteLine();
        } while (userChoice != 0);
    }
}