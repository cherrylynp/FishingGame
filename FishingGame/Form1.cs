using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingGame
{
    //todo We need a Randmon Number Generator
    //todo We need a count down, or count up
    //todo We need to create a class
    //todo We need to make methods in the class (or move your methods to the class)
    //todo We need to Unit Test our project 2x
    //todo create/load sound and image
    //todo resource folder to store S & N
    //todo Host on GitHub


    public partial class Form1 : Form
    {



        GameCode myGameCode = new GameCode();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStep1_Click(object sender, EventArgs e)
        {
            //Step1-Bait the hook
            myGameCode.count = 0;


            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    internal class GameCode
    {
        public int count { get; set; }
    }
}
