﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
            game = new Game(this);
            game.InitGame();       
        }

        public void ButtonRightMap_Click(object sender, EventArgs e)
        {
            game.ButtonRightMapClicked((Button)sender);
            
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            game.BtnPlayClicked((Button)sender);
        }

        public void ButtonLefttMap_Click(object sender, EventArgs e)
        {
            label6.Focus();
            game.ButtonLeftMapClicked((Button)sender);

        }
    }
}
