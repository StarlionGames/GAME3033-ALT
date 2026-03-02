using Godot;
using System;

public partial class StatButton : ActionButton
{
    [Export] StatType type;
    Stat _stat;

    public override void _Ready()
    {
        _stat = GameManager.Instance.character.GetStatByType(type);

        _text = _stat.Name;
        base._Ready();
    }

    public override void OnPressed()
    {
        if (!manager.energy.DidTrainingFail())
        {
            manager.energy.Training(type);
            _stat.RaiseStat(5);
        }
        base.OnPressed();
    }
}
