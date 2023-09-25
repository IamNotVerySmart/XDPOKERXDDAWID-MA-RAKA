// See https://aka.ms/new-console-template for more information
using pokerXD;
using System.Drawing;

List<cards> deck = new List<cards>();
string[] color = { "kier", "pik", "trefl", "karo" };
string[] value = { "9", "10", "J", "Q", "K", "A" };
List<cards> player1 = new List<cards>();
List<cards> player2 = new List<cards>();

Random random = new Random();

for (int i = 0; i < color.Length; i++)
{
    //string tmp1 = color[i];
    for (int j = 0; j < value.Length; j++)
    {
        //string tmp2 = value[j];
        cards card = new cards(value[j], color[i]);
        deck.Add(card);
    }
}

void Shuffle()
{
    for (int i = 0; i < 5; i++)
    {
        int tmp = random.Next(deck.Count());
        player1.Add(deck[tmp]);
        deck.RemoveAt(tmp);
    }
    for(int i = 0; i < 5; i++)
    {
        int tmp = random.Next(deck.Count());
        player2.Add(deck[tmp]);
        deck.RemoveAt(tmp);
    }
}
Shuffle();
//deck.Add(card);
Console.WriteLine("Player 1 cards: ");
foreach (cards n in player1)
{
    Console.WriteLine(n.ToString());
}
Console.WriteLine("Player 2 cards: ");
foreach (cards n in player2)
{
    Console.WriteLine(n.ToString());
}
