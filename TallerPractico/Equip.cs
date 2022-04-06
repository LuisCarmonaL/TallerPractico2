using System;
using System.Collections.Generic;

public class Equip : Cards
{
	public enum targetAtributte { AP, RP, ALL }

	public int effectPoints = 0;



	public int EffectPoints
    {
		get { return effectPoints; }
		set { effectPoints = value; }
    }

	public string Affinity
    {
		get { return affinity; }
		set { affinity = value; }
    }

	public string TargetAtributte
    {
		get { return targetAtributte; }
		set { targetAtributte = value; }
    }

	public Equip(int effectPoints, targetAtributte, string name, int costPoints) : base(name, costPoints)
	{
		EffectPoints = effectPoints;
		Affinity = affinity;
		TargetAtributte = targetAtributte;
	}
}
