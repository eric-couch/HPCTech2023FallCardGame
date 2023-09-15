using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCTech2023FallCardGame;
public class Deck
{
    public List<Card> Cards { get; set; } = new List<Card>();

    public Deck()
    {
        ResetDeck();
    }

    public List<Card> DealCards(int numOfCardToDeal)
    {
        List<Card> cardsDealt = new List<Card>();
        Random rnd = new Random();
        for (int cardsToDeal = 0; cardsToDeal < numOfCardToDeal; cardsToDeal++)
        {
            int cardToDeal = rnd.Next(Cards.Count);
            Card dealCard = Cards[cardToDeal];
            cardsDealt.Add(dealCard);
            Cards.RemoveAt(cardToDeal);
        }
        return cardsDealt;
    }



    public void ResetDeck()
    {
        Cards.Clear();
        List<string> suits = new List<string>() { "♥", "♦", "♣", "♠" };
        List<string> ranks = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        List<int> values = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                Card card = new Card(suit, rank, values[ranks.IndexOf(rank)]);
                Cards.Add(card);
            }
        }

    }

}
