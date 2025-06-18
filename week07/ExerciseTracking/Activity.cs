using System;
using System.Collections.Generic;

// Base Class: Activity
abstract class Activity
{
    // Private attributes to ensure encapsulation
    private DateTime activityDate;
    private int activityDuration; // in minutes

    // Constructor for shared attributes
    public Activity(DateTime date, int duration)
    {
        activityDate = date;
        activityDuration = duration;
    }

    // Abstract methods for calculations (to be overridden in derived classes)
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method for summary (can be overridden if needed)
    public virtual string GetSummary()
    {
        return $"{activityDate.ToString("dd MMM yyyy")} {GetType().Name} ({activityDuration} min) - " +
               $"Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

    // Getter method for duration (ensuring controlled access)
    protected int GetDuration() => activityDuration;
}