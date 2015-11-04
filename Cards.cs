using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cards : Program
    {
        private int rank;
        private int suit;
        public Cards(int rankin , int suitin)
        {
            rank = rankin;
            suit = suitin;
        }

        public int getRank()
        {
            return rank;
        }

        public string nameRank()
        {
            switch(rank)
            {
                case 1:return "A-";
                case 11:return "J-";
                case 12:return "Q-";
                case 13:return "K-";
                default: return Convert.ToString(rank)+"-";
            }
        }
        public string nameSuit()
        {
            switch (suit)
            {
                case 1: return "Clubs";
                case 2: return "Dimonds";
                case 3: return "Hearts";
                case 4: return "Spades";
                default: return " ";
            }
        }
    }
}
