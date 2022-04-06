using System;
using System.Collections.Generic;

public class Character : Cards
{
	public int attackPoints = 0;
	public int resistPoints = 0;

	//private int BattackPoints;
	//private int BresistPoints;

	private list<Equip> equips;


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


	public Character(int attackPoints, int resistPoints, string name, int costPoints, rarity, affinity) : base (name,rarity,costPoints,affinity)
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

	public void UseEquip (Equip equip)
    {
		UseEquip = equip;


		string afinityCharacter = Affinity.ToString();
		string afinidadEquip = equip.Affinity.ToString();
		
		
	}

	public void RemoveEquip (Equip equip)
    {
		equips.Remove(equip);	
    }

		
}
