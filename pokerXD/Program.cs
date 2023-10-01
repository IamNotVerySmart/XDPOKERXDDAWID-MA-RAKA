using pokerXD;
using System.Numerics;

deck deck = new deck();
List<cards> deck1 = new List<cards>();
List<cards> player1 = new List<cards>();
List<cards> player2 = new List<cards>();
int t = 1;

deck.FillDeck(deck1);
deck.Shuffle(deck1);
deck.Deal(deck1, player1, player2);
/*foreach (cards n in deck1)
{
    Console.WriteLine(n.ToString());
}*/
//deck.Add(card);
Console.WriteLine("player1 cards: ");
foreach (cards n in player1)
{
    Console.WriteLine($"[{t}] " + n.ToString());
    t++;
}
Console.WriteLine("========================================");
Console.WriteLine("Do you want to draw? (y/n)");
if(Console.ReadLine() == "y")
{
    deck.Draw(deck1, player1);
}
if(Console.ReadLine() == "n")
{

}

/*Console.WriteLine("Player 1 cards: ");
foreach (cards n in player1)
{
    Console.WriteLine(n.ToString());
}
Console.WriteLine("Player 2 cards: ");
foreach (cards n in player2)
{
    Console.WriteLine(n.ToString());
}*/
