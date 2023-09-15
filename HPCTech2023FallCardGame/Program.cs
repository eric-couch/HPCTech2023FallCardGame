using HPCTech2023FallCardGame;
using System.Collections;

Deck deck = new Deck();

Console.Write("Enter player name: ");
Player player = new Player(Console.ReadLine()!);

player.Hand = deck.DealCards(5);
player.ShowHand();


