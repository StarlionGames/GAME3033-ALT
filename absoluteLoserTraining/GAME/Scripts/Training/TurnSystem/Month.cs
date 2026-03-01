using Godot;
using System;
using System.Collections.Generic;

public class Month : TimeUnit
{
    public string Name;
    public Week week;
    public int index = 1; // replace this with actual calendar
    public Month(int number, string name)
    {
        Number = number;
        Name = name;

        week = new Week(1);
    }

    public void Reset(int monthnum)
    {
        Number = monthnum;
        week.Reset(index);
    }
}
