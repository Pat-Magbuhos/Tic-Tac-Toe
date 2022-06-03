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
            }
        }
    }
}
