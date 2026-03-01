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

        if (roll <= 20) { energyReplenished = 20; }
        if (roll <= 80 && roll > 20) { energyReplenished = 50; }

        else energyReplenished = 70;

        _energy.RaiseEnergy(energyReplenished);
    }
}
