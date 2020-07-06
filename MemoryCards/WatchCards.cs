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
    public partial class WatchCards : Form
    {
        private MainForm mainForm;
        public WatchCards()
        {
            InitializeComponent();
        }

        public WatchCards(Form owner)
        {
            mainForm = owner as MainForm;
            InitializeComponent();
        }

        public void LoadCards()
        {
            List<CardModel> cards = DBAccess.LoadCards();
            foreach (CardModel card in cards)
            {
                RowStyle temp = tableLayoutPanel.RowStyles[tableLayoutPanel.RowCount - 1];
                tableLayoutPanel.RowCount++;
                tableLayoutPanel.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));

                Label firstPage = new Label() { Text = card.FirstPage };
                firstPage.Click += new EventHandler(WatchACard);
                firstPage.Name = "firP#" + card.ID;

                Label secondPage = new Label() { Text = card.Due };
                secondPage.Click += new EventHandler(WatchACard);
                firstPage.Name = "secP#" + card.ID;

                tableLayoutPanel.Controls.Add(firstPage, 0, tableLayoutPanel.RowCount - 1);
                tableLayoutPanel.Controls.Add(secondPage, 1, tableLayoutPanel.RowCount - 1);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void WatchACard(object sender, EventArgs e)
        {
            Label label = sender as Label;
            CardModel nullCard = new CardModel();
            Console.WriteLine(label.Name);
            nullCard.ID = Int32.Parse(label.Name.Substring(5));
            CardModel card = DBAccess.LoadACard(nullCard);
            textBox1.Text = card.FirstPage;
            textBox2.Text = card.SecondPage;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ShowStartPageForm(this);
        }

        private void WatchCards_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
