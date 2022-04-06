using System;

public class SupportSkill	
{
	public enum effectType { ReduceAP, ReduceRP, ReduceAll, DestroyEquip, RestoreRP }

	private int effectPoints;

	public int EffectPoints
    {
		get { return effectPoints; }
		set { effectPoints = value; }
    }

	public string effectType
    {
		get { return effectType; }
		set { effectType = value; }
    }


	public SupportSkill()
	{
		EffectType = effectType;
		EffectPoints = effectPoints;
	}
}
