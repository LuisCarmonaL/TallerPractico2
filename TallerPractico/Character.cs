using System;

public class Character : Cards
{
	public int attackPoints = 0;
	public int resistPoints = 0;

	private int BattackPoints;
	private int BresistPoints;

	public int ap
    {
		get => BattackPoints;
		private set => BattackPoints = value;
    }

	public int rp
    {
		get => resistPoints;
		private set => resistPoints = value;
    }


	public Character()
	{
		ap = attackPoints;
		rp = resistPoints;
	}
}
