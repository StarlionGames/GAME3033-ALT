using Godot;
using System;

[GlobalClass]
public partial class Stat : Resource
{
    public string Name { get; private set; }
    public StatType _Type { get; private set; }
    public int minValue = 0;
    public int maxValue;
    public int Value { get; private set; }

    public Action<int> OnValueChanged;

    public Stat(StatType type, int maxVal, int startVal)
    {
        _Type = type;
        Name = type.ToString();
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
