using System;

public class Equip : Cards
{
	public enum targetAtributte { AP, RP, ALL }



	public int EffectPoints
    {
		get { return EffectPoints; }
		set { EffectPoints = value; }
    }

	public string affinity
    {
		get { return affinity; }
		set { affinity = value; }
    }

	public string targetAtribute
    {
		get { return targetAtribute; }
		set { targetAtribute = value; }
    }

	public Equip()
	{
		EffectPoints = effectPoints;
		affinity = affinity;
		targetAtribute = targetAtribute;
	}
}
