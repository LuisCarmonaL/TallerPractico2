using System;
using System.Collections.Generic;

public class Deck
{
	private List<Card> cards = new List<Card>();
	private int costPoints;

	public int CostPoints
    {
		get { return costPoints; }
		set { costPoints = value; }
    }

	public int Cards
    {
		get { return cards; }
		set { cards = value; }
    }

	public Deck(List<Card> cards, int costPoints)
	{
		this.Cards = cards;
		this.CostPoints = costPoints;
	}

	public int DestroyDeck()
    {
		DestroyDeck();
    }
}
