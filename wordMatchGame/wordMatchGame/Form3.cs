using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            if (int.Parse(count.Text) == 1)
            { button1.Text = "d";
                button2.Text = "a";
                button3.Text = "i";
                nextBtn.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(count.Text) > 5)
            {
                this.Hide();
                Form4 fm = new Form4();
                fm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += button3.Text;
        }

        private void checkWord_Click(object sender, EventArgs e)
        {
            if (int.Parse(count.Text) == 1)
            {
                if (label1.Text == "aid" && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 3).ToString();
                        if (int.Parse(count.Text) == 2)
                        {
                            button1.Text = "a";
                            button2.Text = "g";
                            button3.Text = "b";
                            nextBtn.Enabled = false;
                        }
                    }
                }
                else if (label1.Text != "aid")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
            }
            else if (int.Parse(count.Text) == 2)
            {
                if (label1.Text == "bag" && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 3).ToString();
                        if (int.Parse(count.Text) == 3)
                        {
                            button1.Text = "a";
                            button2.Text = "p";
                            button3.Text = "c";
                            nextBtn.Enabled = false;
                        }
                    }
                }
                else if (label1.Text != "bag")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
            }
            else if (int.Parse(count.Text) == 3)
            {
                if ((label1.Text == "cap" || label1.Text == "pac") && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 3).ToString();
                        if (int.Parse(count.Text) == 4)
                        {
                            button1.Text = "u";
                            button2.Text = "g";
                            button3.Text = "d";
                            nextBtn.Enabled = false;
                        }
                    }
                }
                else if (label1.Text != "pac" || label1.Text != "cap")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
            }
            else if (int.Parse(count.Text) == 4)
            {
                if (label1.Text == "dug" && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 3).ToString();
                        if (int.Parse(count.Text) == 5)
                        {
                            button1.Text = "a";
                            button2.Text = "s";
                            button3.Text = "g";
                            nextBtn.Enabled = false;
                        }
                    }
                }
                else if (label1.Text != "dug")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
            }
            else if (int.Parse(count.Text) == 5)
            {
                if (label1.Text == "gas" && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        checkWord.Enabled = false;
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 3).ToString();
                        if (int.Parse(count.Text) == 6)
                        {
                            button1.Dispose();
                            button2.Dispose();
                            button3.Dispose();
                            label1.Text = "LOW level\nis COMPLETED\nClick Next\nto Proceed";
                        }
                    }
                    else if (label1.Text != "dug")
                    {
                        MessageBox.Show("Wrong Attempt");
                        label1.Text = "";
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    } 
}