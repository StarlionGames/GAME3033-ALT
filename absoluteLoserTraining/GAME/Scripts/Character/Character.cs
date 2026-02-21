using Godot;
using System;

public partial class Character : Node
{
    public static Character Instance { get; private set; }
    public StatList list { get; private set; }
}
