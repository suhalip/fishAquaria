﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game_Trial
{
    public partial class Form1 : Form
    {
        GuessingGame g = new GuessingGame();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Box1_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood1())
                MessageBox.Show("Good Box");
            else
            {
                MessageBox.Show("Bad Box, the game will reset");
                g.ResetGuessingGame();
            }
            Money.Text = g.GetMoney();
        }

        private void Box2_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood2())
                MessageBox.Show("Good Box");
            else
            {
                MessageBox.Show("Bad Box, the game will reset");
                g.ResetGuessingGame();
            }
            Money.Text = g.GetMoney();
        }

        private void Box3_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood3())
                MessageBox.Show("Good Box");
            else
            {
                MessageBox.Show("Bad Box, the game will reset");
                g.ResetGuessingGame();
            }
            Money.Text = g.GetMoney();
        }

        private void Box4_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood4())
                MessageBox.Show("Good Box");
            else
            {
                MessageBox.Show("Bad Box, the game will reset");
                g.ResetGuessingGame();
            }
            Money.Text = g.GetMoney();
        }

        private void Box5_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood5())
                MessageBox.Show("Good Box");
            else
            {
                MessageBox.Show("Bad Box, the game will reset");
                g.ResetGuessingGame();
            }
            Money.Text = g.GetMoney();
        }

        private void Box6_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood6())
                MessageBox.Show("Good Box");
            else
            {
                MessageBox.Show("Bad Box, the game will reset");
                g.ResetGuessingGame();
            }
            Money.Text = g.GetMoney();
        }

        private void Box7_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood7())
                MessageBox.Show("Good Box");
            else
            {
                MessageBox.Show("Bad Box, the game will reset");
                g.ResetGuessingGame();
            }
            Money.Text = g.GetMoney();
        }

        private void Box8_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood8())
                MessageBox.Show("Good Box");
            else { 
            MessageBox.Show("Bad Box, the game will reset");
                g.ResetGuessingGame();
            }
            Money.Text = g.GetMoney();
        }

        private void Box9_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood9())
                MessageBox.Show("Good Box");
            else
            {
                MessageBox.Show("Bad Box, the game will reset");
                g.ResetGuessingGame();
            }
            Money.Text = g.GetMoney();
        }

        private void Money_Click(object sender, EventArgs e)
        {
            g.SetMoney(Money.Text);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            g.SetMoney(Money.Text);
        }
    }
}
