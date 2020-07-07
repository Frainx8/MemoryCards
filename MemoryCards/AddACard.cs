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
    public partial class AddACard : Form
    {
        private MainForm mainForm;
        private const int GROUP = 1;
        public AddACard(Form owner)
        {
            mainForm = owner as MainForm;
            InitializeComponent();
        }

        public AddACard()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addACardbtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(AddFirstbox.Text))
            {
                MessageBox.Show("Вы не написали первую сторону!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(AddSecondbox.Text))
            {
                MessageBox.Show("Вы не написали вторую сторону!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mainForm.LastID++; //Add one before adding in the DB
                CardModel card = new CardModel(mainForm.LastID, AddFirstbox.Text, AddSecondbox.Text, DateTime.Now.ToString("dd.MM.yy"), GROUP);
                DBAccess.SaveCard(card);
                AddFirstbox.Text = "";
                AddSecondbox.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.ShowStartPageForm(this);
        }

        private void AddACard_Load(object sender, EventArgs e)
        {

        }
    }
}
