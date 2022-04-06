using System;
using System.Collections.Generic;

public class Cards 
{
	public enum affinity { Knight, Mage, Undead}

	public enum rarity { Common, Rare, SuperRare, UltrarRare };

	private string name;

	private int costPoints;

	public string Rarity
    {
		get { return name; }
		set { name = value; }
    }

	public string Affinity
    {
		get { return affinity; }
		set { affinity = value; }
    }


	public Cards(int costPoints,string name,rarity,affinity)
    {
		Rarity = rarity;
		Affinity = affinity;
		this.name = name;
		this.costPoints = costPoints;
    }
}
	