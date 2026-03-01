using Godot;
using System;

public partial class Character : Node
{
    public StatList list { get; private set; }
    public override void _Ready()
    {
        list = new StatList();
    }

    public Stat GetStatByType(StatType type)
    {
        if (list.dict == null) { list.BuildDictionary(); }

        return list.dict[type];
    }
}
