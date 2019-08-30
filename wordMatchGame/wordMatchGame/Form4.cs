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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            if (int.Parse(count.Text) == 1)
            {
                button1.Text = "d";
                button2.Text = "o";
                button3.Text = "l";
                button5.Text = "a";
                label1.Text = "";
                nextBtn.Enabled = false;
            }
        }


        private void nextBtn_Click(object sender, EventArgs e)
        {
            count.Text = (int.Parse(count.Text) + 1).ToString();
         
            if (int.Parse(count.Text) > 5)
            {
                this.Hide();
                Form5 fm = new Form5();
                fm.Show();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void Check_Click(object sender, EventArgs e)
        {
            if (int.Parse(count.Text) == 1)
            {
                if (label1.Text == "load" && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 4).ToString();
                        if (int.Parse(count.Text) == 2)
                        {
                            button1.Text = "e";
                            button2.Text = "l";
                            button3.Text = "a";
                            button5.Text = "d";
                            nextBtn.Enabled = false;
                        }
                    }
                }
                else if (label1.Text != "load")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
            }
            else if (int.Parse(count.Text) == 2)
            {
                if ((label1.Text == "lead" || label1.Text == "deal")  && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 4).ToString();
                        if (int.Parse(count.Text) == 3)
                        {
                            button1.Text = "n";
                            button2.Text = "o";
                            button3.Text = "i";
                            button5.Text = "l";
                            nextBtn.Enabled = false;
                        }
                    }
                }
                else if (label1.Text != "lead" || label1.Text != "deal")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
            }
            else if (int.Parse(count.Text) == 3)
            {
                if ((label1.Text == "lion" ) && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 4).ToString();
                        if (int.Parse(count.Text) == 4)
                        {
                            button1.Text = "l";
                            button2.Text = "f";
                            button3.Text = "i";
                            button5.Text = "a";
                            nextBtn.Enabled = false;
                        }
                    }
                }
                else if (label1.Text != "lion")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
            }
            else if (int.Parse(count.Text) == 4)
            {
                if (label1.Text == "fail" && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 4).ToString();
                        if (int.Parse(count.Text) == 5)
                        {
                            button1.Text = "m";
                            button2.Text = "a";
                            button3.Text = "s";
                            button5.Text = "e";
                            nextBtn.Enabled = false;
                        }
                    }
                }
                else if (label1.Text != "fail")
                {
                    MessageBox.Show("Wrong Attempt");
                    label1.Text = "";
                }
            }
            else if (int.Parse(count.Text) == 5)
            {
                if (label1.Text == "same" && nextBtn.Enabled == false)
                {
                    nextBtn.Enabled = true;
                    if (MessageBox.Show("Word Accepted! Click Ok to Proceed") == DialogResult.OK)
                    {
                        Check.Enabled = false;
                        label1.Text = "";
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                        Score.Text = (int.Parse(Score.Text) + 4).ToString();
                        if (int.Parse(count.Text) == 6)
                        {
                            button1.Dispose();
                            button2.Dispose();
                            button3.Dispose();
                            button5.Dispose();
                            label1.Text = "MEDIUM level\nis COMPLETED\nClick Next\n to Proceed";
                        }

                    }
                    else if (label1.Text != "same")
                    {
                        MessageBox.Show("Wrong Attempt");
                        label1.Text = "";
                    }
                }
            }
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }
    }
}
