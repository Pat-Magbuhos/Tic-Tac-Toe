using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        String Trn = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void Tile1_Click(object sender, EventArgs e)
        {
            if (Tile1.Text == "")
            {
                Tile1.Text = Trn;
                if (Trn == "X")
                {
                    Trn = "O";
                }
                else
                {
                    Trn = "X";
                }
                if (Tile1.Text == Tile5.Text)
                {
                    if (Tile5.Text == Tile7.Text)
                    {
                        MessageBox.Show("Player " + Tile1.Text + " is the Winner");
                        Tile1.Text = "";
                        Tile2.Text = "";
                        Tile3.Text = "";
                        Tile4.Text = "";
                        Tile5.Text = "";
                        Tile6.Text = "";
                        Tile7.Text = "";
                        Tile8.Text = "";
                        Tile9.Text = "";
                    }
                }
            }
        }

        private void Tile2_Click(object sender, EventArgs e)
        {
            if (Tile2.Text == "")
            {
                Tile2.Text = Trn;
                if (Trn == "X")
                {
                    Trn = "O";
                }
                else
                {
                    Trn = "X";
                }
            }
        }

        private void Tile3_Click(object sender, EventArgs e)
        {
            if (Tile3.Text == "")
            {
                Tile3.Text = Trn;
                if (Trn == "X")
                {
                    Trn = "O";
                }
                else
                {
                    Trn = "X";
                }
                if (Tile3.Text == Tile5.Text)
                {
                    if (Tile5.Text == Tile9.Text)
                    {
                        MessageBox.Show("Player " + Tile9.Text + " is the Winner");
                        Tile1.Text = "";
                        Tile2.Text = "";
                        Tile3.Text = "";
                        Tile4.Text = "";
                        Tile5.Text = "";
                        Tile6.Text = "";
                        Tile7.Text = "";
                        Tile8.Text = "";
                        Tile9.Text = "";
                    }
                }
            }
        }

        private void Tile4_Click(object sender, EventArgs e)
        {
            if (Tile4.Text == "")
            {
                Tile4.Text = Trn;
                if (Trn == "X")
                {
                    Trn = "O";
                }
                else
                {
                    Trn = "X";
                }
            }
        }

        private void Tile5_Click(object sender, EventArgs e)
        {
            if (Tile5.Text == "")
            {
                Tile5.Text = Trn;
                if (Trn == "X")
                {
                    Trn = "O";
                }
                else
                {
                    Trn = "X";
                }
                if (Tile5.Text == Tile7.Text)
                {
                    if (Tile7.Text == Tile1.Text)
                    {
                        MessageBox.Show("Player " + Tile1.Text + " is the Winner");
                        Tile1.Text = "";
                        Tile2.Text = "";
                        Tile3.Text = "";
                        Tile4.Text = "";
                        Tile5.Text = "";
                        Tile6.Text = "";
                        Tile7.Text = "";
                        Tile8.Text = "";
                        Tile9.Text = "";
                    }
                }
                if (Tile5.Text == Tile3.Text)
                {
                    if (Tile3.Text == Tile9.Text)
                    {
                        MessageBox.Show("Player " + Tile9.Text + " is the Winner");
                        Tile1.Text = "";
                        Tile2.Text = "";
                        Tile3.Text = "";
                        Tile4.Text = "";
                        Tile5.Text = "";
                        Tile6.Text = "";
                        Tile7.Text = "";
                        Tile8.Text = "";
                        Tile9.Text = "";
                    }
                }
            }
        }

        private void Tile6_Click(object sender, EventArgs e)
        {
            if (Tile6.Text == "")
            {
                Tile6.Text = Trn;
                if (Trn == "X")
                {
                    Trn = "O";
                }
                else
                {
                    Trn = "X";
                }
            }
        }

        private void Tile7_Click(object sender, EventArgs e)
        {
            if (Tile7.Text == "")
            {
                Tile7.Text = Trn;
                if (Trn == "X")
                {
                    Trn = "O";
                }
                else
                {
                    Trn = "X";
                }
                if (Tile7.Text == Tile5.Text)
                {
                    if (Tile5.Text == Tile1.Text)
                    {
                        MessageBox.Show("Player " + Tile1.Text + " is the Winner");
                        Tile1.Text = "";
                        Tile2.Text = "";
                        Tile3.Text = "";
                        Tile4.Text = "";
                        Tile5.Text = "";
                        Tile6.Text = "";
                        Tile7.Text = "";
                        Tile8.Text = "";
                        Tile9.Text = "";
                    }
                }
            }
        }

        private void Tile8_Click(object sender, EventArgs e)
        {
            if (Tile8.Text == "")
            {
                Tile8.Text = Trn;
                if (Trn == "X")
                {
                    Trn = "O";
                }
                else
                {
                    Trn = "X";
                }
            }
        }

        private void Tile9_Click(object sender, EventArgs e)
        {
            if (Tile9.Text == "")
            {
                Tile9.Text = Trn;
                if (Trn == "X")
                {
                    Trn = "O";
                }
                else
                {
                    Trn = "X";
                }
                if (Tile9.Text == Tile5.Text)
                {
                    if (Tile5.Text == Tile3.Text)
                    {
                        MessageBox.Show("Player " + Tile9.Text + " is the Winner");
                        Tile1.Text = "";
                        Tile2.Text = "";
                        Tile3.Text = "";
                        Tile4.Text = "";
                        Tile5.Text = "";
                        Tile6.Text = "";
                        Tile7.Text = "";
                        Tile8.Text = "";
                        Tile9.Text = "";
                    }
                }
            }
        }
    }
}
