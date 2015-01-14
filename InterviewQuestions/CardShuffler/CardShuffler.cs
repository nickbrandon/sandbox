using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffler
{
    class CardShuffler
    {

        static Random _random = new Random();

        
        static void Main(string[] args)
        {
            var deckList = new int[52];
            
            for (int i = 0; i < 52; i++)
            {
                deckList[i] = i;
            }

            Shuffle(deckList);

            for (int i = 0; i < deckList.Length; i++)
            {
                Console.WriteLine(deckList[i]);
            }

        }

        static void Shuffle<T>(T[] deck) //(List<Card> deck)
        {
            int n = deck.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int) (_random.NextDouble()*(n - i));
                T t = deck[r];
                deck[r] = deck[i];
                deck[i] = t;
            }
        }
    }

    internal class Card
    {

    }
}
