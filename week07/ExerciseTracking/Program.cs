using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        // Create a list to store activity instances
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(DateTime.Now, 30, 3.0),
            new CyclingActivity(DateTime.Now, 45, 20.0),
            new SwimmingActivity(DateTime.Now, 40, 20)
        };

        // Iterate through the activities and display their summary
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
        
        // Base Activity class
        public abstract class Activity
    {
        public DateTime Date { get; set; }
        public int DurationMinutes { get; set; }

        public Activity(DateTime date, int durationMinutes)
        {
            Date = date;
            DurationMinutes = durationMinutes;
        }

        public abstract string GetSummary();
    }
        
        public class RunningActivity : Activity
        {
            public double DistanceKm { get; set; }
        
            public RunningActivity(DateTime date, int durationMinutes, double distanceKm)
                : base(date, durationMinutes)
            {
                DistanceKm = distanceKm;
            }
        
            public override string GetSummary()
            {
                return $"{Date.ToShortDateString()} Running ({DurationMinutes} min): Distance {DistanceKm} km";
            }
        }
        
        public class CyclingActivity : Activity
        {
            public double SpeedKmh { get; set; }
        
            public CyclingActivity(DateTime date, int durationMinutes, double speedKmh)
                : base(date, durationMinutes)
            {
                SpeedKmh = speedKmh;
            }
        
            public override string GetSummary()
            {
                return $"{Date.ToShortDateString()} Cycling ({DurationMinutes} min): Speed {SpeedKmh} km/h";
            }
        }
        
        public class SwimmingActivity : Activity
        {
            public int Laps { get; set; }
        
            public SwimmingActivity(DateTime date, int durationMinutes, int laps)
                : base(date, durationMinutes)
            {
                Laps = laps;
            }
        
            public override string GetSummary()
            {
                return $"{Date.ToShortDateString()} Swimming ({DurationMinutes} min): Laps {Laps}";
            }
        }
    }



