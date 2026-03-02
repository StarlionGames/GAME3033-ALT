using Godot;
using System;

public partial class EnergySystem : Node
{
    RandomNumberGenerator rng = new RandomNumberGenerator();
    protected Energy _energy = new Energy();

    public void Rest()
    {
        int roll = rng.RandiRange(1, 100);
        int energyReplenished;

        // low roll | low energy gain
        if (roll <= 20) { energyReplenished = 20; }
        // average energy gain
        if (roll <= 80 && roll > 20) { energyReplenished = 50; }
        // high roll | high energy gain
        else energyReplenished = 70;

        GD.Print("you replenished " + energyReplenished + " energy");
        _energy.RaiseEnergy(energyReplenished);
    }

    public bool DidTrainingFail()
    {
        int roll = rng.RandiRange(1, 100);
        int risk = _energy.GetRiskValue();

        if (roll <= risk) { GD.Print("training failed!"); return true; }
        
        return false;
    }

    public void Training(StatType type)
    {
        int baseEnergyLoss = 15;
        float mult = 0;

        switch (type)
        {
            case StatType.Popularity: mult = 0.4f; break;
            case StatType.Appearance: mult = 0.2f; break;
            case StatType.Athletics: mult = 0.75f; break;
            case StatType.Poise: mult = 0.6f; break;
            case StatType.Intelligence: _energy.RaiseEnergy(5); return;

            default: break;
        }

        int totalLoss = Mathf.RoundToInt((baseEnergyLoss * mult) + baseEnergyLoss);
        _energy.LowerEnergy(totalLoss);
    }
}
