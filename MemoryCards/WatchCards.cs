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
        private Label lblWithID = new Label { Visible = false };
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
                secondPage.Name = "secP#" + card.ID;

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
            int id = Int32.Parse(label.Name.Substring(5));
            nullCard.ID = id;
            lblWithID.Name = id.ToString();
            CardModel card = DBAccess.LoadACard(nullCard);
            textBox1.Text = card.FirstPage;
            textBox2.Text = card.SecondPage;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            for(int i = tableLayoutPanel.RowCount - 1; i > 0; i --)
            {
                RemoveArbitraryRow(tableLayoutPanel, i);
            }
            mainForm.ShowStartPageForm(this);
        }

        private void WatchCards_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeCardbtn_Click(object sender, EventArgs e)
        {
            if(lblWithID.Name != "-1")
            {
                CardModel card = new CardModel() { ID = Int32.Parse(lblWithID.Name), FirstPage = textBox1.Text, SecondPage = textBox2.Text };
                DBAccess.UpdateCard(card);

                Label firLabel = Controls.Find("firP#" + lblWithID.Name, true).FirstOrDefault() as Label;
                firLabel.Text = card.FirstPage;
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if(lblWithID.Name != "-1")
            {
                CardModel card = new CardModel() { ID = Int32.Parse(lblWithID.Name) };
                DBAccess.DeleteCard(card);

                int rowIndex = tableLayoutPanel.GetRow(Controls.Find("firP#" + lblWithID.Name, true).FirstOrDefault());

                lblWithID.Name = "-1";

                textBox1.Text = "";
                textBox2.Text = "";

                RemoveArbitraryRow(tableLayoutPanel, rowIndex);
            }
        }

        private void RemoveArbitraryRow(TableLayoutPanel panel, int rowIndex)
        {
            if (rowIndex >= panel.RowCount)
            {
                return;
            }

            // delete all controls of row that we want to delete
            for (int i = 0; i < panel.ColumnCount; i++)
            {
                var control = panel.GetControlFromPosition(i, rowIndex);
                panel.Controls.Remove(control);
            }

            // move up row controls that comes after row we want to remove
            for (int i = rowIndex + 1; i < panel.RowCount; i++)
            {
                for (int j = 0; j < panel.ColumnCount; j++)
                {
                    var control = panel.GetControlFromPosition(j, i);
                    if (control != null)
                    {
                        panel.SetRow(control, i - 1);
                    }
                }
            }

            var removeStyle = panel.RowCount - 1;

            if (panel.RowStyles.Count > removeStyle)
                panel.RowStyles.RemoveAt(removeStyle);

            panel.RowCount--;
        }
    }
}
