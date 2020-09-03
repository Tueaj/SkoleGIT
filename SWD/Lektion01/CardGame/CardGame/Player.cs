using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Player
    {
        public string Name_ { get; private set; }
        private List<int[]> Hand { get; set; }

        public Player(string Name) {
            Name_ = Name;
        }

        public  void GetCard(int color, int number)
        {
            int[] card = new int[] { color, number };
            Hand.Add(card);
        }

        public int tellValue()
        {
            int sum = 0;
            for(int i = 0; i < Hand.Count; i++)
            {
                int[] card = Hand[i];
                sum += card[0] * card[1];
            }
            return sum;
        }

        public void showHand()
        {
            for(int i = 0; i < Hand.Count; i++)
            {
                int[] card = Hand[i];
                if (card[0] == 1)
                    Console.WriteLine("Card #{0} : Red {1}", i, Hand[1]);
                else if (card[0] == 2)
                    Console.WriteLine("Card #{0} : Blue {1}", i, Hand[1]);
                else if (card[0] == 3)
                    Console.WriteLine("Card #{0} : Green {1}", i, Hand[1]);
                else if (card[0] == 4)
                    Console.WriteLine("Card #{0} : Yellow {1}", i, Hand[1]);
                else
                    Console.WriteLine("Card #{0} is broken", i);
            }
        }
    }
}
