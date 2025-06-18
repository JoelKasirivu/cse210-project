// Derived Class: CyclingActivity
class CyclingActivity : Activity
{
    private double cycleSpeed; // Speed in mph

    public CyclingActivity(DateTime date, int duration, double speed) : base(date, duration)
    {
        cycleSpeed = speed;
    }

    // Override methods for specific calculations
    public override double GetDistance() => (cycleSpeed * GetDuration()) / 60;
    public override double GetSpeed() => cycleSpeed;
    public override double GetPace() => 60 / cycleSpeed;
}