using Godot;
using System;
using System.Collections.Generic;

public class Week : TimeUnit
{
	public List<Turn> TurnsInWeek = new List<Turn>();
	public Turn currTurn;

	public int index;
	public Week(int number)
	{
		Number = number;
		GenerateTurns();
	}

	void GenerateTurns()
	{
		TurnsInWeek.Clear();

		for (int i = 0; i < 3; i++) 
		{
			TurnsInWeek.Add(new Turn(i));
		}

		index = 0;
		currTurn = TurnsInWeek[0];
	}

	public Turn NextTurn()
	{
		index++;
		if (index >= TurnsInWeek.Count) { index = 0; Reset(Number++); }

		currTurn = TurnsInWeek[index];
		return currTurn;
	}

	public void Reset(int weeknum)
	{
		Number = weeknum;
		index = 0;
		foreach(var turn in TurnsInWeek)
		{
			turn.Reset(TurnsInWeek.IndexOf(turn));
		}
		Finish();
	}
}
