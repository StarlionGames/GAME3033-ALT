using Godot;
using System;
using System.Collections.Generic;

public class Month : TimeUnit
{
    public int NumOfWeeks = 3;
    public List<Week> ListOfWeeks = new List<Week>();

    public void GenerateListOfWeeks()
    {
        if (ListOfWeeks.Count > 0) { return; }

        for (int i = 0; i < NumOfWeeks; i++)
        {
            Week newWeek = new Week(i);
            ListOfWeeks.Add(newWeek);
        }
    }
}
