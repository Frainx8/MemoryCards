using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCards
{
    public partial class ShowFirstPage : Form
    {
        private MainForm mainForm;
        private List<CardModel> todaysCards = new List<CardModel>();
        private CardModel cardToPass;
        private bool IsShowed;
        public ShowFirstPage(Form owner)
        {
            mainForm = owner as MainForm;
            InitializeComponent();
        }
        public ShowFirstPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ShowStartPageForm(this);
            ClearTodaysCards();
        }

        public void ClearTodaysCards()
        {
            todaysCards.Clear();
        }

        public void DeleteFromtodaysCards(CardModel card)
        {
            todaysCards.Remove(card);
        }

        public void LoadTodaysCards()
        {
            List<CardModel> cards = DBAccess.LoadCards();
            if(cards.Count == 0)
            {
                labelFirstPage.Text = "У вас совсем нет карточек! Добавьте их!";
                IsShowed = false;
            }
            else
            {
                foreach (CardModel card in cards)
                {
                    if (DateTime.Compare(Convert.ToDateTime(card.Due), DateTime.Now) <= 0)
                    {
                        todaysCards.Add(card);
                    }
                }
                if(todaysCards.Count == 0)
                {
                    labelFirstPage.Text = "Вы выучили все карточки на сегодня!";
                    IsShowed = false;
                }
                else
                {
                    ShowACard();
                    IsShowed = true;
                }
            }
        }

        public void ShowACard()
        {
            Random rnd = new Random();
            int index = rnd.Next(todaysCards.Count);
            labelFirstPage.Text = todaysCards[index].FirstPage;
            cardToPass = todaysCards[index];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsShowed == true)
            {
                mainForm.ShowACardForm(this, cardToPass);
            }
        }
    }
}
