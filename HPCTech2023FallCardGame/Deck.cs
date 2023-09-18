using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

    public bool CheckForAce()
    {
        //return Cards.Any(card => card.rank == "A");

        return Cards.Exists(card => card.rank == "A");
        //return (from card in cards
        //        where card.rank == "A"
        //        select card).Count() > 0;
    }

    public bool? HasThreeOfAKind()
    {
        try
        {
            // method syntax
            //bool? result = Cards.GroupBy(card => card.val).Any(group => group.Count() == 3);
            // query syntax
            bool? result = (from card
                         in Cards
                         group card by card.rank into g
                         select new { rank = g.Key, count = g.Count() }).Any(c => c.count == 3);


            return result;
        } catch (Exception ex)
        {
            Console.WriteLine("An error occured");
            return false;
        }
    }

    public bool IsFlush()
    {
        // five cards of the same suit is a flush
        return Cards.GroupBy(card => card.suit).Any(g => g.Count() == 5);
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
