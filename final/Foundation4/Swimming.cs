public class Swimming : Activity
{
    private int Laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance() => Laps * 50.0 / 1000; // in kilometers
    public override double GetSpeed() => GetDistance() / (LengthInMinutes / 60.0); // kph
    public override double GetPace() => LengthInMinutes / GetDistance(); // min per km

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming - Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}
