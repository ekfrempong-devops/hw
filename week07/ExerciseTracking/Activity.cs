
public abstract class Activity
{
    private string _date;
    private int _activityLength;
    private string _activityName;

    public Activity(string date, int activityLength, string activityName)
    {
        _date = date;
        _activityLength = activityLength;
        _activityName = activityName;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{_date} {_activityName} ({_activityLength} min) - " + $"Distance {distance:F1} miles, " + $"Speed {speed:F1} mph, " + $"Pace: {pace:F1} min per mile";
    }

    public int GetActivityLength()
    {
        return _activityLength;
    }
}