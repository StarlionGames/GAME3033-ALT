using Godot;
using System;

public partial class Character : Node
{
    public static Character Instance { get; private set; }
    public StatList list { get; private set; }

    public override void _Ready()
    {
        Instance = this;

        list = new StatList(); 
    }

    public Stat GetStatByType(StatType type)
    {
        if (list.dict == null) { list.BuildDictionary(); }

        return list.dict[type];
    }
}
