// Derived Class: SwimmingActivity
class SwimmingActivity : Activity
{
    private int swimLaps;
    private const double LapLengthMeters = 50;

    public SwimmingActivity(DateTime date, int duration, int laps) : base(date, duration)
    {
        swimLaps = laps;
    }

    // Override methods for specific calculations
    public override double GetDistance() => (swimLaps * LapLengthMeters) / 1609.34; // Convert meters to miles
    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;
    public override double GetPace() => GetDuration() / GetDistance();
}