using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
        public List<Cards> deck { get; private set; }
        public Deck(int size)
        {
            Random rand = new Random();

            for(int i = 0; i < size; i++)
            {
                deck.Add(new Cards(rand.Next(4), rand.Next(8)));
            }
        }

        public List<Cards> giveCards(int amount)
        {
            List<Cards> listC = new List<Cards>();
            for(int i=0; i < amount; i++)
            {
                listC.Add(deck[0]);
                deck.RemoveAt(0);
            }
            return listC;
        }
    }
}
