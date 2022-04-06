using System;
using System.Collections.Generic;

public class SupportSkill : Cards
{
	public enum effectType { ReduceAP, ReduceRP, ReduceAll, DestroyEquip, RestoreRP }

	private int effectPoints;

	public int EffectPoints
    {
		get { return effectPoints; }
		set { effectPoints = value; }
    }

	public string EffectType
    {
		get { return effectType; }
		set { effectType = value; }
    }


	public SupportSkill(int effectPoints,effectType,string name,int costPoints) : base(name,costPoints)
	{
		this.EffectType = effectType;
		EffectPoints = effectPoints;
	}
}
