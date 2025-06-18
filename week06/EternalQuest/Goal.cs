using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
// This abstract class represents a generic goal in the Eternal Quest game.
{
    protected string name;
    protected int points;
    protected bool isCompleted;

    public Goal(string name, int points)
    // Constructor for the Goal class that initializes the goal with a name and points.
    // It also sets the initial completion status to false.
    {
        this.name = name;
        this.points = points;
        this.isCompleted = false;
    }

    public abstract void RecordProgress();
    // Abstract method to record progress on the goal.
    // Each derived class must implement this method to define how progress is recorded.
    public virtual void DisplayStatus()
    // Virtual method to display the current status of the goal.
    // It shows the goal name and whether it is completed or not.
    {
        Console.WriteLine($"Goal: {name} | Completed: {(isCompleted ? "[X]" : "[ ]")}");
    }

    public int GetPoints() => points;
    // Method to get the points associated with the goal.
}
