using Godot;
using System;

public partial class Timekeeper : Node
{ 
    public int TurnNumber { get; private set; }
    public int WeekNumber { get; private set; }

    public void RaiseTurnNumber() => TurnNumber++;
    public void RaiseWeekNumber() => WeekNumber++;
}
