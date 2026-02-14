using Godot;
using System;
/// <summary>
/// The bottom layer of everything in the game. controls audio and gameplay errors.
/// </summary>
public partial class GameManager : Node
{	
	
	
	public override void _Ready(){
		GD.Print("GameManager ready");
	}
	
	public void DoSomething(){
		GD.Print("hi");
	}
}
