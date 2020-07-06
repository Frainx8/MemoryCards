using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCards
{
    public class CardModel
    {
        public int ID { get; set; }
        public string FirstPage { get; set; }
        public string SecondPage { get; set; }
        public string Due { get; set; }
        public int Group { get; set; }

        public CardModel()
        {

        }

        public CardModel(int ID, string FirstPage, string SecondPage, string Due, int Group)
        {
            this.ID = ID;
            this.FirstPage = FirstPage;
            this.SecondPage = SecondPage;
            this.Due = Due;
            this.Group = Group;
        }
    }
}
