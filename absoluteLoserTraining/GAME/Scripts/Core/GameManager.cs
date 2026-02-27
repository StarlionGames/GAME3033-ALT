using Godot;
using System;
/// <summary>
/// The bottom layer of everything in the game. controls audio and gameplay errors.
/// </summary>
public partial class GameManager : Node
{
	public static GameManager Instance;
	public Timekeeper timekeeper;
	
	public static Action<GameManager> OnReady;

	public override void _Ready(){
		if(Instance == null)
		{
			Instance = this;
		}

		timekeeper = GetNode<Timekeeper>("Timekeeper");

		GD.Print("Game manager ready");
		OnReady?.Invoke(this);
	}
	
	public void DoSomething(){
		GD.Print("hi");
	}
}
