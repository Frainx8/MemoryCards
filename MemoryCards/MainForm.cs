using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MemoryCards
{
    public partial class MainForm : Form
    {
        public int LastID { get; set;}
        private AddACard addACardForm;
        private ShowACard showACardForm;
        private ShowFirstPage showFirstPageForm;
        private StartPage startPageForm;
        private WatchCards watchCardsForm;
        public MainForm()
        {
            startPageForm = new StartPage(this) { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            watchCardsForm = new WatchCards(this) { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            showFirstPageForm = new ShowFirstPage(this) { Dock = DockStyle.Fill, TopMost = true, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            showACardForm = new ShowACard(this) { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            addACardForm = new AddACard(this) { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.AddRange(new Control[] { addACardForm, showACardForm, showFirstPageForm, startPageForm, watchCardsForm } );
            List<CardModel> cards = DBAccess.LoadCards();
            if(cards.Count != 0)
            {
                LastID = cards[cards.Count - 1].ID;
            }
            else
            {
                LastID = 0;
            }
            startPageForm.Show();
        }

        public void ShowStartPageForm(Form caller)
        {
            caller.Hide();
            caller.TopMost = false;
            startPageForm.Show();
            startPageForm.TopMost = true;
        }
        public void ShowWatchCardsForm(Form caller)
        {
            caller.Hide();
            caller.TopMost = false;
            watchCardsForm.LoadCards();
            watchCardsForm.Show();
            watchCardsForm.TopMost = true;
        }
        public void ShowShowFirstPageForm(Form caller)
        {
            caller.Hide();
            caller.TopMost = false;
            showFirstPageForm.Show();
            showFirstPageForm.TopMost = true;
        }
        public void ShowShowACardForm(Form caller)
        {
            caller.Hide();
            caller.TopMost = false;
            showACardForm.Show();
            showACardForm.TopMost = true;
        }
        public void ShowAddACardForm(Form caller)
        {
            caller.Hide();
            caller.TopMost = false;
            addACardForm.Show();
            addACardForm.TopMost = true;
        }
    }
}
