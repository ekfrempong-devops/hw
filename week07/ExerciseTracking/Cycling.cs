
public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int activityLength, double speed)
        : base(date, activityLength, "Cycling")
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * GetActivityLength() / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}