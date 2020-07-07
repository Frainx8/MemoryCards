using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCards
{
    public class CardModel : IEquatable<CardModel>
    {
        public int ID { get; set; }
        public string FirstPage { get; set; }
        public string SecondPage { get; set; }
        public string Due { get; set; }
        private int cardGroup;
        public int CardGroup
        {
            get
            {
                return cardGroup;
            }
            set
            {
                if(value < 0)
                {
                    cardGroup = 1;
                }
                else if(value > 3)
                {
                    cardGroup = 3;
                }
                else
                {
                    cardGroup = value;
                }
            }
        }

        public CardModel()
        {

        }

        public CardModel(int ID, string FirstPage, string SecondPage, string Due, int CardGroup)
        {
            this.ID = ID;
            this.FirstPage = FirstPage;
            this.SecondPage = SecondPage;
            this.Due = Due;
            this.CardGroup = CardGroup;
        }

        public bool Equals(CardModel other)
        {
            if (other == null)
            {
                return false;
            }
            else if (ID == other.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
