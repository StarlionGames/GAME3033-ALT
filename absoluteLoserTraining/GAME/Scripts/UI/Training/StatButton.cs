using Antlr4.Runtime.Tree.Xpath;
using Godot;
using System;

public partial class StatButton : Button
{
    [Export] StatType type;
    Stat _stat;

    [Export] NodePath name;
    Label nameField;

    Timekeeper timekeeper;

    public override void _EnterTree()
    {
        base._EnterTree();
        Timekeeper.OnReady += GetTimekeeper;
    }

    public override void _ExitTree()
    {
        base._ExitTree();
        Timekeeper.OnReady -= GetTimekeeper;
    }

    public override void _Ready()
    {
        _stat = Character.Instance.GetStatByType(type);

        nameField = GetNode<Label>(name);
 
        nameField.Text = _stat.Nickname;
        Pressed += OnPressed;
    }

    public void OnPressed()
    {
        _stat.RaiseStat(5); // placeholder
        timekeeper.EndCurrentTurn();
        // TODO: add energy depletion | random value
    }
    public void GetTimekeeper(Timekeeper time) => timekeeper = time;
}
