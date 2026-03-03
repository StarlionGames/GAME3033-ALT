using Godot;
using System;

public partial class TrainingManager : Node
{
    public static TrainingManager Instance { get; private set; }
    public EnergySystem energy;
    public StatGainSystem statGain;

    public static Action<TrainingManager> OnReady;
    public override void _Ready()
    {
        energy = GetNode<EnergySystem>("Energy");
        statGain = GetNode<StatGainSystem>("StatGain");

        OnReady?.Invoke(this);
    }
}
