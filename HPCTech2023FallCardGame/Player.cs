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
        foreach (Card card in Hand)
        {
            Console.Write($"{card.ToString()}\t");
        }
        Console.WriteLine();
    }
}
