using Godot;
using System;
using System.Collections.Generic;

public class Week : TimeUnit
{
	public List<Turn> TurnsInWeek = new List<Turn>();

	public Week(int number)
	{
		Number = number;
	}
}
