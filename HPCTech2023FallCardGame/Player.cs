using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCTech2023FallCardGame;

public class Player
{
    public string Name { get; set; }
    public List<Card> Hand { get; set; } = new List<Card>();

    public Player(string _name)
    {
        this.Name = _name;
    }

    public void ShowHand()
    {
        int pos = 1;
        string cardPos = string.Empty;
        foreach (Card card in Hand)
        {
            Console.Write($"{card.ToString()}\t");
            cardPos += $"{pos++}\t";
        }
        Console.WriteLine($"\n{cardPos}");
    }
}
