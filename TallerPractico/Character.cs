using System;

public class Character : Cards
{
	public int attackPoints = 0;
	public int resistPoints = 0;

	private int BattackPoints;
	private int BresistPoints;

	public int ap
    {
		get { return attackPoints; }
		set { attackPoints = value; }
    }

	public int rp
    {
		get { return resistPoints; }
		set { resistPoints = value; }
    }


	public Character()
	{
		ap = attackPoints;
		rp = resistPoints;
	}

	public void DecrAttackPoints(int delta)
    {
		ap -= delta;
    }

	public void DecrResistPoints (int delta)
    {
		rp -= delta;
    }

	public void IncreAttackPoints(int delta)
    {
		ap += delta;
    }

	public void IncreResistPoints (int delta)
    {
		rp += delta;
    }
}
