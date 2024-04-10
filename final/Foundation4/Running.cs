public class Running : Activity
{
    private double Distance; // in kilometers

    public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance() => Distance;
    public override double GetSpeed() => (Distance / LengthInMinutes) * 60; // kph
    public override double GetPace() => LengthInMinutes / Distance; // min per km

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance {GetDistance()} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}
