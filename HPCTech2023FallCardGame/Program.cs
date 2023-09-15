using HPCTech2023FallCardGame;
using System.Collections;

Deck deck = new Deck();

Console.Write("Enter player name: ");
Player player = new Player(Console.ReadLine()!);

player.Hand = deck.DealCards(5);
player.ShowHand();

bool quitGame = false;
do
{
    Console.Write("How many cards would you like to discard (Q to quit): ");
    string replaceCards = Console.ReadLine()!;
    if (Int32.TryParse(replaceCards, out int numOfCardToReplace))
    {
        //for (int replaceCardCounter=0; replaceCardCounter < numOfCardToReplace; replaceCardCounter++)
        //{
        Console.Write("List which cards to replace (1-5), seperate by comma: ");
        string replacementCard = Console.ReadLine()!;
        string[] listOfReplacementCards = replacementCard.Split(',');
        for (int replaceCardCounter = 0; replaceCardCounter < listOfReplacementCards.Length; replaceCardCounter++) { 
            if (int.TryParse(listOfReplacementCards[replaceCardCounter], out int replacementNum))
            {
                player.Hand[replacementNum - 1] = deck.DealCards(1).FirstOrDefault()!;
            }
        }
        quitGame = true;
    }
    else if (replaceCards.ToLower() == "q")
    {
        quitGame = true;
    }
    else
    {
        Console.WriteLine("Invalid Input");
    }
} while (!quitGame);

player.ShowHand();