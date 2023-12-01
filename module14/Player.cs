using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module14
{
    public class Player
    {
        public string Name { get; private set; }
        public Queue<Card> Cards { get; private set; }

        public Player(string name)
        {
            Name = name;
            Cards = new Queue<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Enqueue(card);
        }

        public Card PlayCard()
        {
            return Cards.Count > 0 ? Cards.Dequeue() : null;
        }

        public override string ToString()
        {
            return Name;
        }
    }

}
