public class Swimming : Activity
{
     protected int _numberOfLaps;
     public Swimming(string date, int activityLength, int numberOfLaps) : base(date, activityLength)
    {
        _numberOfLaps = numberOfLaps;
    }
    public override int GetDistance()
    {
        
    }
}