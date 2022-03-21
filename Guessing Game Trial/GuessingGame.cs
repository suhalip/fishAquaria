﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game_Trial
{
    class GuessingGame
    {
        bool goodBox1 = true;
        bool goodBox2 = true;
        bool goodBox3 = true;
        bool goodBox4 = true;
        bool goodBox5 = true;
        bool goodBox6 = true;
        bool goodBox7 = true;
        bool goodBox8 = true;
        bool goodBox9 = true;
        string badBox;
        string badNumber = "";
        int corrcetGuesses = 0;
        int money;


        Random rnd = new Random();

        public GuessingGame()
        { 
        }

        public void SetMoney(string num)
        {
            money = Int32.Parse(num);
        }

        public string GetMoney()
        {
            return money.ToString();
        }


        public string DetermineBadBox()
        {
            badBox = (rnd.Next(9) + 1).ToString();
            while (badNumber.Contains(badBox))
            {
                badBox = (rnd.Next(9) + 1).ToString();
            }
            
            switch (badBox)
            {
                case "1":
                    goodBox1 = false;
                    badNumber += "1";
                    break;
                case "2":
                    goodBox2 = false;
                    badNumber += "2";
                    break;
                case "3":
                    goodBox3 = false;
                    badNumber += "3";
                    break;
                case "4":
                    goodBox4 = false;
                    badNumber += "4";
                    break;
                case "5":
                    goodBox5 = false;
                    badNumber += "5";
                    break;
                case "6":
                    goodBox6 = false;
                    badNumber += "6";
                    break;
                case "7":
                    goodBox7 = false;
                    badNumber += "7";
                    break;
                case "8":
                    goodBox8 = false;
                    badNumber += "8";
                    break;
                case "9":
                    goodBox9 = false;
                    badNumber += "9";
                    break;
                default:
                    badBox = "0";
                    break;
            }

            return badBox;

        }

        public bool IsGood1()
        {
            if (goodBox1)
            {
                if (corrcetGuesses == 0)
                    money += 10;
                if (corrcetGuesses == 1)
                    money += 20;
                if (corrcetGuesses == 2)
                    money += 30;
                if (corrcetGuesses == 3)
                    money += 40;
                if (corrcetGuesses == 4)
                    money += 50;
                if (corrcetGuesses == 5)
                    money += 60;
                if (corrcetGuesses == 6)
                    money += 70;
                if (corrcetGuesses == 7)
                    money += 80;
                if (corrcetGuesses == 8)
                {
                    money += 90;
                    ResetGuessingGame();
                }

                ++corrcetGuesses;
            }

            return goodBox1;
        }
        public bool IsGood2()
        {
            if (goodBox2)
            {
                if (corrcetGuesses == 0)
                    money += 10;
                if (corrcetGuesses == 1)
                    money += 20;
                if (corrcetGuesses == 2)
                    money += 30;
                if (corrcetGuesses == 3)
                    money += 40;
                if (corrcetGuesses == 4)
                    money += 50;
                if (corrcetGuesses == 5)
                    money += 60;
                if (corrcetGuesses == 6)
                    money += 70;
                if (corrcetGuesses == 7)
                    money += 80;
                if (corrcetGuesses == 8)
                    money += 90;

                ++corrcetGuesses;

            }

            return goodBox2;
        }
        public bool IsGood3()
        {
            if (goodBox3)
            {
                if (corrcetGuesses == 0)
                    money += 10;
                if (corrcetGuesses == 1)
                    money += 20;
                if (corrcetGuesses == 2)
                    money += 30;
                if (corrcetGuesses == 3)
                    money += 40;
                if (corrcetGuesses == 4)
                    money += 50;
                if (corrcetGuesses == 5)
                    money += 60;
                if (corrcetGuesses == 6)
                    money += 70;
                if (corrcetGuesses == 7)
                    money += 80;
                if (corrcetGuesses == 8)
                    money += 90;

                ++corrcetGuesses;
            }

            return goodBox3;
        }
        public bool IsGood4()
        {
            if (goodBox4)
            {
                if (corrcetGuesses == 0)
                    money += 10;
                if (corrcetGuesses == 1)
                    money += 20;
                if (corrcetGuesses == 2)
                    money += 30;
                if (corrcetGuesses == 3)
                    money += 40;
                if (corrcetGuesses == 4)
                    money += 50;
                if (corrcetGuesses == 5)
                    money += 60;
                if (corrcetGuesses == 6)
                    money += 70;
                if (corrcetGuesses == 7)
                    money += 80;
                if (corrcetGuesses == 8)
                    money += 90;

                ++corrcetGuesses;
            }

            return goodBox4;
        }
        public bool IsGood5()
        {
            if (goodBox5)
            {
                if (corrcetGuesses == 0)
                    money += 10;
                if (corrcetGuesses == 1)
                    money += 20;
                if (corrcetGuesses == 2)
                    money += 30;
                if (corrcetGuesses == 3)
                    money += 40;
                if (corrcetGuesses == 4)
                    money += 50;
                if (corrcetGuesses == 5)
                    money += 60;
                if (corrcetGuesses == 6)
                    money += 70;
                if (corrcetGuesses == 7)
                    money += 80;
                if (corrcetGuesses == 8)
                    money += 90;

                ++corrcetGuesses;
            }

            return goodBox5;
        }
        public bool IsGood6()
        {
            if (goodBox6)
            {
                if (corrcetGuesses == 0)
                    money += 10;
                if (corrcetGuesses == 1)
                    money += 20;
                if (corrcetGuesses == 2)
                    money += 30;
                if (corrcetGuesses == 3)
                    money += 40;
                if (corrcetGuesses == 4)
                    money += 50;
                if (corrcetGuesses == 5)
                    money += 60;
                if (corrcetGuesses == 6)
                    money += 70;
                if (corrcetGuesses == 7)
                    money += 80;
                if (corrcetGuesses == 8)
                    money += 90;

                ++corrcetGuesses;
            }

            return goodBox6;
        }
        public bool IsGood7()
        {
            if (goodBox7)
            {
                if (corrcetGuesses == 0)
                    money += 10;
                if (corrcetGuesses == 1)
                    money += 20;
                if (corrcetGuesses == 2)
                    money += 30;
                if (corrcetGuesses == 3)
                    money += 40;
                if (corrcetGuesses == 4)
                    money += 50;
                if (corrcetGuesses == 5)
                    money += 60;
                if (corrcetGuesses == 6)
                    money += 70;
                if (corrcetGuesses == 7)
                    money += 80;
                if (corrcetGuesses == 8)
                    money += 90;

                ++corrcetGuesses;
            }

            return goodBox7;
        }
        public bool IsGood8()
        {
            if (goodBox8)
            {
                if (corrcetGuesses == 0)
                    money += 10;
                if (corrcetGuesses == 1)
                    money += 20;
                if (corrcetGuesses == 2)
                    money += 30;
                if (corrcetGuesses == 3)
                    money += 40;
                if (corrcetGuesses == 4)
                    money += 50;
                if (corrcetGuesses == 5)
                    money += 60;
                if (corrcetGuesses == 6)
                    money += 70;
                if (corrcetGuesses == 7)
                    money += 80;
                if (corrcetGuesses == 8)
                    money += 90;

                ++corrcetGuesses;
            }

            return goodBox8;
        }
        public bool IsGood9()
        {
            if (goodBox9)
            {
                if (corrcetGuesses == 0)
                    money += 10;
                if (corrcetGuesses == 1)
                    money += 20;
                if (corrcetGuesses == 2)
                    money += 30;
                if (corrcetGuesses == 3)
                    money += 40;
                if (corrcetGuesses == 4)
                    money += 50;
                if (corrcetGuesses == 5)
                    money += 60;
                if (corrcetGuesses == 6)
                    money += 70;
                if (corrcetGuesses == 7)
                    money += 80;
                if (corrcetGuesses == 8)
                    money += 90;

                ++corrcetGuesses;
            }

            return goodBox9;
        }

        public void ResetGuessingGame()
        {
            goodBox1 = true;
            goodBox2 = true;
            goodBox3 = true;
            goodBox4 = true;
            goodBox5 = true;
            goodBox6 = true;
            goodBox7 = true;
            goodBox8 = true;
            goodBox9 = true;
            badNumber = "";
            corrcetGuesses = 0;
        }


    }
}
