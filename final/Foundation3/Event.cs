using System;
using System.Net.Sockets;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public virtual string GetStandardDetails()
    {
        return $"Event: {_title}\n{_date}, {_time}, {_address.GetFullAddress()}\n{_description}";
    }
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
    public virtual string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nEvent Name: {_title}\nEvent Date: {_date}";
    }
}
