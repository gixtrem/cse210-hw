public abstract class Activity
{
    protected DateTime Date { get; private set; }
    protected int LengthInMinutes { get; private set; }

    protected Activity(DateTime date, int lengthInMinutes)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance() => 0; // Default implementation, should be overridden
    public virtual double GetSpeed() => 0; // Default implementation, should be overridden
    public virtual double GetPace() => 0; // Default implementation, should be overridden

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} ({LengthInMinutes} min)";
    }
}
