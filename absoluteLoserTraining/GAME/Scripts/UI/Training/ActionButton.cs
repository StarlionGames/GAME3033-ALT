using Godot;
using System;

public partial class ActionButton : Button
{
    [Export] NodePath name;
    [Export] protected string _text;
    Label nameField;

    protected TrainingManager manager;
    Timekeeper timekeeper;

    public override void _EnterTree()
    {
        TrainingManager.OnReady += GetTrainingManager;
        Timekeeper.OnReady += GetTimekeeper;
    }

    public override void _ExitTree()
    {
        TrainingManager.OnReady -= GetTrainingManager;
        Timekeeper.OnReady -= GetTimekeeper;
        Pressed -= OnPressed;
    }
    public override void _Ready()
    {
        nameField = GetNode<Label>(name);

        nameField.Text = _text;
        Pressed += OnPressed;
    }

    public virtual void OnPressed()
    {
        timekeeper.EndCurrentTurn();
        // TODO: add energy depletion | random value
    }
    public void GetTimekeeper(Timekeeper time) => timekeeper = time;
    public void GetTrainingManager(TrainingManager train) => manager = train;
}
