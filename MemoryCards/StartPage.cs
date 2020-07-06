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
    public partial class StartPage : Form
    {
        private MainForm mainForm;

        public StartPage()
        {
            InitializeComponent();
        }

        public StartPage(Form owner)
        {
            mainForm = owner as MainForm;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void AddCardsbtn_Click(object sender, EventArgs e)
        {
            mainForm.ShowAddACardForm(this);

        }
    }
}
