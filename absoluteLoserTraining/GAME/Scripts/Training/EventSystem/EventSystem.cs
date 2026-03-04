using Godot;
using System;
using System.Collections.Generic;

public partial class EventSystem : Node
{
    List<Event> _events = new List<Event>();

    Timekeeper timekeeper;

    public override void _EnterTree()
    {
        Timekeeper.OnReady += GetTimekeeper;
        Timekeeper.OnTurnPassed += CheckEvents;
    }
    public override void _ExitTree()
    {
        Timekeeper.OnReady -= GetTimekeeper;
        Timekeeper.OnTurnPassed -= CheckEvents;
    }
    public override void _Ready()
    {
        LoadAllEvents();
    }

    void LoadAllEvents()
    {
        LoadEventsFromFolder("res://GAME/Resources/Events/");
    }
    void LoadEventsFromFolder(string path)
    {
        var dir = DirAccess.Open(path);
        if (dir == null) { return; }

        dir.ListDirBegin();
        string filename = dir.GetNext();

        while (filename != "")
        {
            string fullpath = path + "/" + filename;

            if (dir.CurrentIsDir())
            {
                if (filename != "." && filename != "..") { LoadEventsFromFolder(fullpath); }
            }
            else if (filename.EndsWith(".tres"))
            {
                var e = GD.Load<Event>(fullpath);
                if (e != null) _events.Add(e);
            }

            filename = dir.GetNext();
        }

        dir.ListDirEnd();
    }

    void CheckEvents(int turnNum)
    {
        foreach (Event e in _events)
        {
            // if an event hasnt triggered and is at the right date
            // trigger the event
            if (!e.HasTriggered && e.CanTrigger(timekeeper))
            {
                e.Trigger(); break;
            }
        }
    }

    public void GetTimekeeper(Timekeeper time) => timekeeper = time;
}
