using System;

public abstract class Activity
{
    private string _date;
    private double _lengthMinutes;

    public Activity(string date, double lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        string summary = $"{_date} ({_lengthMinutes} min) - Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
        return summary;
    }
}