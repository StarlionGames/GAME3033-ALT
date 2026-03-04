using Godot;
using System;

[GlobalClass]
public partial class Event : Resource
{
    [Export] public int EventId { get; set; }
    [Export] public string EventName { get; protected set; }
    [Export] public int TargetMonth;
    [Export] public int TargetWeek;

    // TODO: add choice of target time of week

    public bool HasTriggered { get; protected set; }
    public virtual bool CanTrigger(Timekeeper time)
    {
        if (HasTriggered) return false;

        return true;
    }
    public virtual void Execute() { }

    public void Trigger()
    {
        if (HasTriggered) { return; }

        Execute();
        HasTriggered = true;
    }
}
