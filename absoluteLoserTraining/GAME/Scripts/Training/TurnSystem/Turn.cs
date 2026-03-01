using Godot;
using System;

public class Turn : TimeUnit
{
	public bool TurnCompleted = false;

	public Turn(int number)
	{
		Number = number;
	}

	public void UseTurn()
	{
		if (!TurnCompleted)
		{
			TurnCompleted = true;
			Finish();
		}
	}
	public void Reset(int num)
	{
		Number = num;
		TurnCompleted = false; 
	}
}
