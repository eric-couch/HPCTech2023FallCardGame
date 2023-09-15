using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCTech2023FallCardGame;

public class Card
{
    public string suit { get; set; }    //syntactical sugar or a very easy way to do something that's commonly done
    public string rank { get; set; }    // 8, 9, 10, j, q, k, a
    public int val { get; set; }        // 8, 9, 10, 11, 12, 13, 14

    /// <summary>
    /// This is a card class for creating playing cards (games)
    /// </summary>
    /// <param name="suit">♦, ♣, ♠, ♥</param>
    /// <param name="rank">2, 3, 4, 5... 10, J, Q, K, A</param>
    /// <param name="val">2, 3, 4, 5... 10, 11, 12, 13, 14</param>
    public Card(string suit, string rank, int val)
    {
        this.suit = suit;
        this.rank = rank;
        this.val = val;
    }

    public override string? ToString()
    {
        return $"{rank}{suit}";
    }
}
