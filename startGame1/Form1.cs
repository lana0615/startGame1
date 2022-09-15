using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace startGame1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            playGameButton.Visible = false;
            gameStartLabel3.Visible = false;
            gameStartLabel2.Visible = false;
            gameStartLabel1.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playGameButton.Visible = false;
            Refresh();


        }

        private void gameStartLabel3_Click(object sender, EventArgs e)
        {
           gameStartLabel3.Visible = true;
            Refresh();

            gameStartLabel3.Visible = false;
            gameStartLabel2.Visible = true;
            Refresh();

            gameStartLabel2.Visible = false;
            gameStartLabel1.Visible = true;
           

        }
    }
}
