class Doctor : Person
{
    private string _tools;
    private double _salary;
    public Doctor(string firstName, string lastName, int age, string tools, double salary)
    : base(firstName, lastName, age)
    {
        _tools = tools;
        _salary = salary;
    }
    public string GetDoctorInformation()
    {
        return $"{GetPersonInformation()} :: Tools : {_tools}";
    }
    public override string GetPersonInformation()
    {
        return $"{base.GetPersonInformation()} :: I am a Doctor: Tools: {_tools} :: ";
    }
    public override double GetSalary()
    {
        return _salary / 12;
    }
}