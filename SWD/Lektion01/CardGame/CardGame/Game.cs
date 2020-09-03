using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Game
    {
        public List<Player> Players { get; private set; }
        public Deck Deck_ { get; private set; }
        public Game(int amount)
        {
            int amount_ = (amount > 0 ? amount : 0);
            for (int i = 0; i < amount_; i++)
            {
                Console.WriteLine("Enter name of player#{0}:", i + 1);
                string name_ = Console.ReadLine();
                Players.Add(new Player(name_));
            }
            Console.WriteLine("Enter amount of cards :");
            int numbercards = int.Parse(Console.ReadLine());
            if(numbercards > 0)
            {
                Deck_ = new Deck(numbercards * amount_);
                List<Cards> cards_ = Deck_.giveCards(numbercards);
                for (int i = 0; i < amount_; i++)
                {
                    for (int x = 0; x < numbercards; x++)
                    {
                        Players[i].GetCard(cards_[x].color_, cards_[x].number_);
                    }                   
                }
            }
        }

    }
}
