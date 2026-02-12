using Godot;
using System;
using System.Collections.Generic;

public partial class Timekeeper : Node
{
    public List<Month> months;

    public int TurnNumber { get; private set; } 
    public int WeekNumber { get; private set; }
    public int MonthNumber { get; private set; }

    public Timekeeper()
    {

    }

    public void RaiseTurnNumber() => TurnNumber++;
    public void RaiseWeekNumber() => WeekNumber++;
    public void RaiseMonthNumber() => MonthNumber++;
}
