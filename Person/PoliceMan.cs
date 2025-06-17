class PoliceMan : Person
{
    private string _weapons;
    private int _hours;
    private double _hourlyWage;
    public PoliceMan(string firstName, string lastName, int age, string weapons, int hours, double hourlyWage)
    : base(firstName, lastName, age)
    {
        //inherits GetPersonInformation()
        _weapons = weapons;
        _hours = hours;
        _hourlyWage = hourlyWage;
    }
    public string GetPoliceManInformation()
    {
        return $"{GetPersonInformation()} :: Weapons : {_weapons} ";
    }
    public override string GetPersonInformation()
    {
        return $"{base.GetPersonInformation()} :: I am a Police man: Weapons: {_weapons} :: ";
    }
    public override double GetSalary()
    {
        double salary = _hourlyWage * _hours;
        if (_hours > 40)
        {
            // salary -= (_hours - 40) * _hourlyWage;
            salary += (_hours - 40) * _hourlyWage * 2;
        }
        return salary;
    }
}