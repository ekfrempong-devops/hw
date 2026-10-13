using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected string _date;
    protected int _activityLength;
    protected int _distance;
    protected int _speed;
    protected int _pace;
    public Activity(string date, int activityLength, int distance, int speed, int pace)
    {
        _date = date;
        _activityLength = activityLength;
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }
    public virtual GetDistance()
    {
        
    }
    public virtual GetSpeed()
    {
        
    }
    public virtual GetPace()
    {
        
    }
    public virtual GetSummary()
    {
        
    }
}
