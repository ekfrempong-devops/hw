
public class Running : Activity
{
    private double _distance;

    public Running(string date, int activityLength, double distance)
        : base(date, activityLength, "Running")
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / GetActivityLength() * 60;
    }

    public override double GetPace()
    {
        return GetActivityLength() / _distance;
    }
}