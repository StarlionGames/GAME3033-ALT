using Godot;
using System;
using System.Collections.Generic;

public class Month : TimeUnit
{
    public string Name;
    public int NumOfWeeks = 3;
    public List<Week> ListOfWeeks = new List<Week>();

    public Month(int number, string name)
    {
        this.Number = number;
        this.Name = name;

        GenerateListOfWeeks();
    }

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
