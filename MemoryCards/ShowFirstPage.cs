﻿using System;
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
        public ShowFirstPage(Form owner)
        {
            mainForm = owner as MainForm;
            InitializeComponent();
        }
        public ShowFirstPage()
        {
            InitializeComponent();
        }
    }
}
