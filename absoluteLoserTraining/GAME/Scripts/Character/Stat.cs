using Godot;
using System;

public partial class Stat
{
    public string Name { get; private set; }
    public int minValue = 0;
    public int maxValue;
    public int Value { get; private set; }

    public Action<int> OnValueChanged;

    public Stat(string name, int maxVal, int startVal)
    {
        Name = name;
        maxValue = maxVal;
        Value = startVal;
    }

    public void RaiseStat(int addition)
    {
        Value += addition;
        if (Value > maxValue) Value = maxValue;
        
        OnValueChanged?.Invoke(Value);
    }

    public void LowerStat(int subtract)
    {
        Value -= subtract;
        if (Value < minValue) Value = minValue;

        OnValueChanged?.Invoke(Value);
    }
}
