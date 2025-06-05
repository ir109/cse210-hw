using Microsoft.Win32.SafeHandles;

class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Guy", "Person", 49);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Joe", "Dirt", 74, "blat");
        Console.WriteLine(myPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("John", "Smith", 21, "saw");
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}