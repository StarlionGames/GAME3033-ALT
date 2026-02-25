using Godot;
using System;

public partial class StatDisplay : Control
{
    [Export] public StatType type;
    Stat statToDisplay;

    [Export] public NodePath namePath, currPath, maxPath;
    public Label name ;
    public Label currValue, maxValue;

    public override void _Ready()
    {
        statToDisplay = Character.Instance.GetStatByType(type);
        statToDisplay.OnValueChanged += UpdateValue;

        name = GetNode<Label>(namePath);
        currValue = GetNode<Label>(currPath);
        maxValue = GetNode<Label>(maxPath);

        name.Text = statToDisplay.Name;
        currValue.Text = statToDisplay.Value.ToString();
        maxValue.Text = statToDisplay.maxValue.ToString();
    }

    public void UpdateValue(int value)
    {
        string newvalue = value.ToString();

        currValue.Text = newvalue;
    }
}
