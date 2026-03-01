using Godot;
using System;

public partial class Energy 
{
    [Export] public int value { get; set; } = 100;
    public int maxEnergy { get; set; } = 100;
    public static Action<int> OnEnergyChanged;

    public void RaiseEnergy(int add) 
    { 
        value += add; 
        if (value > maxEnergy)
        {
            value = maxEnergy;
        }

        OnEnergyChanged?.Invoke(value);
    }

    public void LowerEnergy(int sub)
    {
        value -= sub;
        if (value < 0)
        {
            value = 0;
        }

        OnEnergyChanged?.Invoke(value);
    }

    public int GetRiskValue()
    {
        if (value >= 50) { return 0; }
        if (value <= 10) { return 99; }

        float temp = (50 - value) / 40;
        float riskValue = temp * temp;

        return Mathf.RoundToInt(riskValue * 99);
    }

    public void RaiseMaxEnergy(int add) { maxEnergy += add; }
}
