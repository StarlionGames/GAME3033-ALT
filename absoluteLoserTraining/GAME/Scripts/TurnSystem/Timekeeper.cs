using Godot;
using System;
using System.Collections.Generic;

public partial class Timekeeper : Node
{
    public List<Month> months;
    public Turn currTurn;

    public int TurnNumber { get; private set; } 
    public int WeekNumber { get; private set; }
    public int MonthNumber { get; private set; }

    public override void _Ready()
    {
        PrepareNewTimekeeper();
        GD.Print("timekeeper ready");
    }

    void PrepareNewTimekeeper()
    {
        // fill this with something later...
    }

    public void RaiseTurnNumber() => TurnNumber++;
    public void RaiseWeekNumber() => WeekNumber++;
    public void RaiseMonthNumber() => MonthNumber++;
}
