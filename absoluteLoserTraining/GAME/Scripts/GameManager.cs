using Godot;
using System;

public partial class GameManager : Node
{
	public override void _Ready(){
		GD.Print("GameManager ready");
	}
	
	public void DoSomething(){
		GD.Print("hi");
	}
}
