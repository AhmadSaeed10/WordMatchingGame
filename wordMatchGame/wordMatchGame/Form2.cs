﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordMatchGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void lowBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fm = new Form3();
            fm.Show();
        }
        private void mediumBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fm = new Form4();
            fm.Show();
        }
        private void highBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 fm = new Form5();
            fm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mediumBtn.Enabled = false;
            highBtn.Enabled = false;
        }
    }
}
