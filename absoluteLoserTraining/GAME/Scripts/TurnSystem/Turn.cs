using Godot;
using System;

public class Turn
{
	public Turn()
	{

	}
	
	public bool TurnCompleted = false;

	public void TurnActionChosen() => TurnCompleted = true;
}
