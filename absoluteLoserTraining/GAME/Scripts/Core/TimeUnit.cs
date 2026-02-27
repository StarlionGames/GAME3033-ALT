using Godot;
using System;

public abstract class TimeUnit
{
    public int Number;

    public Action Start;
    public Action End;

    public void Begin() { Start?.Invoke(); }
    public void Finish() { End?.Invoke(); }
}
