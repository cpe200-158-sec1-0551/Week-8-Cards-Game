using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player : Program
    {
        private List<Cards> deck;
        private List<Cards> pile;
        private string name;

        public Player(string namein)
        {
            name = namein;
            deck = new List<Cards>();
            pile = new List<Cards>();
        }

        public void addCard(Cards cardin)
        {
            deck.Add(cardin);
        }

        public int getNumdeck()
        {
            return deck.Count;
        }

        public Cards Draw()
        {
            Cards temp = deck[0];
            deck.RemoveAt(0);
            return temp;
        }

        public void addPile(Cards cardin)
        {
            pile.Add(cardin);
        }

        static List<Cards> ShuffleList(List<Cards> inputList)
        {
            List<Cards> randomList = new List<Cards>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count);
                randomList.Add(inputList[randomIndex]);
                inputList.RemoveAt(randomIndex);
            }

            return randomList;
        }

        public void deckShuff()
        {
            deck = ShuffleList(deck);
        }

        public string getName()
        {
            return name;
        }
        public int getNumPile()
        {
            return pile.Count;
        }
    }
}
