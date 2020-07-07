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
    public partial class ShowACard : Form
    {
        private MainForm mainForm;
        public CardModel Card { get; set; }
        private ShowFirstPage showFirstPage;
        public ShowACard()
        {
            InitializeComponent();
        }

        public ShowACard(Form owner, ShowFirstPage showFirstPage)
        {
            mainForm = owner as MainForm;
            this.showFirstPage = showFirstPage;
            InitializeComponent();
        }

        public void ShowTheCard()
        {
            labelFirstPage.Text = Card.FirstPage;
            labelSecondPage.Text = Card.SecondPage;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ShowStartPageForm(this);
        }

        private void btnDontRem_Click(object sender, EventArgs e)
        {
            Card.CardGroup = 1;
            Card.Due = DateTime.Now.ToString("dd.MM.yy");
            DBAccess.UpdateCard(Card, 'g');

            mainForm.ShowFirstPageForm(this);
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            Card.CardGroup++;
            if(Card.CardGroup == 2)
            {
                DateTime date = DateTime.Now.AddDays(3);
                Card.Due = date.ToString("dd.MM.yy");
            }
            else
            {
                DateTime date = DateTime.Now.AddDays(5);
                Card.Due = date.ToString("dd.MM.yy");
            }
            
            DBAccess.UpdateCard(Card, 'g');

            showFirstPage.DeleteFromtodaysCards(Card);

            mainForm.ShowFirstPageForm(this);
        }
    }
}
