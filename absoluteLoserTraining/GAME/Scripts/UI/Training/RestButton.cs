using Godot;
using System;

public partial class RestButton : ActionButton
{
    public override void OnPressed()
    {
        manager.energy.Rest();
        base.OnPressed();
    }
}
