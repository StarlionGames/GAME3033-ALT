using Godot;
using System;
using System.Collections.Generic;

public class Month
{
    public int NumOfWeeks = 3;
    public List<Week> ListOfWeeks = new List<Week>();

    public void GenerateListOfWeeks()
    {
        if (ListOfWeeks.Count > 0) { return; }

        for (int i = 0; i < NumOfWeeks; i++)
        {
            Week newWeek = new Week();
            ListOfWeeks.Add(newWeek);
        }
    }
}
