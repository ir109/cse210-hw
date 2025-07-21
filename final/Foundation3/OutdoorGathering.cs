namespace ConsoleApp1;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
    : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nEvent Type: Outdoor Gathering\nWeather forcast for event: {_weatherForecast}";
    }
}
