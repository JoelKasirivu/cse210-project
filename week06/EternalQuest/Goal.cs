using System;
using System.Collections.Generic;

abstract class Goal
// Base class for all types of goals
{
    protected string _shortName;
    // Short name for the goal
    // This is used for quick identification of the goal
    protected string _description;
    // Description of the goal
    // This provides more details about what the goal entails
    protected int _points;
    // Points awarded for completing the goal
    // This is the score that contributes to the overall score in the game`

    public Goal(string name, string description, int points)
    // Constructor to initialize the goal with a name, description, and points
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    // Abstract method to record an event related to the goal
    // Each derived class will implement this method to define how the goal is updated
    public virtual string GetDetailsString()
    // Method to get a string representation of the goal's details
    {
        return $"{_shortName}: {_description} ({_points} pts)";
    }

    public int GetPoints() => _points;
    // Method to get the points associated with the goal
}
