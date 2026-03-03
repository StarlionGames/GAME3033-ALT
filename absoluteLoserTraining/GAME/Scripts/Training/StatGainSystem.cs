using Godot;
using System;

public partial class StatGainSystem : Node
{
    RandomNumberGenerator rng = new RandomNumberGenerator();
    Character chara;
    public override void _EnterTree()
    {
        base._EnterTree();
        GameManager.OnReady += GetGameManager;
    }
    public override void _ExitTree()
    {
        base._ExitTree();
        GameManager.OnReady -= GetGameManager;
    }

    int CalculateTotalGain() // TODO: will add modifiers to this... some other time
    {
        int baseStatGain = 15;
        int totalGain = 0;

        // TODO: replace mult with modifiers later on
        float mult = rng.RandfRange(0.1f, 0.75f);

        totalGain = Mathf.RoundToInt(baseStatGain * mult) + baseStatGain;
        return totalGain;
    }

    public void RandomStatGain(StatType type)
    {
        Stat stat = chara.GetStatByType(type);

        stat.RaiseStat(CalculateTotalGain());
    }

    public void GetGameManager(GameManager m) => chara = m.character;
}
