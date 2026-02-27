using Godot;
using System;
using System.Collections.Generic;
using System.Reflection;

public partial class Timekeeper : Node
{
    public Month month;
    public Week currWeek;
    public Turn currTurn;

    public int WeekNumber { get; private set; } = 1;
    public int MonthNumber { get; private set; } = 1;

    int totalTurnCounter = 1;

    Dictionary<int, Action> events = new Dictionary<int, Action>(); // wip, add actual event class later
    public static Action<Timekeeper> OnReady;

    public override void _Ready()
    {
        base._Ready();
        PrepareNewTimekeeper();

        currWeek.End += RaiseWeekNumber;
        //DebuggingMessage();
        OnReady?.Invoke(this);
    }

    public void PrepareNewTimekeeper()
    {
        month = new Month(MonthNumber, "Jan");
        currWeek = month.week;
        currTurn = currWeek.currTurn;
    }

    public void RaiseWeekNumber() => WeekNumber++;
    public void RaiseMonthNumber() => MonthNumber++;

    public void PassTime()
    {
        totalTurnCounter++;
        currTurn = currWeek.NextTurn();

        if (WeekNumber>4)
        {
            RaiseMonthNumber();
            month.Reset(MonthNumber);
        }

        //DebuggingMessage();
    }

    public void EndCurrentTurn() { currTurn.UseTurn(); PassTime(); }

    void DebuggingMessage()
    {
        GD.Print($"month: {MonthNumber},week: {WeekNumber}, index: {currWeek.index}" +
            $"\ntotal turns: {totalTurnCounter}");
    }
}
