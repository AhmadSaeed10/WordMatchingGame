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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            if (int.Parse(count.Text) == 1)
            {
                button1.Text = "p";
                button2.Text = "a";
                button3.Text = "p";
                button5.Text = "e";
                button6.Text = "l";
                label1.Text = "";
                nextBtn.Enabled = false;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            count.Text = (int.Parse(count.Text) + 1).ToString();

            if (int.Parse(count.Text) > 5)
            {
                if (MessageBox.Show("Do You Want to EXIT", "Exit OR New Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    this.Close();
                    welcomePage page = new welcomePage();
                    page.Show();
                }
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

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
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += button5.Text;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += button6.Text;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (int.Parse(count.Text) == 1)
            {
                if (label1.Text == "apple" && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 5).ToString();
                        if (int.Parse(count.Text) == 2)
                        {
                            button1.Text = "h";
                            button2.Text = "t";
                            button3.Text = "s";
                            button5.Text = "g";
                            button6.Text = "o";
                            nextBtn.Enabled = false;
                        }
                    }
                }
                else if (label1.Text != "apple")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
            }
            else if (int.Parse(count.Text) == 2)
            {
                if ((label1.Text == "ghost") && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 5).ToString();
                        if (int.Parse(count.Text) == 3)
                        {
                            button1.Text = "s";
                            button2.Text = "a";
                            button3.Text = "s";
                            button5.Text = "l";
                            button6.Text = "g";
                            nextBtn.Enabled = false;
                        }
                    }
                }
                else if (label1.Text != "ghost")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
            }
            else if (int.Parse(count.Text) == 3)
            {
                if ((label1.Text == "glass") && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 5).ToString();
                        if (int.Parse(count.Text) == 4)
                        {
                            button1.Text = "s";
                            button2.Text = "u";
                            button3.Text = "n";
                            button5.Text = "d";
                            button6.Text = "i";
                            nextBtn.Enabled = false;
                        }
                    }
                }
                else if (label1.Text != "glass")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
            }
            else if (int.Parse(count.Text) == 4)
            {
                if (label1.Text == "indus" && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 5).ToString();
                        if (int.Parse(count.Text) == 5)
                        {
                            button1.Text = "n";
                            button2.Text = "a";
                            button3.Text = "d";
                            button5.Text = "p";
                            button6.Text = "a";
                            nextBtn.Enabled = false;
                        }
                    }
                }
                else if (label1.Text != "indus")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
            }
            else if (int.Parse(count.Text) == 5)
            {
                if (label1.Text == "panda" && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        Check.Enabled = false;
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 5).ToString();
                        if (int.Parse(count.Text) == 6)
                        {
                            button1.Dispose();
                            button2.Dispose();
                            button3.Dispose();
                            button5.Dispose();
                            button6.Dispose();
                            label1.Text = "CONGRATES!\nYou have WON\nYour game";
                        }
                        
                    }

                    
                }
                else if (label1.Text != "panda")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
                }
            }
        }
    }

