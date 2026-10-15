
public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int activityLength, int numberOfLaps)
        : base(date, activityLength, "Swimming")
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetActivityLength() * 60;
    }

    public override double GetPace()
    {
        return GetActivityLength() / GetDistance();
    }
}