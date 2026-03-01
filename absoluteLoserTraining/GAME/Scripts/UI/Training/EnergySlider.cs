using Godot;
using System;

public partial class EnergySlider : ProgressBar
{
    public override void _EnterTree()
    {
        base._EnterTree();
        Energy.OnEnergyChanged += UpdateSlider;
    }
    public override void _ExitTree()
    {
        base._ExitTree();
        Energy.OnEnergyChanged -= UpdateSlider;
    }
    
    public void UpdateSlider(int newValue)
    {
        Value = newValue;
    }
}
