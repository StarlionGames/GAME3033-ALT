using Godot;
using System;
using System.Collections.Generic;

public enum StatType
{
    Popularity,
    Appearance,
    Athletics,
    Poise,
    Intelligence
}

public partial class StatList : Resource
{
    public Dictionary<StatType, Stat> dict;
    Stat pop, appear, athle, poise, intel;
    
    public StatList()
    {
        pop = new Stat(StatType.Popularity, 1200, 75);
        appear = new Stat(StatType.Appearance, 1200, 90);
        athle = new Stat(StatType.Athletics, 1200, 50);
        poise = new Stat(StatType.Poise, 1200, 100);
        intel = new Stat(StatType.Intelligence, 1200, 109);

        BuildDictionary();
    }

    public void BuildDictionary()
    {
        dict = new Dictionary<StatType, Stat>();

        dict.Add(StatType.Popularity, pop);
        dict.Add(StatType.Appearance, appear);
        dict.Add(StatType.Athletics, athle);
        dict.Add(StatType.Poise, poise);
        dict.Add(StatType.Intelligence, intel);
    }
}
