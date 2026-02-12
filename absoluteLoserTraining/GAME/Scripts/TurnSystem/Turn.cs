using Godot;
using System;
using System.Collections.Generic;

public class Turn : TimeUnit
{
	public bool TurnCompleted = false;

	public Turn(int number)
	{
		Number = number;
	}
}
