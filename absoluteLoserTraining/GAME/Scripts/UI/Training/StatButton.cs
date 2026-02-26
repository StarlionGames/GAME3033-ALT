using Antlr4.Runtime.Tree.Xpath;
using Godot;
using System;

public partial class StatButton : Button
{
    [Export] StatType type;
    Stat _stat;

    [Export] NodePath name;
    Label nameField;

    public override void _Ready()
    {
        _stat = Character.Instance.GetStatByType(type);

        nameField = GetNode<Label>(name);
 
        nameField.Text = _stat.Name;

        Pressed += OnPressed;
    }

    public void OnPressed()
    {
        _stat.RaiseStat(5); // placeholder
        // TODO: add energy depletion | random value
    }
}
