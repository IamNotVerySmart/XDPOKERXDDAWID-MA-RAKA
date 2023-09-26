namespace pokerXD
{
    internal class deck
    {
        //public List<cards> decks = new List<cards>();

        //List<cards> Deck = new List<cards>();
        string[] color = { "kier", "pik", "trefl", "karo" };
        string[] value = { "9", "10", "J", "Q", "K", "A" };
        List<cards> player1 = new List<cards>();
        List<cards> player2 = new List<cards>();
        int drawn;

        Random random = new Random();

        public void FillDeck(List<cards> deck1)
        {
            for (int i = 0; i < color.Length; i++)
            {
                //string tmp1 = color[i];
                for (int j = 0; j < value.Length; j++)
                {
                    //string tmp2 = value[j];
                    cards card = new cards(value[j], color[i]);
                    deck1.Add(card);
                }
            }
        }
        public void Deal(List<cards> deck1, List<cards> player1, List<cards> player2)
        {
            for (int i = 0; i < 5; i++)
            {
                int tmp = random.Next(deck1.Count());
                player1.Add(deck1[tmp]);
                deck1.RemoveAt(tmp);
            }
            for (int i = 0; i < 5; i++)
            {
                int tmp = random.Next(deck1.Count());
                player2.Add(deck1[tmp]);
                deck1.RemoveAt(tmp);
            }
        }

        public void Shuffle(List<cards> deck1)
        {
            int tmp = deck1.Count();
            while(tmp > 1)
            {
                tmp--;
                int rng = random.Next(tmp + 1);
                cards value = deck1[rng];
                deck1[rng] = deck1[tmp];
                deck1[tmp] = value;
            }
        }
        public void Draw(List<cards> deck1, List<cards> player)
        {
            int t = 1;
            Console.WriteLine("========================================");
            Console.WriteLine("How much cards you want to draw?");
            if(int.TryParse(Console.ReadLine(), out int tmp) && tmp <= player.Count())
            {
                for(int i = 0; i < player.Count(); i++)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine($"Which card you want to draw?(chose 1-{player.Count()})");
                    Console.WriteLine("Player hand: ");
                    foreach (cards n in player)
                    {
                        Console.WriteLine($"[{t}] " + n.ToString());
                        t++;
                    }
                    if (int.TryParse(Console.ReadLine(), out int tmp1))
                    {
                        t = 1;
                        int rng = random.Next(deck1.Count());
                        player.RemoveAt(tmp1 - 1);
                        player.Add(deck1[rng]);
                        deck1.RemoveAt(rng);
                        drawn++;

                        Console.WriteLine("========================================");
                        Console.WriteLine("Player hand: ");
                        foreach (cards n in player)
                        {
                            Console.WriteLine($"[{t}] " + n.ToString());
                            t++;
                        }
                    }
                }
            }
            

            
        }
    }
}
