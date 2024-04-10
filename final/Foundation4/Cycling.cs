public class Cycling : Activity
{
    private double Speed; // in kilometers per hour

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        Speed = speed;
    }

    public override double GetDistance() => (Speed * LengthInMinutes) / 60;
    public override double GetSpeed() => Speed;
    public override double GetPace() => 60 / Speed; // min per km

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling - Distance {GetDistance():F2} km, Speed {GetSpeed()} kph, Pace: {GetPace():F2} min per km";
    }
}
